using MulberryPhotos.DataAccess.Enums;
using MvcWideSite.Enums;

namespace MvcWideSite.Models
{  
    public class RoutingValue
    {
        public string RouteValue { get; set; }

        public RoutingEnum RoutingEnumValue { get; set; }

        public WebPageNameEnum PageNameEnum { get; set; }

        private RoutingValue(string routeName, WebPageNameEnum webPageEnum, RoutingEnum routingEnumValue)
        {
            RouteValue = routeName;
            PageNameEnum = webPageEnum;
            RoutingEnumValue = routingEnumValue;
        }
                
     
        public static RoutingValue Get(string routeName)
        {
            switch (routeName.ToLower())
            {
                case "home":
                    return new RoutingValue(routeName, WebPageNameEnum.HomePage, RoutingEnum.Home);

                case "family":
                    return new RoutingValue(routeName, WebPageNameEnum.FamilyPortrait, RoutingEnum.Family);

                case "babies-and-toddlers":
                    return new RoutingValue(routeName, WebPageNameEnum.BabiesAndToddlers, RoutingEnum.Babiesandtoddlers);

                case "childrens-and-teens":
                    return new RoutingValue(routeName, WebPageNameEnum.ChidrensAndTeens, RoutingEnum.Childrensandteens);

                case "generations":
                    return new RoutingValue(routeName, WebPageNameEnum.Generations, RoutingEnum.Generations);

                case "prices-and-products":
                    return new RoutingValue(routeName, WebPageNameEnum.PriceAndProducts, RoutingEnum.Pricesandproducts);

                case "frequently-asked-questions":
                    return new RoutingValue(routeName, WebPageNameEnum.FrequentlyAskedQuestions, RoutingEnum.Frequentlyaskedquestions);

                case "about":
                    return new RoutingValue(routeName, WebPageNameEnum.About, RoutingEnum.About);

                case "contact":
                    return new RoutingValue(routeName, WebPageNameEnum.Contact, RoutingEnum.Contact);

                default:
                    return null;
            }
        }       
    }
}