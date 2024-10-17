using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 搜索的可选参数，其中每个参数仅对部分服务类型生效，具体可参见服务类型说明。
    /// </summary>
    public class SearchOptionalParam 
    {
        /// <summary>
        /// 文本字符串的语言类型枚举值。
        /// </summary>
        /// <value>文本字符串的语言类型枚举值。</value>
        [JsonConverter(typeof(EnumClassConverter<TextLangEnum>))]
        public class TextLangEnum
        {
            /// <summary>
            /// Enum AR for value: ar
            /// </summary>
            public static readonly TextLangEnum AR = new TextLangEnum("ar");

            /// <summary>
            /// Enum DE for value: de
            /// </summary>
            public static readonly TextLangEnum DE = new TextLangEnum("de");

            /// <summary>
            /// Enum RU for value: ru
            /// </summary>
            public static readonly TextLangEnum RU = new TextLangEnum("ru");

            /// <summary>
            /// Enum FR for value: fr
            /// </summary>
            public static readonly TextLangEnum FR = new TextLangEnum("fr");

            /// <summary>
            /// Enum KO for value: ko
            /// </summary>
            public static readonly TextLangEnum KO = new TextLangEnum("ko");

            /// <summary>
            /// Enum PT for value: pt
            /// </summary>
            public static readonly TextLangEnum PT = new TextLangEnum("pt");

            /// <summary>
            /// Enum JA for value: ja
            /// </summary>
            public static readonly TextLangEnum JA = new TextLangEnum("ja");

            /// <summary>
            /// Enum TH for value: th
            /// </summary>
            public static readonly TextLangEnum TH = new TextLangEnum("th");

            /// <summary>
            /// Enum TR for value: tr
            /// </summary>
            public static readonly TextLangEnum TR = new TextLangEnum("tr");

            /// <summary>
            /// Enum ES for value: es
            /// </summary>
            public static readonly TextLangEnum ES = new TextLangEnum("es");

            /// <summary>
            /// Enum EN for value: en
            /// </summary>
            public static readonly TextLangEnum EN = new TextLangEnum("en");

            /// <summary>
            /// Enum VI for value: vi
            /// </summary>
            public static readonly TextLangEnum VI = new TextLangEnum("vi");

            /// <summary>
            /// Enum ZH for value: zh
            /// </summary>
            public static readonly TextLangEnum ZH = new TextLangEnum("zh");

            /// <summary>
            /// Enum ZHTW for value: zhTW
            /// </summary>
            public static readonly TextLangEnum ZHTW = new TextLangEnum("zhTW");

            private static readonly Dictionary<string, TextLangEnum> StaticFields =
            new Dictionary<string, TextLangEnum>()
            {
                { "ar", AR },
                { "de", DE },
                { "ru", RU },
                { "fr", FR },
                { "ko", KO },
                { "pt", PT },
                { "ja", JA },
                { "th", TH },
                { "tr", TR },
                { "es", ES },
                { "en", EN },
                { "vi", VI },
                { "zh", ZH },
                { "zhTW", ZHTW },
            };

            private string _value;

            public TextLangEnum()
            {

            }

            public TextLangEnum(string value)
            {
                _value = value;
            }

            public static TextLangEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TextLangEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TextLangEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TextLangEnum a, TextLangEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TextLangEnum a, TextLangEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否进行目标检测，默认为true。
        /// </summary>
        [JsonProperty("do_det", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoDet { get; set; }

        /// <summary>
        /// 目标矩形框坐标，如给定则不进行目标检测，直接使用该box作为目标。格式为“x1,y1,x2,y2”（无空格），x1/y1为目标左上角坐标，x2/y2为目标右下角坐标，具体要求如下： - 0 &lt;&#x3D; x1 &lt; x2 &lt;&#x3D; width，默认要求x2-x1 &gt;&#x3D; 15，具体可参考服务类型说明。 - 0 &lt;&#x3D; y1 &lt; y2 &lt;&#x3D; height，默认要求y2-y1 &gt;&#x3D; 15，具体可参考服务类型说明。
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public string Box { get; set; }

        /// <summary>
        /// 是否进行对象分类，默认为true。
        /// </summary>
        [JsonProperty("do_cls", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoCls { get; set; }

        /// <summary>
        /// 对象类目，如给定则不进行对象分类，直接使用该category作为类目。具体类目信息可参见对应的服务类型说明。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }

        /// <summary>
        /// 去重标签名，必须为服务实例custom_tags中已存在的key。 - 如给定则会对该key下相同value的数据进行去重，仅保留得分最高的数据。 - 针对没有设置该标签的数据，会直接过滤。
        /// </summary>
        [JsonProperty("collapse_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CollapseKey { get; set; }

        /// <summary>
        /// 扫描节点上限。值越大精度越高，查询速度变慢。默认值为10000。
        /// </summary>
        [JsonProperty("max_scan_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxScanNum { get; set; }

        /// <summary>
        /// 查询考察中心点的数目。值越大精度越高，查询速度变慢。默认值为100。
        /// </summary>
        [JsonProperty("nprobe", NullValueHandling = NullValueHandling.Ignore)]
        public int? Nprobe { get; set; }

        /// <summary>
        /// 文本字符串的语言类型枚举值。
        /// </summary>
        [JsonProperty("text_lang", NullValueHandling = NullValueHandling.Ignore)]
        public TextLangEnum TextLang { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchOptionalParam {\n");
            sb.Append("  doDet: ").Append(DoDet).Append("\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("  doCls: ").Append(DoCls).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  collapseKey: ").Append(CollapseKey).Append("\n");
            sb.Append("  maxScanNum: ").Append(MaxScanNum).Append("\n");
            sb.Append("  nprobe: ").Append(Nprobe).Append("\n");
            sb.Append("  textLang: ").Append(TextLang).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchOptionalParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchOptionalParam input)
        {
            if (input == null) return false;
            if (this.DoDet != input.DoDet || (this.DoDet != null && !this.DoDet.Equals(input.DoDet))) return false;
            if (this.Box != input.Box || (this.Box != null && !this.Box.Equals(input.Box))) return false;
            if (this.DoCls != input.DoCls || (this.DoCls != null && !this.DoCls.Equals(input.DoCls))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CollapseKey != input.CollapseKey || (this.CollapseKey != null && !this.CollapseKey.Equals(input.CollapseKey))) return false;
            if (this.MaxScanNum != input.MaxScanNum || (this.MaxScanNum != null && !this.MaxScanNum.Equals(input.MaxScanNum))) return false;
            if (this.Nprobe != input.Nprobe || (this.Nprobe != null && !this.Nprobe.Equals(input.Nprobe))) return false;
            if (this.TextLang != input.TextLang) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.DoDet != null) hashCode = hashCode * 59 + this.DoDet.GetHashCode();
                if (this.Box != null) hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.DoCls != null) hashCode = hashCode * 59 + this.DoCls.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CollapseKey != null) hashCode = hashCode * 59 + this.CollapseKey.GetHashCode();
                if (this.MaxScanNum != null) hashCode = hashCode * 59 + this.MaxScanNum.GetHashCode();
                if (this.Nprobe != null) hashCode = hashCode * 59 + this.Nprobe.GetHashCode();
                hashCode = hashCode * 59 + this.TextLang.GetHashCode();
                return hashCode;
            }
        }
    }
}
