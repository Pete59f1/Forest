using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Game
{
    public class Game: IPublisher
    {
        //Observer
        List<ISubscriber> subs = new List<ISubscriber>();

        public void RegisterSubscriber(ISubscriber observer)
        {
            subs.Add(observer);
        }

        public void RemoveSubscriber(ISubscriber observer)
        {
            subs.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber sub in subs)
            {
                sub.Update(this);
            }
        }
        //Observer

        public Game ()
        {
            Deck.GenerateCardDeck();
        }
    }
}
