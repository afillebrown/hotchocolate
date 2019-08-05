using HotChocolate.Language;
using HotChocolate.Subscriptions;
using StarWars.Models;

namespace StarWars
{
    public class OnReviewMessage
        : EventMessage
    {
        public OnReviewMessage(OnReviewInput input, Review review)
            : base(CreateEventDescription(input), review)
        {
        }

        private static EventDescription CreateEventDescription(OnReviewInput input)
        {
            return new EventDescription("onReview",
                new ArgumentNode("input",
                    new ObjectValueNode(
                        new ObjectFieldNode("episode",
                            new EnumValueNode(input.Episode.ToString().ToUpperInvariant())))));
        }
    }
}
