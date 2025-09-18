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
    public class CreateFunctionResponse : SdkResponse
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
        /// v2表示为正式版本,v1为废弃版本。
        /// </summary>
        /// <value>v2表示为正式版本,v1为废弃版本。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            public static readonly TypeEnum V1 = new TypeEnum("v1");

            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            public static readonly TypeEnum V2 = new TypeEnum("v2");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "v1", V1 },
                { "v2", V2 },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数id，唯一标识函数。
        /// </summary>
        [JsonProperty("func_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncId { get; set; }

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
        /// 租户的project id。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 租户的project name。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 函数所属的分组Package，用于用户针对函数的自定义分组。
        /// </summary>
        [JsonProperty("package", NullValueHandling = NullValueHandling.Ignore)]
        public string Package { get; set; }

        /// <summary>
        /// FunctionGraph函数的执行环境 Java8: Java语言8版本。 Java11: Java语言11版本。 Java17: Java语言17版本（当前仅支持华北-乌兰察布二零二） Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Python3.10: Python语言3.10版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 Node.js16.17: Nodejs语言16.17版本。 Node.js18.15: Nodejs语言18.15版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 C#(.NET Core 6.0): C#语言6.0版本（当前仅支持华北-乌兰察布二零二）。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 Cangjie1.0：仓颉语言1.0版本。 http: HTTP函数。 Custom Image: 自定义镜像函数。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
        /// <summary>
        /// 函数执行超时时间，超时函数将被强行停止，范围3～259200秒。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 函数执行入口 规则：xx.xx，必须包含“. ” 举例：对于node.js函数：myfunction.handler，则表示函数的文件名为myfunction.js，执行的入口函数名为handler。
        /// </summary>
        [JsonProperty("handler", NullValueHandling = NullValueHandling.Ignore)]
        public string Handler { get; set; }

        /// <summary>
        /// 函数消耗的内存。 单位M。 取值范围为：128、256、512、768、1024、1280、1536、1792、2048、2560、3072、3584、4096。 最小值为128，最大值为4096。
        /// </summary>
        [JsonProperty("memory_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// 函数消耗的显存，只支持自定义运行时与自定义镜像函数配置GPU。 单位MB。 取值范围为：1024、2048、3072、4096、5120、6144、7168、8192、9216、10240、11264、12288、13312、14336、15360、16384。 最小值为1024，最大值为16384。
        /// </summary>
        [JsonProperty("gpu_memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// 函数占用的cpu资源。 单位为millicore（1 core&#x3D;1000 millicores）。 取值与MemorySize成比例，默认是128M内存占0.1个核（100 millicores）。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cpu { get; set; }

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
        /// 函数配置的需要支持域名解析的内网域名。
        /// </summary>
        [JsonProperty("domain_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainNames { get; set; }

        /// <summary>
        /// 用户自定义的name/value信息。 在函数中使用的参数。 举例：如函数要访问某个主机，可以设置自定义参数：Host&#x3D;{host_ip}，最多定义20个，总长度不超过4KB。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 用户自定义的name/value信息，用于需要加密的配置。
        /// </summary>
        [JsonProperty("encrypted_user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedUserData { get; set; }

        /// <summary>
        /// 函数代码SHA512 hash值，用于判断函数是否变化。
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// 函数版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 函数版本的内部标识。
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 函数使用的权限委托名称，需要IAM支持，并在IAM界面创建委托，当函数需要访问其他服务时，必须提供该字段。
        /// </summary>
        [JsonProperty("xrole", NullValueHandling = NullValueHandling.Ignore)]
        public string Xrole { get; set; }

        /// <summary>
        /// 函数app使用的权限委托名称，需要IAM支持，并在IAM界面创建委托，当函数需要访问其他服务时，必须提供该字段。
        /// </summary>
        [JsonProperty("app_xrole", NullValueHandling = NullValueHandling.Ignore)]
        public string AppXrole { get; set; }

        /// <summary>
        /// 函数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 函数最后一次更新时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("func_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public FuncVpc FuncVpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mount_config", NullValueHandling = NullValueHandling.Ignore)]
        public MountConfig MountConfig { get; set; }

        /// <summary>
        /// 函数预留实例数量。
        /// </summary>
        [JsonProperty("reserved_instance_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReservedInstanceCount { get; set; }

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
        /// 函数扩展配置。
        /// </summary>
        [JsonProperty("extend_config", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// 函数依赖代码包列表。
        /// </summary>
        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dependency> Dependencies { get; set; }

        /// <summary>
        /// 函数初始化入口，规则：xx.xx，必须包含“. ”。当配置初始化函数时，此参数必填。 举例：对于node.js函数：myfunction.initializer，则表示函数的文件名为myfunction.js，初始化的入口函数名为initializer。
        /// </summary>
        [JsonProperty("initializer_handler", NullValueHandling = NullValueHandling.Ignore)]
        public string InitializerHandler { get; set; }

        /// <summary>
        /// 初始化超时时间，超时函数将被强行停止，范围1～300秒。当配置初始化函数时，此参数必填。
        /// </summary>
        [JsonProperty("initializer_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitializerTimeout { get; set; }

        /// <summary>
        /// 函数预停止函数的入口，规则：xx.xx，必须包含“. ”。 举例：对于node.js函数：myfunction.pre_stop_handler，则表示函数的文件名为myfunction.js，初始化的入口函数名为pre_stop_handler。
        /// </summary>
        [JsonProperty("pre_stop_handler", NullValueHandling = NullValueHandling.Ignore)]
        public string PreStopHandler { get; set; }

        /// <summary>
        /// 初始化超时时间，超时函数将被强行停止，范围1～90秒。
        /// </summary>
        [JsonProperty("pre_stop_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreStopTimeout { get; set; }

        /// <summary>
        /// 企业项目ID，在企业用户创建函数时必填。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否允许进行长时间超时设置。
        /// </summary>
        [JsonProperty("long_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LongTime { get; set; }

        /// <summary>
        /// 自定义日志查询组id
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 自定义日志查询流id
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// v2表示为正式版本,v1为废弃版本。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 适配CloudDebug场景，是否开启云调试（已废弃）
        /// </summary>
        [JsonProperty("enable_cloud_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableCloudDebug { get; set; }

        /// <summary>
        /// 是否启动动态内存配置
        /// </summary>
        [JsonProperty("enable_dynamic_memory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDynamicMemory { get; set; }

        /// <summary>
        /// 是否支持有状态，如果需要支持，需要固定传参为true，v2版本支持
        /// </summary>
        [JsonProperty("is_stateful_function", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsStatefulFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_image", NullValueHandling = NullValueHandling.Ignore)]
        public CustomImage CustomImage { get; set; }

        /// <summary>
        /// 是否为bridge函数
        /// </summary>
        [JsonProperty("is_bridge_function", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBridgeFunction { get; set; }

        /// <summary>
        /// 是否配置下沉apig路由规则。
        /// </summary>
        [JsonProperty("apig_route_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApigRouteEnable { get; set; }

        /// <summary>
        /// 心跳函数函数的入口，规则：xx.xx，必须包含“. ”，只支持JAVA运行时配置。 心跳函数入口需要与函数执行入口在同一文件下。在开启心跳函数配置时，此参数必填。
        /// </summary>
        [JsonProperty("heartbeat_handler", NullValueHandling = NullValueHandling.Ignore)]
        public string HeartbeatHandler { get; set; }

        /// <summary>
        /// 类隔离开关，只支持JAVA运行时配置。开启类隔离后可以支持Kafka转储并提升类加载效率，但也可能会导致某些兼容性问题，请谨慎开启。
        /// </summary>
        [JsonProperty("enable_class_isolation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableClassIsolation { get; set; }

        /// <summary>
        /// 显卡类型。
        /// </summary>
        [JsonProperty("gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuType { get; set; }

        /// <summary>
        /// 是否支持配置临时存储。
        /// </summary>
        [JsonProperty("allow_ephemeral_storage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowEphemeralStorage { get; set; }

        /// <summary>
        /// 临时存储大小。默认情况下会为函数的/tmp目录分配512MB的空间。您可以通过临时存储设置将函数的/tmp目录大小调整为10G。
        /// </summary>
        [JsonProperty("ephemeral_storage", NullValueHandling = NullValueHandling.Ignore)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_controller", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkControlConfig NetworkController { get; set; }

        /// <summary>
        /// 资源id。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 是否返回流式数据（已废弃）
        /// </summary>
        [JsonProperty("is_return_stream", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReturnStream { get; set; }

        /// <summary>
        /// 是否允许在请求头中添加鉴权信息，只支持自定义镜像函数（创建函数时不支持修改）
        /// </summary>
        [JsonProperty("enable_auth_in_header", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAuthInHeader { get; set; }

        /// <summary>
        /// 是否开启日志。
        /// </summary>
        [JsonProperty("enable_lts_log", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLtsLog { get; set; }

        /// <summary>
        /// 自定义日志标签。函数执行时，可以按照自定义标签配置上报标签到云日志服务(LTS)，用户可以通过标签对日志进行过滤筛选。
        /// </summary>
        [JsonProperty("lts_custom_tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LtsCustomTag { get; set; }

        /// <summary>
        /// 用于环境变量加密的kms主秘钥ID。
        /// </summary>
        [JsonProperty("user_data_encrypt_kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDataEncryptKmsKeyId { get; set; }

        /// <summary>
        /// 用于用户代码加密的kms主秘钥ID。
        /// </summary>
        [JsonProperty("code_encrypt_kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeEncryptKmsKeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFunctionResponse {\n");
            sb.Append("  funcId: ").Append(FuncId).Append("\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  package: ").Append(Package).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  handler: ").Append(Handler).Append("\n");
            sb.Append("  memorySize: ").Append(MemorySize).Append("\n");
            sb.Append("  gpuMemory: ").Append(GpuMemory).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  codeSize: ").Append(CodeSize).Append("\n");
            sb.Append("  domainNames: ").Append(DomainNames).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  encryptedUserData: ").Append(EncryptedUserData).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  xrole: ").Append(Xrole).Append("\n");
            sb.Append("  appXrole: ").Append(AppXrole).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  funcVpc: ").Append(FuncVpc).Append("\n");
            sb.Append("  mountConfig: ").Append(MountConfig).Append("\n");
            sb.Append("  reservedInstanceCount: ").Append(ReservedInstanceCount).Append("\n");
            sb.Append("  dependList: ").Append(DependList).Append("\n");
            sb.Append("  dependVersionList: ").Append(DependVersionList).Append("\n");
            sb.Append("  strategyConfig: ").Append(StrategyConfig).Append("\n");
            sb.Append("  extendConfig: ").Append(ExtendConfig).Append("\n");
            sb.Append("  dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  initializerHandler: ").Append(InitializerHandler).Append("\n");
            sb.Append("  initializerTimeout: ").Append(InitializerTimeout).Append("\n");
            sb.Append("  preStopHandler: ").Append(PreStopHandler).Append("\n");
            sb.Append("  preStopTimeout: ").Append(PreStopTimeout).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  longTime: ").Append(LongTime).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enableCloudDebug: ").Append(EnableCloudDebug).Append("\n");
            sb.Append("  enableDynamicMemory: ").Append(EnableDynamicMemory).Append("\n");
            sb.Append("  isStatefulFunction: ").Append(IsStatefulFunction).Append("\n");
            sb.Append("  customImage: ").Append(CustomImage).Append("\n");
            sb.Append("  isBridgeFunction: ").Append(IsBridgeFunction).Append("\n");
            sb.Append("  apigRouteEnable: ").Append(ApigRouteEnable).Append("\n");
            sb.Append("  heartbeatHandler: ").Append(HeartbeatHandler).Append("\n");
            sb.Append("  enableClassIsolation: ").Append(EnableClassIsolation).Append("\n");
            sb.Append("  gpuType: ").Append(GpuType).Append("\n");
            sb.Append("  allowEphemeralStorage: ").Append(AllowEphemeralStorage).Append("\n");
            sb.Append("  ephemeralStorage: ").Append(EphemeralStorage).Append("\n");
            sb.Append("  networkController: ").Append(NetworkController).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  isReturnStream: ").Append(IsReturnStream).Append("\n");
            sb.Append("  enableAuthInHeader: ").Append(EnableAuthInHeader).Append("\n");
            sb.Append("  enableLtsLog: ").Append(EnableLtsLog).Append("\n");
            sb.Append("  ltsCustomTag: ").Append(LtsCustomTag).Append("\n");
            sb.Append("  userDataEncryptKmsKeyId: ").Append(UserDataEncryptKmsKeyId).Append("\n");
            sb.Append("  codeEncryptKmsKeyId: ").Append(CodeEncryptKmsKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFunctionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFunctionResponse input)
        {
            if (input == null) return false;
            if (this.FuncId != input.FuncId || (this.FuncId != null && !this.FuncId.Equals(input.FuncId))) return false;
            if (this.FuncUrn != input.FuncUrn || (this.FuncUrn != null && !this.FuncUrn.Equals(input.FuncUrn))) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Package != input.Package || (this.Package != null && !this.Package.Equals(input.Package))) return false;
            if (this.Runtime != input.Runtime) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Handler != input.Handler || (this.Handler != null && !this.Handler.Equals(input.Handler))) return false;
            if (this.MemorySize != input.MemorySize || (this.MemorySize != null && !this.MemorySize.Equals(input.MemorySize))) return false;
            if (this.GpuMemory != input.GpuMemory || (this.GpuMemory != null && !this.GpuMemory.Equals(input.GpuMemory))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.CodeType != input.CodeType) return false;
            if (this.CodeUrl != input.CodeUrl || (this.CodeUrl != null && !this.CodeUrl.Equals(input.CodeUrl))) return false;
            if (this.CodeFilename != input.CodeFilename || (this.CodeFilename != null && !this.CodeFilename.Equals(input.CodeFilename))) return false;
            if (this.CodeSize != input.CodeSize || (this.CodeSize != null && !this.CodeSize.Equals(input.CodeSize))) return false;
            if (this.DomainNames != input.DomainNames || (this.DomainNames != null && !this.DomainNames.Equals(input.DomainNames))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.EncryptedUserData != input.EncryptedUserData || (this.EncryptedUserData != null && !this.EncryptedUserData.Equals(input.EncryptedUserData))) return false;
            if (this.Digest != input.Digest || (this.Digest != null && !this.Digest.Equals(input.Digest))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.Xrole != input.Xrole || (this.Xrole != null && !this.Xrole.Equals(input.Xrole))) return false;
            if (this.AppXrole != input.AppXrole || (this.AppXrole != null && !this.AppXrole.Equals(input.AppXrole))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.FuncVpc != input.FuncVpc || (this.FuncVpc != null && !this.FuncVpc.Equals(input.FuncVpc))) return false;
            if (this.MountConfig != input.MountConfig || (this.MountConfig != null && !this.MountConfig.Equals(input.MountConfig))) return false;
            if (this.ReservedInstanceCount != input.ReservedInstanceCount || (this.ReservedInstanceCount != null && !this.ReservedInstanceCount.Equals(input.ReservedInstanceCount))) return false;
            if (this.DependList != input.DependList || (this.DependList != null && input.DependList != null && !this.DependList.SequenceEqual(input.DependList))) return false;
            if (this.DependVersionList != input.DependVersionList || (this.DependVersionList != null && input.DependVersionList != null && !this.DependVersionList.SequenceEqual(input.DependVersionList))) return false;
            if (this.StrategyConfig != input.StrategyConfig || (this.StrategyConfig != null && !this.StrategyConfig.Equals(input.StrategyConfig))) return false;
            if (this.ExtendConfig != input.ExtendConfig || (this.ExtendConfig != null && !this.ExtendConfig.Equals(input.ExtendConfig))) return false;
            if (this.Dependencies != input.Dependencies || (this.Dependencies != null && input.Dependencies != null && !this.Dependencies.SequenceEqual(input.Dependencies))) return false;
            if (this.InitializerHandler != input.InitializerHandler || (this.InitializerHandler != null && !this.InitializerHandler.Equals(input.InitializerHandler))) return false;
            if (this.InitializerTimeout != input.InitializerTimeout || (this.InitializerTimeout != null && !this.InitializerTimeout.Equals(input.InitializerTimeout))) return false;
            if (this.PreStopHandler != input.PreStopHandler || (this.PreStopHandler != null && !this.PreStopHandler.Equals(input.PreStopHandler))) return false;
            if (this.PreStopTimeout != input.PreStopTimeout || (this.PreStopTimeout != null && !this.PreStopTimeout.Equals(input.PreStopTimeout))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.LongTime != input.LongTime || (this.LongTime != null && !this.LongTime.Equals(input.LongTime))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.Type != input.Type) return false;
            if (this.EnableCloudDebug != input.EnableCloudDebug || (this.EnableCloudDebug != null && !this.EnableCloudDebug.Equals(input.EnableCloudDebug))) return false;
            if (this.EnableDynamicMemory != input.EnableDynamicMemory || (this.EnableDynamicMemory != null && !this.EnableDynamicMemory.Equals(input.EnableDynamicMemory))) return false;
            if (this.IsStatefulFunction != input.IsStatefulFunction || (this.IsStatefulFunction != null && !this.IsStatefulFunction.Equals(input.IsStatefulFunction))) return false;
            if (this.CustomImage != input.CustomImage || (this.CustomImage != null && !this.CustomImage.Equals(input.CustomImage))) return false;
            if (this.IsBridgeFunction != input.IsBridgeFunction || (this.IsBridgeFunction != null && !this.IsBridgeFunction.Equals(input.IsBridgeFunction))) return false;
            if (this.ApigRouteEnable != input.ApigRouteEnable || (this.ApigRouteEnable != null && !this.ApigRouteEnable.Equals(input.ApigRouteEnable))) return false;
            if (this.HeartbeatHandler != input.HeartbeatHandler || (this.HeartbeatHandler != null && !this.HeartbeatHandler.Equals(input.HeartbeatHandler))) return false;
            if (this.EnableClassIsolation != input.EnableClassIsolation || (this.EnableClassIsolation != null && !this.EnableClassIsolation.Equals(input.EnableClassIsolation))) return false;
            if (this.GpuType != input.GpuType || (this.GpuType != null && !this.GpuType.Equals(input.GpuType))) return false;
            if (this.AllowEphemeralStorage != input.AllowEphemeralStorage || (this.AllowEphemeralStorage != null && !this.AllowEphemeralStorage.Equals(input.AllowEphemeralStorage))) return false;
            if (this.EphemeralStorage != input.EphemeralStorage || (this.EphemeralStorage != null && !this.EphemeralStorage.Equals(input.EphemeralStorage))) return false;
            if (this.NetworkController != input.NetworkController || (this.NetworkController != null && !this.NetworkController.Equals(input.NetworkController))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.IsReturnStream != input.IsReturnStream || (this.IsReturnStream != null && !this.IsReturnStream.Equals(input.IsReturnStream))) return false;
            if (this.EnableAuthInHeader != input.EnableAuthInHeader || (this.EnableAuthInHeader != null && !this.EnableAuthInHeader.Equals(input.EnableAuthInHeader))) return false;
            if (this.EnableLtsLog != input.EnableLtsLog || (this.EnableLtsLog != null && !this.EnableLtsLog.Equals(input.EnableLtsLog))) return false;
            if (this.LtsCustomTag != input.LtsCustomTag || (this.LtsCustomTag != null && input.LtsCustomTag != null && !this.LtsCustomTag.SequenceEqual(input.LtsCustomTag))) return false;
            if (this.UserDataEncryptKmsKeyId != input.UserDataEncryptKmsKeyId || (this.UserDataEncryptKmsKeyId != null && !this.UserDataEncryptKmsKeyId.Equals(input.UserDataEncryptKmsKeyId))) return false;
            if (this.CodeEncryptKmsKeyId != input.CodeEncryptKmsKeyId || (this.CodeEncryptKmsKeyId != null && !this.CodeEncryptKmsKeyId.Equals(input.CodeEncryptKmsKeyId))) return false;

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
                if (this.FuncId != null) hashCode = hashCode * 59 + this.FuncId.GetHashCode();
                if (this.FuncUrn != null) hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Package != null) hashCode = hashCode * 59 + this.Package.GetHashCode();
                hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Handler != null) hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.MemorySize != null) hashCode = hashCode * 59 + this.MemorySize.GetHashCode();
                if (this.GpuMemory != null) hashCode = hashCode * 59 + this.GpuMemory.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null) hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null) hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.CodeSize != null) hashCode = hashCode * 59 + this.CodeSize.GetHashCode();
                if (this.DomainNames != null) hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.EncryptedUserData != null) hashCode = hashCode * 59 + this.EncryptedUserData.GetHashCode();
                if (this.Digest != null) hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.Xrole != null) hashCode = hashCode * 59 + this.Xrole.GetHashCode();
                if (this.AppXrole != null) hashCode = hashCode * 59 + this.AppXrole.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.FuncVpc != null) hashCode = hashCode * 59 + this.FuncVpc.GetHashCode();
                if (this.MountConfig != null) hashCode = hashCode * 59 + this.MountConfig.GetHashCode();
                if (this.ReservedInstanceCount != null) hashCode = hashCode * 59 + this.ReservedInstanceCount.GetHashCode();
                if (this.DependList != null) hashCode = hashCode * 59 + this.DependList.GetHashCode();
                if (this.DependVersionList != null) hashCode = hashCode * 59 + this.DependVersionList.GetHashCode();
                if (this.StrategyConfig != null) hashCode = hashCode * 59 + this.StrategyConfig.GetHashCode();
                if (this.ExtendConfig != null) hashCode = hashCode * 59 + this.ExtendConfig.GetHashCode();
                if (this.Dependencies != null) hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.InitializerHandler != null) hashCode = hashCode * 59 + this.InitializerHandler.GetHashCode();
                if (this.InitializerTimeout != null) hashCode = hashCode * 59 + this.InitializerTimeout.GetHashCode();
                if (this.PreStopHandler != null) hashCode = hashCode * 59 + this.PreStopHandler.GetHashCode();
                if (this.PreStopTimeout != null) hashCode = hashCode * 59 + this.PreStopTimeout.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.LongTime != null) hashCode = hashCode * 59 + this.LongTime.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnableCloudDebug != null) hashCode = hashCode * 59 + this.EnableCloudDebug.GetHashCode();
                if (this.EnableDynamicMemory != null) hashCode = hashCode * 59 + this.EnableDynamicMemory.GetHashCode();
                if (this.IsStatefulFunction != null) hashCode = hashCode * 59 + this.IsStatefulFunction.GetHashCode();
                if (this.CustomImage != null) hashCode = hashCode * 59 + this.CustomImage.GetHashCode();
                if (this.IsBridgeFunction != null) hashCode = hashCode * 59 + this.IsBridgeFunction.GetHashCode();
                if (this.ApigRouteEnable != null) hashCode = hashCode * 59 + this.ApigRouteEnable.GetHashCode();
                if (this.HeartbeatHandler != null) hashCode = hashCode * 59 + this.HeartbeatHandler.GetHashCode();
                if (this.EnableClassIsolation != null) hashCode = hashCode * 59 + this.EnableClassIsolation.GetHashCode();
                if (this.GpuType != null) hashCode = hashCode * 59 + this.GpuType.GetHashCode();
                if (this.AllowEphemeralStorage != null) hashCode = hashCode * 59 + this.AllowEphemeralStorage.GetHashCode();
                if (this.EphemeralStorage != null) hashCode = hashCode * 59 + this.EphemeralStorage.GetHashCode();
                if (this.NetworkController != null) hashCode = hashCode * 59 + this.NetworkController.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.IsReturnStream != null) hashCode = hashCode * 59 + this.IsReturnStream.GetHashCode();
                if (this.EnableAuthInHeader != null) hashCode = hashCode * 59 + this.EnableAuthInHeader.GetHashCode();
                if (this.EnableLtsLog != null) hashCode = hashCode * 59 + this.EnableLtsLog.GetHashCode();
                if (this.LtsCustomTag != null) hashCode = hashCode * 59 + this.LtsCustomTag.GetHashCode();
                if (this.UserDataEncryptKmsKeyId != null) hashCode = hashCode * 59 + this.UserDataEncryptKmsKeyId.GetHashCode();
                if (this.CodeEncryptKmsKeyId != null) hashCode = hashCode * 59 + this.CodeEncryptKmsKeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
