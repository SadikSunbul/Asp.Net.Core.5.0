using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Reflection;

namespace Ders9._3.ViewModel_DTO.Busineis
{
    public static class TypConversion
    {
        
        public static TResult Conversion<T,TResult>( T model) where TResult : class,new() 
        {
            TResult result=new TResult();
            //GetProperties() t de ne kadar property varsa elde edıyoz
            typeof(T).GetProperties().ToList().ForEach(p => 
            {
                PropertyInfo property=typeof(TResult).GetProperty(p.Name);
                property.SetValue(result,p.GetValue(model));
            });

            return null;
        }
    }
}
