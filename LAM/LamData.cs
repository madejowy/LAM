using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAM
{
    public class LamData
    {
        //static LamDataEntities entities = new LamDataEntities();
        public List<Question> getAllQuestions()
        {
            LamDataEntities entities = new LamDataEntities();
            return entities.Questions.ToList();
        }
        public Question getSingleQuestion(List<Question> qias, int numberOfAnswers)
        {
            var question = qias
                .Where(r => r.NumOfAns == numberOfAnswers)
                .OrderBy(r => Guid.NewGuid())
                .Take(1)
                .Single();
            return question;
        }

        public void usedQuestion(List<Question> qias, Question question)
        {
            qias.Remove(question);
        }
    }
}
