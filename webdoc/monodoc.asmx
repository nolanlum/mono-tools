<%@ WebService language="C#" class="Editing" %>

// MonoDoc Editing WebService
//
// (C) 2003 by Johannes Roith
// Author: Johannes Roith

// Client API:
//
// Editing edit = new Editing();
// Response response = edit.Submit("Johannes Roith", "johannes@jroith.de",
//                      "This is a change through monodoc editing.", xml);

// response contains:
// a server status message (response.Message)
// a statuscode (response.Status)

// Statuscodes:
//
// 1 - everything went right
// 2 - the xml is not well-formed.
// 3 - some data is missing (email, name, etc.).
// 4 - the data was already posted
// 5 - Some internal Server error


using System;
using System.Web.Services;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.Security.Cryptography;

[WebService(Namespace="http://www.go-mono.org/monodoc")]
public class Editing {

    [WebMethod]
    public Response Submit(string author, string email, string personalmessage, string xmldata) {

        Response response;
        string newsum = GetMd5Sum(xmldata);
        XmlElement dataroot;
        XmlDocument oldposts;
        string today = Convert.ToString(DateTime.Now.DayOfYear);

        try {


        oldposts = new XmlDocument();
        oldposts.Load("oldposts.xml");

        dataroot = oldposts.DocumentElement;

        // Eventually only block in certain time frame?
        // XmlNodeList datanodes = dataroot.SelectNodes("/oldposts/post[@date='" + today + "']");

        XmlNodeList datanodes = dataroot.SelectNodes("/oldposts/post");

        foreach(XmlNode datanode in datanodes) {
            if (datanode.Attributes["md5"].Value == newsum) {

                response = new Response();
                response.Status = 4;
                response.Message = "This was already posted.";

                return response;
            }
        }

        if (xmldata == "")
        {

            response = new Response();
            response.Status = 2;
            response.Message = "Xml not well-formed. No data was posted.";

            return response;
        }

        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmldata);

        XmlElement root = doc.DocumentElement;
        XmlNodeList nodes = root.SelectNodes("/GlobalChangeset/DocSetChangeset");

        // IMO it's best to generate different Mails for
        // different DocSets, so the correct people can get their hands on it.
        // e.g one mail for Gtk#, one for ecma docs.

        foreach (XmlNode node in nodes) {

            string datastring = "";

            XmlNodeList filenodes = node.SelectNodes("FileChangeset");


           foreach (XmlNode filenode in filenodes) {
            datastring += RenderFileSet(filenode);
           }

            string target = node.Attributes["DocSet"].Value;

            string header = "---------------------\n"
                        + "MonoDoc Change\n"
                        + "---------------------\n\n"
                        + "This mail was generated by monodoc.\n\n"
                        + "--------------------------------------------------\n"
                        + "Author: " + author + "\n"
                        + "EMail: "  + email  + "\n"
                        + "personal Message: " + personalmessage + "\n\n"
                        + "--------------------------------------------------\n\n"
                        + "Changes are listed below:\n\n"
                        + "*************************************\n\n";

            string footer = "\n\n---------------------------------------\n"
                          + "Monodoc Editing WebService";

            SendMail("Monodoc: " + target, header + datastring + footer);
        }

        }

        catch {

            response = new Response();
            response.Status = 5;
            response.Message = "An unknown error occured.";

            return response;

        }


        XmlNode rootnode = dataroot.SelectSingleNode("/oldposts");

        XmlElement newentry = oldposts.CreateElement("post");
        newentry.SetAttribute("md5", newsum);
        newentry.SetAttribute("date", today);
        rootnode.AppendChild(newentry);
        oldposts.Save("oldposts.xml");

        response = new Response();
        response.Status = 1;
        response.Message = "Your changes were sent to Mono Docs List.\n"
                        + "They will be reviewed as soon as possible.";

        return response;

    }

    string RenderFileSet(XmlNode filenode) {

    // Rendering should be improved eventually,
    // so no xml remains.

       return "FILE: " + filenode.Attributes["RealFile"] + "\n\n"
                  + filenode.InnerXml
                  + "\n\n*************************************\n\n";
    }

    public class Response {

        public int Status;
        public string Message;
    }

    public void SendMail(string subject, string body) {

        System.Web.Mail.MailMessage mailMessage = new System.Web.Mail.MailMessage();

        // NOTE: I have made this "groith@tcrz.net", 
        //       so it won't be blocked.
        //       Should be changed later.

        mailMessage.From = "groith@tcrz.net";
        mailMessage.To = "mono-docs-list@ximian.com";
        mailMessage.Subject = subject;
        mailMessage.Body = body;
        mailMessage.BodyFormat = System.Web.Mail.MailFormat.Text;

        System.Web.Mail.SmtpMail.SmtpServer = "post.tcrz.net";
        System.Web.Mail.SmtpMail.Send(mailMessage);


    }

    // from http://weblog.stevex.org/radio/stories/2002/12/08/
    //      cCodeSnippetCreatingAnMd5HashString.html

    public string GetMd5Sum(string str)
    {
        Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

        byte[] unicodeText = new byte[str.Length * 2];
        enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);

        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] result = md5.ComputeHash(unicodeText);

        StringBuilder sb = new StringBuilder();
        for (int i=0;i<result.Length;i++)
        {
            sb.Append(result[i].ToString("X2"));
        }

        return sb.ToString();
}


}
