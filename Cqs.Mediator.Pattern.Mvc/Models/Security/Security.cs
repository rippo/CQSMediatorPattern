namespace Cqs.Mediator.Pattern.Mvc.Models.Security
{
    public class Security : ISecurity
    {
        readonly int currentUserId;

        public Security()
        {
            currentUserId = 999;
        }


        public int CurrentUserId
        {
            get { return currentUserId; } 
        }

    }
}