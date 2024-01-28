using System.IO;

namespace Proiect.Categories
{
    internal class FisierText
    {
        private string QwestionAnswerText;
        //construcotrul pt fisiertext
        public FisierText(string QwestionAnswerText)
        {
            this.QwestionAnswerText = QwestionAnswerText;
        }
        //adauga un text in fisier
        public void AppendResponse(string response)
        {
            //adauga textul in fisierul
            File.AppendAllText(QwestionAnswerText, response);
        }
    }
}
