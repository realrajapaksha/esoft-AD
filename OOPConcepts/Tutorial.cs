using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Tutorial
    {
        int tutorialID;
        string tutorialName;

        public void setTutorial(int tutorialID, string tutorialName)
        {
            this.tutorialID = tutorialID;
            this.tutorialName = tutorialName;
        }

        public void getTutorial()
        {
            Console.WriteLine("Tutorial ID = " + tutorialID.ToString());
            Console.WriteLine("Tutorial Name = " + tutorialName);
        }
    }
}
