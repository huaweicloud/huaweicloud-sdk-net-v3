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
    /// Response Object
    /// </summary>
    public class ShowFunctionCodeResponse : SdkResponse
    {
        /// <summary>
        /// FunctionGraph函数的执行环境 Java8: Java语言8版本。 Java11: Java语言11版本。 Java17: Java语言17版本（当前仅支持华北-乌兰察布二零二） Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Python3.10: Python语言3.10版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 Node.js16.17: Nodejs语言16.17版本。 Node.js18.15: Nodejs语言18.15版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 C#(.NET Core 6.0): C#语言6.0版本（当前仅支持华北-乌兰察布二零二）。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 Cangjie1.0：仓颉语言1.0版本。 http: HTTP函数。 Custom Image: 自定义镜像函数。
        /// </summary>
        /// <value>FunctionGraph函数的执行环境 Java8: Java语言8版本。 Java11: Java语言11版本。 Java17: Java语言17版本（当前仅支持华北-乌兰察布二零二） Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Python3.10: Python语言3.10版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 Node.js16.17: Nodejs语言16.17版本。 Node.js18.15: Nodejs语言18.15版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 C#(.NET Core 6.0): C#语言6.0版本（当前仅支持华北-乌兰察布二零二）。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 Cangjie1.0：仓颉语言1.0版本。 http: HTTP函数。 Custom Image: 自定义镜像函数。</value>
        [JsonConverter(typeof(EnumClassConverter<RuntimeEnum>))]
        public class RuntimeEnum
        {
            /// <summary>
            /// Enum JAVA8 for value: Java8
            /// </summary>
            public static readonly RuntimeEnum JAVA8 = new RuntimeEnum("Java8");

            /// <summary>
            /// Enum JAVA11 for value: Java11
            /// </summary>
            public static readonly RuntimeEnum JAVA11 = new RuntimeEnum("Java11");

            /// <summary>
            /// Enum JAVA17 for value: Java17
            /// </summary>
            public static readonly RuntimeEnum JAVA17 = new RuntimeEnum("Java17");

            /// <summary>
            /// Enum PYTHON2_7 for value: Python2.7
            /// </summary>
            public static readonly RuntimeEnum PYTHON2_7 = new RuntimeEnum("Python2.7");

            /// <summary>
            /// Enum PYTHON3_6 for value: Python3.6
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_6 = new RuntimeEnum("Python3.6");

            /// <summary>
            /// Enum PYTHON3_9 for value: Python3.9
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_9 = new RuntimeEnum("Python3.9");

            /// <summary>
            /// Enum PYTHON3_10 for value: Python3.10
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_10 = new RuntimeEnum("Python3.10");

            /// <summary>
            /// Enum GO1_8 for value: Go1.8
            /// </summary>
            public static readonly RuntimeEnum GO1_8 = new RuntimeEnum("Go1.8");

            /// <summary>
            /// Enum GO1_X for value: Go1.x
            /// </summary>
            public static readonly RuntimeEnum GO1_X = new RuntimeEnum("Go1.x");

            /// <summary>
            /// Enum NODE_JS6_10 for value: Node.js6.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS6_10 = new RuntimeEnum("Node.js6.10");

            /// <summary>
            /// Enum NODE_JS8_10 for value: Node.js8.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS8_10 = new RuntimeEnum("Node.js8.10");

            /// <summary>
            /// Enum NODE_JS10_16 for value: Node.js10.16
            /// </summary>
            public static readonly RuntimeEnum NODE_JS10_16 = new RuntimeEnum("Node.js10.16");

            /// <summary>
            /// Enum NODE_JS12_13 for value: Node.js12.13
            /// </summary>
            public static readonly RuntimeEnum NODE_JS12_13 = new RuntimeEnum("Node.js12.13");

            /// <summary>
            /// Enum NODE_JS14_18 for value: Node.js14.18
            /// </summary>
            public static readonly RuntimeEnum NODE_JS14_18 = new RuntimeEnum("Node.js14.18");

            /// <summary>
            /// Enum NODE_JS16_17 for value: Node.js16.17
            /// </summary>
            public static readonly RuntimeEnum NODE_JS16_17 = new RuntimeEnum("Node.js16.17");

            /// <summary>
            /// Enum NODE_JS18_15 for value: Node.js18.15
            /// </summary>
            public static readonly RuntimeEnum NODE_JS18_15 = new RuntimeEnum("Node.js18.15");

            /// <summary>
            /// Enum C_NET_CORE_2_0_ for value: C#(.NET Core 2.0)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_2_0_ = new RuntimeEnum("C#(.NET Core 2.0)");

            /// <summary>
            /// Enum C_NET_CORE_2_1_ for value: C#(.NET Core 2.1)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_2_1_ = new RuntimeEnum("C#(.NET Core 2.1)");

            /// <summary>
            /// Enum C_NET_CORE_3_1_ for value: C#(.NET Core 3.1)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_3_1_ = new RuntimeEnum("C#(.NET Core 3.1)");

            /// <summary>
            /// Enum C_NET_CORE_6_0_ for value: C#(.NET Core 6.0)
            /// </summary>
            public static readonly RuntimeEnum C_NET_CORE_6_0_ = new RuntimeEnum("C#(.NET Core 6.0)");

            /// <summary>
            /// Enum CUSTOM for value: Custom
            /// </summary>
            public static readonly RuntimeEnum CUSTOM = new RuntimeEnum("Custom");

            /// <summary>
            /// Enum PHP7_3 for value: PHP7.3
            /// </summary>
            public static readonly RuntimeEnum PHP7_3 = new RuntimeEnum("PHP7.3");

            /// <summary>
            /// Enum CANGJIE1_0 for value: Cangjie1.0
            /// </summary>
            public static readonly RuntimeEnum CANGJIE1_0 = new RuntimeEnum("Cangjie1.0");

            /// <summary>
            /// Enum HTTP for value: http
            /// </summary>
            public static readonly RuntimeEnum HTTP = new RuntimeEnum("http");

            /// <summary>
            /// Enum CUSTOM_IMAGE for value: Custom Image
            /// </summary>
            public static readonly RuntimeEnum CUSTOM_IMAGE = new RuntimeEnum("Custom Image");

            private static readonly Dictionary<string, RuntimeEnum> StaticFields =
            new Dictionary<string, RuntimeEnum>()
            {
                { "Java8", JAVA8 },
                { "Java11", JAVA11 },
                { "Java17", JAVA17 },
                { "Python2.7", PYTHON2_7 },
                { "Python3.6", PYTHON3_6 },
                { "Python3.9", PYTHON3_9 },
                { "Python3.10", PYTHON3_10 },
                { "Go1.8", GO1_8 },
                { "Go1.x", GO1_X },
                { "Node.js6.10", NODE_JS6_10 },
                { "Node.js8.10", NODE_JS8_10 },
                { "Node.js10.16", NODE_JS10_16 },
                { "Node.js12.13", NODE_JS12_13 },
                { "Node.js14.18", NODE_JS14_18 },
                { "Node.js16.17", NODE_JS16_17 },
                { "Node.js18.15", NODE_JS18_15 },
                { "C#(.NET Core 2.0)", C_NET_CORE_2_0_ },
                { "C#(.NET Core 2.1)", C_NET_CORE_2_1_ },
                { "C#(.NET Core 3.1)", C_NET_CORE_3_1_ },
                { "C#(.NET Core 6.0)", C_NET_CORE_6_0_ },
                { "Custom", CUSTOM },
                { "PHP7.3", PHP7_3 },
                { "Cangjie1.0", CANGJIE1_0 },
                { "http", HTTP },
                { "Custom Image", CUSTOM_IMAGE },
            };

            private string _value;

            public RuntimeEnum()
            {

            }

            public RuntimeEnum(string value)
            {
                _value = value;
            }

            public static RuntimeEnum FromValue(string value)
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

                if (this.Equals(obj as RuntimeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RuntimeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RuntimeEnum a, RuntimeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(RuntimeEnum a, RuntimeEnum b)
            {
                return !(a == b);
            }
        }

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
                if (ReferenceEquals(a, b))
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
        /// 函数的URN（Uniform Resource Name），唯一标识函数。
        /// </summary>
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// 函数名称。
        /// </summary>
        [JsonProperty("func_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncName { get; set; }

        /// <summary>
        /// 域名id。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// FunctionGraph函数的执行环境 Java8: Java语言8版本。 Java11: Java语言11版本。 Java17: Java语言17版本（当前仅支持华北-乌兰察布二零二） Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Python3.10: Python语言3.10版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 Node.js16.17: Nodejs语言16.17版本。 Node.js18.15: Nodejs语言18.15版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 C#(.NET Core 6.0): C#语言6.0版本（当前仅支持华北-乌兰察布二零二）。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 Cangjie1.0：仓颉语言1.0版本。 http: HTTP函数。 Custom Image: 自定义镜像函数。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
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
        /// 函数大小，单位：字节。
        /// </summary>
        [JsonProperty("code_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// 函数代码SHA512 hash值，用于判断函数是否变化。
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// 函数最后一次更新时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

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
        /// 依赖版本id列表
        /// </summary>
        [JsonProperty("depend_version_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependVersionList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy_config", NullValueHandling = NullValueHandling.Ignore)]
        public StrategyConfig StrategyConfig { get; set; }

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
            sb.Append("class ShowFunctionCodeResponse {\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  codeSize: ").Append(CodeSize).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  funcCode: ").Append(FuncCode).Append("\n");
            sb.Append("  dependList: ").Append(DependList).Append("\n");
            sb.Append("  dependVersionList: ").Append(DependVersionList).Append("\n");
            sb.Append("  strategyConfig: ").Append(StrategyConfig).Append("\n");
            sb.Append("  dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionCodeResponse input)
        {
            if (input == null) return false;
            if (this.FuncUrn != input.FuncUrn || (this.FuncUrn != null && !this.FuncUrn.Equals(input.FuncUrn))) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Runtime != input.Runtime) return false;
            if (this.CodeType != input.CodeType) return false;
            if (this.CodeUrl != input.CodeUrl || (this.CodeUrl != null && !this.CodeUrl.Equals(input.CodeUrl))) return false;
            if (this.CodeFilename != input.CodeFilename || (this.CodeFilename != null && !this.CodeFilename.Equals(input.CodeFilename))) return false;
            if (this.CodeSize != input.CodeSize || (this.CodeSize != null && !this.CodeSize.Equals(input.CodeSize))) return false;
            if (this.Digest != input.Digest || (this.Digest != null && !this.Digest.Equals(input.Digest))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.FuncCode != input.FuncCode || (this.FuncCode != null && !this.FuncCode.Equals(input.FuncCode))) return false;
            if (this.DependList != input.DependList || (this.DependList != null && input.DependList != null && !this.DependList.SequenceEqual(input.DependList))) return false;
            if (this.DependVersionList != input.DependVersionList || (this.DependVersionList != null && input.DependVersionList != null && !this.DependVersionList.SequenceEqual(input.DependVersionList))) return false;
            if (this.StrategyConfig != input.StrategyConfig || (this.StrategyConfig != null && !this.StrategyConfig.Equals(input.StrategyConfig))) return false;
            if (this.Dependencies != input.Dependencies || (this.Dependencies != null && input.Dependencies != null && !this.Dependencies.SequenceEqual(input.Dependencies))) return false;

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
                if (this.FuncUrn != null) hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null) hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null) hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.CodeSize != null) hashCode = hashCode * 59 + this.CodeSize.GetHashCode();
                if (this.Digest != null) hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.FuncCode != null) hashCode = hashCode * 59 + this.FuncCode.GetHashCode();
                if (this.DependList != null) hashCode = hashCode * 59 + this.DependList.GetHashCode();
                if (this.DependVersionList != null) hashCode = hashCode * 59 + this.DependVersionList.GetHashCode();
                if (this.StrategyConfig != null) hashCode = hashCode * 59 + this.StrategyConfig.GetHashCode();
                if (this.Dependencies != null) hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
