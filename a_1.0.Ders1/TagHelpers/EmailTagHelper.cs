using Microsoft.AspNetCore.Razor.TagHelpers;

namespace a_1._0.Ders1.TagHelpers
{
	//[HtmlTargetElement("ahmet")]
	public class EmailTagHelper:TagHelper
	{
        //custom taghelpers
        public string Mail { get; set; }
        public string Display { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";
			output.Attributes.Add("href", $"mailto:{Mail}");
			output.Content.Append(Display);
			//base.Process(context, output);
		}
	}
}

//Bir sınıfın tagherlper olanılmesı ıcın taghelper sınıfından turemesı gerekır 
//tag helper ın ıslevsellık gostere bılmesı ıcın Proses methodunun overıde edılmesı gerekmektedir
//context parametresınde ılgılı taghelperı getırmektedir attributes,uniqueid
//ilgili attirbutun cıktısını bızlere vermektedır