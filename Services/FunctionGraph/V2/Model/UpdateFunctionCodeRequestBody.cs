using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateFunctionCodeRequestBody 
    {
        /// <summary>
        /// 函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。
        /// </summary>
        /// <value>函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。</value>
        [JsonConverter(typeof(EnumClassConverter<CodeTypeEnum>))]
        public class CodeTypeEnum
        {
            /// <summary>
            /// Enum INLINE for value: inline
            /// </summary>
            public static readonly CodeTypeEnum INLINE = new CodeTypeEnum("inline");

            /// <summary>
            /// Enum ZIP for value: zip
            /// </summary>
            public static readonly CodeTypeEnum ZIP = new CodeTypeEnum("zip");

            /// <summary>
            /// Enum OBS for value: obs
            /// </summary>
            public static readonly CodeTypeEnum OBS = new CodeTypeEnum("obs");

            /// <summary>
            /// Enum JAR for value: jar
            /// </summary>
            public static readonly CodeTypeEnum JAR = new CodeTypeEnum("jar");

            /// <summary>
            /// Enum CUSTOM_IMAGE_SWR for value: Custom-Image-Swr
            /// </summary>
            public static readonly CodeTypeEnum CUSTOM_IMAGE_SWR = new CodeTypeEnum("Custom-Image-Swr");

            private static readonly Dictionary<string, CodeTypeEnum> StaticFields =
            new Dictionary<string, CodeTypeEnum>()
            {
                { "inline", INLINE },
                { "zip", ZIP },
                { "obs", OBS },
                { "jar", JAR },
                { "Custom-Image-Swr", CUSTOM_IMAGE_SWR },
            };

            private string _value;

            public CodeTypeEnum()
            {

            }

            public CodeTypeEnum(string value)
            {
                _value = value;
            }

            public static CodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CodeTypeEnum a, CodeTypeEnum b)
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

            public static bool operator !=(CodeTypeEnum a, CodeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。
        /// </summary>
        [JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public CodeTypeEnum CodeType { get; set; }
        /// <summary>
        /// 当CodeType为obs时，该值为函数代码包在OBS上的地址，CodeType为其他值时，该字段为空。
        /// </summary>
        [JsonProperty("code_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 函数的文件名，当CodeType为jar/zip时必须提供该字段，inline和obs不需要提供。
        /// </summary>
        [JsonProperty("code_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("func_code", NullValueHandling = NullValueHandling.Ignore)]
        public FuncCode FuncCode { get; set; }

        /// <summary>
        /// 依赖版本id列表
        /// </summary>
        [JsonProperty("depend_version_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependVersionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionCodeRequestBody {\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  funcCode: ").Append(FuncCode).Append("\n");
            sb.Append("  dependVersionList: ").Append(DependVersionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFunctionCodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFunctionCodeRequestBody input)
        {
            if (input == null) return false;
            if (this.CodeType != input.CodeType) return false;
            if (this.CodeUrl != input.CodeUrl || (this.CodeUrl != null && !this.CodeUrl.Equals(input.CodeUrl))) return false;
            if (this.CodeFilename != input.CodeFilename || (this.CodeFilename != null && !this.CodeFilename.Equals(input.CodeFilename))) return false;
            if (this.FuncCode != input.FuncCode || (this.FuncCode != null && !this.FuncCode.Equals(input.FuncCode))) return false;
            if (this.DependVersionList != input.DependVersionList || (this.DependVersionList != null && input.DependVersionList != null && !this.DependVersionList.SequenceEqual(input.DependVersionList))) return false;

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
                hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null) hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null) hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.FuncCode != null) hashCode = hashCode * 59 + this.FuncCode.GetHashCode();
                if (this.DependVersionList != null) hashCode = hashCode * 59 + this.DependVersionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
