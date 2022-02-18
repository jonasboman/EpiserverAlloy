using EPiServer.Core;

namespace EpiserverAlloy.Web.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
