using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniShop.Shared.Extensions
{
    public static class EnumExtensions
    {
        //enum ın sistem sınıfını genişletiyoruz. var olan özelliklerine yeni bir özellik ekliyoruz.
        //tüm enumlar bu metodu kullanabilir.
        
        public static string GetDisplayName(this Enum value)
        {
            string result= value
                .GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName();
            return result;
        }
    }
}
