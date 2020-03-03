using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Trivia9
{
    class Trivia8
    {
        private StreamReader reader;
        Random gen;
        private int numQuestionsUsed = 0;
        private static int TOTAL_QUESTIONS = 5;
        private int[] questionsUsed;
        // needs a way to import Scanner method to recieve user input
        public Trivia8()
        {
            gen = new Random();
            questionsUsed = new int[TOTAL_QUESTIONS];
        }


        public String getQuestion(StreamReader reader)
        {
            reader = new StreamReader("FileTestQuestionsTest.txt");
            if (numQuestionsUsed < TOTAL_QUESTIONS)
            {
                numQuestionsUsed++;
                int possQ;
                do
                {
                    possQ = gen.Next(TOTAL_QUESTIONS) + 1;
                } while (possQTest(possQ, questionsUsed));
                questionsUsed[possQTest0(possQ, questionsUsed)] = possQ;
                //find in file
                int questionLine = possQ * 5 - 4;
                for(int b = 0; b < questionLine - 1; b++)
                {
                    reader.ReadLine();
                }
                String question = reader.ReadLine();
                String option1 = reader.ReadLine();
                String option2 = reader.ReadLine();
                String option3 = reader.ReadLine();
                String option4 = reader.ReadLine();
                return question + "\n" + option1 + "\n" + option2 + "\n" + option3 + "\n" + option4;
            }
            else
            {
                return "No Questions Left.";
            }
        }

        public String getAnswer(StreamReader reader, int QuestionNum) 
        {
            reader = new StreamReader("FileTestAnswersTest.txt");
            for(int i = 1; i < QuestionNum; i++ )
            {
                reader.ReadLine();
            }
            String answer = reader.ReadLine();
            return answer;

        }
        public static Boolean possQTest(int possQ, int[] questionsUsed)
        {
            for (int a = 0; a < questionsUsed.Length; a++) 
            {
                if (possQ == questionsUsed[a])
                {
                    return true;
                } 
            }
            return false;
        }

        public static int possQTest0(int possQ, int[] questionsUsed)
        {
            for (int a = 0; a < questionsUsed.Length; a++)
            {
                if (0 == questionsUsed[a])
                {
                    return a;
                }
            }
            return -1;
            
        }
        //allows Player to answer questions to escape Wumpus.
        /*
        public Boolean escapeWumpus3() // 3/5 Questions must be correct 
        {

            return true;
        } 
        
                 // allows Player to answer questions to recieve an arrow. also for escaping pit, and getting hint.
        public Boolean 2/5() // 2/3 Questions must be correct. needs Scanner parameter
        {

            return true;
        }

        // retrieves and prints hint.
        public String getHint(String str1)
        {
            String str = "hint!";

            return str;
        }
        */
    }
}
