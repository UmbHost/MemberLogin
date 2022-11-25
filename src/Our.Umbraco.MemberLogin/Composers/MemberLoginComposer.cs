using Our.Umbraco.MemberLogin.Core.TreeNotificationHandlers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;

namespace Our.Umbraco.MemberLogin.Composers
{
    public class MemberLoginComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.AddNotificationHandler<MenuRenderingNotification, MemberLoginTreeNotificationHandler>();
        }
    }
}
