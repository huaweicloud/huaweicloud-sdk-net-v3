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
        /// 支持语言类型：java、c、cpp、python、javaScript
        /// </summary>
        /// <value>支持语言类型：java、c、cpp、python、javaScript</value>
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

            /// <summary>
            /// Enum JAVASCRIPT for value: javaScript
            /// </summary>
            public static readonly RuntimeTypeEnum JAVASCRIPT = new RuntimeTypeEnum("javaScript");

            private static readonly Dictionary<string, RuntimeTypeEnum> StaticFields =
            new Dictionary<string, RuntimeTypeEnum>()
            {
                { "java", JAVA },
                { "c", C },
                { "cpp", CPP },
                { "python", PYTHON },
                { "javaScript", JAVASCRIPT },
            };

            private string _value;

            public RuntimeTypeEnum()
            {

            }

            public RuntimeTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）、caseout（用例运行返回）、judgeout（用例对比返回）
        /// </summary>
        /// <value>结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）、caseout（用例运行返回）、judgeout（用例对比返回）</value>
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

            /// <summary>
            /// Enum CASEOUT for value: caseout
            /// </summary>
            public static readonly OutputTypeEnum CASEOUT = new OutputTypeEnum("caseout");

            /// <summary>
            /// Enum JUDGEOUT for value: judgeout
            /// </summary>
            public static readonly OutputTypeEnum JUDGEOUT = new OutputTypeEnum("judgeout");

            private static readonly Dictionary<string, OutputTypeEnum> StaticFields =
            new Dictionary<string, OutputTypeEnum>()
            {
                { "sysout", SYSOUT },
                { "fileout", FILEOUT },
                { "imgout", IMGOUT },
                { "caseout", CASEOUT },
                { "judgeout", JUDGEOUT },
            };

            private string _value;

            public OutputTypeEnum()
            {

            }

            public OutputTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 支持语言类型：java、c、cpp、python、javaScript
        /// </summary>
        [JsonProperty("runtime_type", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeTypeEnum RuntimeType { get; set; }
        /// <summary>
        /// 代码运行超时时间，单位为秒
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 结果返回类型：sysout（标准输出）、fileout（以文件形式输出）、imgout（以图片形式输出）、caseout（用例运行返回）、judgeout（用例对比返回）
        /// </summary>
        [JsonProperty("output_type", NullValueHandling = NullValueHandling.Ignore)]
        public OutputTypeEnum OutputType { get; set; }
        /// <summary>
        /// 当判题结果类型是caseout和judgeout类型才需要传的字段，表示用例数据
        /// </summary>
        [JsonProperty("testcases", NullValueHandling = NullValueHandling.Ignore)]
        public List<JudgementCaseInfo> Testcases { get; set; }



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
            sb.Append("  testcases: ").Append(Testcases).Append("\n");
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
            if (input == null) return false;
            if (this.NotifyUrl != input.NotifyUrl || (this.NotifyUrl != null && !this.NotifyUrl.Equals(input.NotifyUrl))) return false;
            if (this.CodeType != input.CodeType) return false;
            if (this.SourceCode != input.SourceCode || (this.SourceCode != null && !this.SourceCode.Equals(input.SourceCode))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RuntimeType != input.RuntimeType) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.OutputType != input.OutputType) return false;
            if (this.Testcases != input.Testcases || (this.Testcases != null && input.Testcases != null && !this.Testcases.SequenceEqual(input.Testcases))) return false;

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
                if (this.NotifyUrl != null) hashCode = hashCode * 59 + this.NotifyUrl.GetHashCode();
                hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.SourceCode != null) hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.RuntimeType.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                hashCode = hashCode * 59 + this.OutputType.GetHashCode();
                if (this.Testcases != null) hashCode = hashCode * 59 + this.Testcases.GetHashCode();
                return hashCode;
            }
        }
    }
}
