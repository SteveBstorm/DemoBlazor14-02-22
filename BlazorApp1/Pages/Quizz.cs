using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public partial class Quizz
    {

        public int pos { get; set; } = 1;
        public string infoPos { get; set; }
        public List<string> Questions { get; set; }
        public List<string> Reponse { get; set; }

        public string User { get; set; }



        public string currentQuestion { get; set; }

        protected override void OnInitialized()
        {
            Reponse = new List<string>();
            Questions = new List<string>() {
                "Blazor permet-il de faire du SPA?",
                "Blazor est il facile d'accès ?",
                "L'exercice est-il bien compris?"};
            currentQuestion = Questions[0];
            infoPos = "voici la question n° " + pos;
        }

        public void Answer(string rep)
        {

            pos++;
            infoPos = "voici la question n° " + pos;
            Reponse.Add(rep);
            if (pos > Questions.Count)
            {
                currentQuestion = "";
                infoPos = " Vous avez terminé!";
            }
            else
            {
                currentQuestion = Questions[pos - 1];
            }
        }




    }
}
