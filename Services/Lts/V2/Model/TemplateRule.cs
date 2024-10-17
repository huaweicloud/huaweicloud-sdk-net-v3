using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 结构化模板规则对象
    /// </summary>
    public class TemplateRule 
    {
        /// <summary>
        /// 结构化类型，只支持custom_regex,json,split,nginx
        /// </summary>
        /// <value>结构化类型，只支持custom_regex,json,split,nginx</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum CUSTOM_REGEX for value: custom_regex
            /// </summary>
            public static readonly TypeEnum CUSTOM_REGEX = new TypeEnum("custom_regex");

            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly TypeEnum JSON = new TypeEnum("json");

            /// <summary>
            /// Enum SPLIT for value: split
            /// </summary>
            public static readonly TypeEnum SPLIT = new TypeEnum("split");

            /// <summary>
            /// Enum NGINX for value: nginx
            /// </summary>
            public static readonly TypeEnum NGINX = new TypeEnum("nginx");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "custom_regex", CUSTOM_REGEX },
                { "json", JSON },
                { "split", SPLIT },
                { "nginx", NGINX },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 结构化类型，只支持custom_regex,json,split,nginx
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 具体结构化规则，每种结构化类型都有自己独有的结构，具体结构如下： 手动正则为json字符串，包含keyObject对象和regex_rules对象，keyObject内为键值对，键为demo_fields数组中元素的index，值为field_name，regex_rules对象为正则表达式字符串，整体例子为{\\\&quot;keyObject\\\&quot;:{\\\&quot;1\\\&quot;:\\\&quot;date\\\&quot;,\\\&quot;2\\\&quot;:\\\&quot;num\\\&quot;},\\\&quot;regex_rules\\\&quot;:\\\&quot;^(?&lt;date&gt;[^/]+)(?:[^ ]* ){8}(?&lt;num&gt;\\\\\\\\d+)\\\&quot;}； json方式时param为一个json字符串，包含keyObject对象和layers对象，keyObject内为键值对，键为demo_fields数组中元素的field_name，值为user_defined_name，layers为最大解析层数，当前最大值为4，整体例子为{\\\&quot;keyObject\\\&quot;:{\\\&quot;metadata.dimention\\\&quot;:\\\&quot;dimention\\\&quot;,\\\&quot;metadata.value\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;metadata.unit\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;collectionTime\\\&quot;:\\\&quot;\\\&quot;},\\\&quot;layers\\\&quot;:3}； 分隔符方式时为json字符串，包含keyObject对象和tokenizer对象，keyObject内为键值对，键为demo_fields数组中元素的index，值为field_name，tokenizer对象为所用分隔符，整体例子为{\\\&quot;keyObject\\\&quot;:{\\\&quot;0\\\&quot;:\\\&quot;field1\\\&quot;,\\\&quot;1\\\&quot;:\\\&quot;field2\\\&quot;,\\\&quot;2\\\&quot;:\\\&quot;field3\\\&quot;,\\\&quot;3\\\&quot;:\\\&quot;field4\\\&quot;,\\\&quot;4\\\&quot;:\\\&quot;field5\\\&quot;,\\\&quot;5\\\&quot;:\\\&quot;field6\\\&quot;,\\\&quot;6\\\&quot;:\\\&quot;field7\\\&quot;,\\\&quot;7\\\&quot;:\\\&quot;field8\\\&quot;,\\\&quot;8\\\&quot;:\\\&quot;field9\\\&quot;},\\\&quot;tokenizer\\\&quot;:\\\&quot; \\\&quot;}； nginx方式时为json字符串，包含keyObject对象，regex对象，field_names对象及log_format对象，keyObject内为键值对，键为demo_fields数组中元素的field_name，值为user_defined_name，regex为正则表达式字符串，field_names对象为demo_fields数组中各元素的field_name的拼接字符串，每个field_name以&#39;,&#39;分隔，log_format对象为nginx日志格式化方式，具体方式参考https://support.huaweicloud.com/usermanual-lts/lts_0820.html#lts_0820__section1151119552549进行配置，整体例子为\&quot;{\\\&quot;keyObject\\\&quot;:{\\\&quot;http_host\\\&quot;:\\\&quot;host\\\&quot;,\\\&quot;remote_addr\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;request_method\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;request_uri\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;time_local\\\&quot;:\\\&quot;\\\&quot;},\\\&quot;regex\\\&quot;:\\\&quot;(\\\\\\\\d+/\\\\\\\\S+/\\\\\\\\d+:\\\\\\\\d+:\\\\\\\\d+:\\\\\\\\d+)\\\\\\\\s+\\\\\\\\S+\\\\\\\\s+(\\\\\\\\S*)\\\\\\\\s+(\\\\\\\\S*)\\\\\\\\s+(\\\\\\\\S*)\\\\\\\\s+\\\\\\\&quot;([^\\\\\\\&quot;]*)\\\\\\\&quot;.*\\\&quot;,\\\&quot;fieldNames\\\&quot;:\\\&quot;time_local,remote_addr,request_method,http_host,request_uri\\\&quot;,\\\&quot;log_format\\\&quot;:\\\&quot;log_format upstreaminfo &#39;$time_local $remote_addr  $request_method $http_host \\\\\\\&quot;$request_uri\\\\\\\&quot;&#39;;\\\&quot;}\&quot;
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRule {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  param: ").Append(Param).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateRule input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Param != input.Param || (this.Param != null && !this.Param.Equals(input.Param))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Param != null) hashCode = hashCode * 59 + this.Param.GetHashCode();
                return hashCode;
            }
        }
    }
}
