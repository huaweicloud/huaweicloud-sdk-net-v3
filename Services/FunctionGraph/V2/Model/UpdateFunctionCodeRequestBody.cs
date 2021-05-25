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
        /// 函数代码类型，取值有4种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。
        /// </summary>
        /// <value>函数代码类型，取值有4种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。</value>
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

            private static readonly Dictionary<string, CodeTypeEnum> StaticFields =
            new Dictionary<string, CodeTypeEnum>()
            {
                { "inline", INLINE },
                { "zip", ZIP },
                { "obs", OBS },
                { "jar", JAR },
            };

            private string Value;

            public CodeTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 函数执行入口 规则：xx.xx，必须包含“. ” 举例：对于node.js函数：myfunction.handler，则表示函数的文件名为myfunction.js，执行的入口函数名为handler。
        /// </summary>
        [JsonProperty("handler", NullValueHandling = NullValueHandling.Ignore)]
        public string Handler { get; set; }

        /// <summary>
        /// 函数代码类型，取值有4种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。
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
        /// 依赖id列表
        /// </summary>
        [JsonProperty("depend_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependList { get; set; }

        /// <summary>
        /// 函数依赖代码包列表。
        /// </summary>
        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dependency> Dependencies { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionCodeRequestBody {\n");
            sb.Append("  handler: ").Append(Handler).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  funcCode: ").Append(FuncCode).Append("\n");
            sb.Append("  dependList: ").Append(DependList).Append("\n");
            sb.Append("  dependencies: ").Append(Dependencies).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Handler == input.Handler ||
                    (this.Handler != null &&
                    this.Handler.Equals(input.Handler))
                ) && 
                (
                    this.CodeType == input.CodeType ||
                    (this.CodeType != null &&
                    this.CodeType.Equals(input.CodeType))
                ) && 
                (
                    this.CodeUrl == input.CodeUrl ||
                    (this.CodeUrl != null &&
                    this.CodeUrl.Equals(input.CodeUrl))
                ) && 
                (
                    this.CodeFilename == input.CodeFilename ||
                    (this.CodeFilename != null &&
                    this.CodeFilename.Equals(input.CodeFilename))
                ) && 
                (
                    this.FuncCode == input.FuncCode ||
                    (this.FuncCode != null &&
                    this.FuncCode.Equals(input.FuncCode))
                ) && 
                (
                    this.DependList == input.DependList ||
                    this.DependList != null &&
                    input.DependList != null &&
                    this.DependList.SequenceEqual(input.DependList)
                ) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.CodeType != null)
                    hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null)
                    hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null)
                    hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.FuncCode != null)
                    hashCode = hashCode * 59 + this.FuncCode.GetHashCode();
                if (this.DependList != null)
                    hashCode = hashCode * 59 + this.DependList.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
