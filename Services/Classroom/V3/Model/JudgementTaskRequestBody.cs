using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 下发判题任务请求参数
    /// </summary>
    public class JudgementTaskRequestBody 
    {
        /// <summary>
        /// 代码来源：inline（源代码）
        /// </summary>
        /// <value>代码来源：inline（源代码）</value>
        [JsonConverter(typeof(EnumClassConverter<CodeTypeEnum>))]
        public class CodeTypeEnum
        {
            /// <summary>
            /// Enum INLINE for value: inline
            /// </summary>
            public static readonly CodeTypeEnum INLINE = new CodeTypeEnum("inline");

            private static readonly Dictionary<string, CodeTypeEnum> StaticFields =
            new Dictionary<string, CodeTypeEnum>()
            {
                { "inline", INLINE },
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
        /// 支持语言类型：java、c、cpp、python
        /// </summary>
        /// <value>支持语言类型：java、c、cpp、python</value>
        [JsonConverter(typeof(EnumClassConverter<RuntimeTypeEnum>))]
        public class RuntimeTypeEnum
        {
            /// <summary>
            /// Enum JAVA for value: java
            /// </summary>
            public static readonly RuntimeTypeEnum JAVA = new RuntimeTypeEnum("java");

            /// <summary>
            /// Enum C for value: c
            /// </summary>
            public static readonly RuntimeTypeEnum C = new RuntimeTypeEnum("c");

            /// <summary>
            /// Enum CPP for value: cpp
            /// </summary>
            public static readonly RuntimeTypeEnum CPP = new RuntimeTypeEnum("cpp");

            /// <summary>
            /// Enum PYTHON for value: python
            /// </summary>
            public static readonly RuntimeTypeEnum PYTHON = new RuntimeTypeEnum("python");

            private static readonly Dictionary<string, RuntimeTypeEnum> StaticFields =
            new Dictionary<string, RuntimeTypeEnum>()
            {
                { "java", JAVA },
                { "c", C },
                { "cpp", CPP },
                { "python", PYTHON },
            };

            private string Value;

            public RuntimeTypeEnum(string value)
            {
                Value = value;
            }

            public static RuntimeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RuntimeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RuntimeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RuntimeTypeEnum a, RuntimeTypeEnum b)
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

            public static bool operator !=(RuntimeTypeEnum a, RuntimeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）
        /// </summary>
        /// <value>结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）</value>
        [JsonConverter(typeof(EnumClassConverter<OutputTypeEnum>))]
        public class OutputTypeEnum
        {
            /// <summary>
            /// Enum SYSOUT for value: sysout
            /// </summary>
            public static readonly OutputTypeEnum SYSOUT = new OutputTypeEnum("sysout");

            /// <summary>
            /// Enum FILEOUT for value: fileout
            /// </summary>
            public static readonly OutputTypeEnum FILEOUT = new OutputTypeEnum("fileout");

            /// <summary>
            /// Enum IMGOUT for value: imgout
            /// </summary>
            public static readonly OutputTypeEnum IMGOUT = new OutputTypeEnum("imgout");

            private static readonly Dictionary<string, OutputTypeEnum> StaticFields =
            new Dictionary<string, OutputTypeEnum>()
            {
                { "sysout", SYSOUT },
                { "fileout", FILEOUT },
                { "imgout", IMGOUT },
            };

            private string Value;

            public OutputTypeEnum(string value)
            {
                Value = value;
            }

            public static OutputTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OutputTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OutputTypeEnum a, OutputTypeEnum b)
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

            public static bool operator !=(OutputTypeEnum a, OutputTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 第三方指定的判题结果回调url，取值来源于伙伴通道“判题管理配置”-“接口管理”中设置的回调地址相同
        /// </summary>
        [JsonProperty("notify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 代码来源：inline（源代码）
        /// </summary>
        [JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public CodeTypeEnum CodeType { get; set; }
        /// <summary>
        /// 源代码，需Base64编码
        /// </summary>
        [JsonProperty("source_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCode { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 支持语言类型：java、c、cpp、python
        /// </summary>
        [JsonProperty("runtime_type", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeTypeEnum RuntimeType { get; set; }
        /// <summary>
        /// 代码运行超时时间，单位为秒
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）
        /// </summary>
        [JsonProperty("output_type", NullValueHandling = NullValueHandling.Ignore)]
        public OutputTypeEnum OutputType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JudgementTaskRequestBody {\n");
            sb.Append("  notifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  sourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  runtimeType: ").Append(RuntimeType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  outputType: ").Append(OutputType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JudgementTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JudgementTaskRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.CodeType == input.CodeType ||
                    (this.CodeType != null &&
                    this.CodeType.Equals(input.CodeType))
                ) && 
                (
                    this.SourceCode == input.SourceCode ||
                    (this.SourceCode != null &&
                    this.SourceCode.Equals(input.SourceCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RuntimeType == input.RuntimeType ||
                    (this.RuntimeType != null &&
                    this.RuntimeType.Equals(input.RuntimeType))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.OutputType == input.OutputType ||
                    (this.OutputType != null &&
                    this.OutputType.Equals(input.OutputType))
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
                if (this.NotifyUrl != null)
                    hashCode = hashCode * 59 + this.NotifyUrl.GetHashCode();
                if (this.CodeType != null)
                    hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.SourceCode != null)
                    hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RuntimeType != null)
                    hashCode = hashCode * 59 + this.RuntimeType.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.OutputType != null)
                    hashCode = hashCode * 59 + this.OutputType.GetHashCode();
                return hashCode;
            }
        }
    }
}
