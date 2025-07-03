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
    /// 函数属性结构体。
    /// </summary>
    public class CreateFunctionRequestBody 
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

            public static bool operator !=(RuntimeEnum a, RuntimeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。 创建自定义镜像函数此参数非必填，其他类型函数此参数必填。
        /// </summary>
        /// <value>函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。 创建自定义镜像函数此参数非必填，其他类型函数此参数必填。</value>
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
        /// 函数版本；部分局点只支持v1函数，缺省值则为v1
        /// </summary>
        /// <value>函数版本；部分局点只支持v1函数，缺省值则为v1</value>
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
        /// 函数名称。
        /// </summary>
        [JsonProperty("func_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncName { get; set; }

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
        /// 函数执行入口 规则：xx.xx，必须包含“. ”；自定义镜像函数handler为“-” 举例：对于node.js函数：myfunction.handler，则表示函数的文件名为myfunction.js，执行的入口函数名为handler。
        /// </summary>
        [JsonProperty("handler", NullValueHandling = NullValueHandling.Ignore)]
        public string Handler { get; set; }

        /// <summary>
        /// 依赖版本id列表
        /// </summary>
        [JsonProperty("depend_version_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependVersionList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("func_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public FuncVpc FuncVpc { get; set; }

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
        /// 显卡类型。
        /// </summary>
        [JsonProperty("gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuType { get; set; }

        /// <summary>
        /// 函数代码类型，取值有5种。 inline: UI在线编辑代码。 zip: 函数代码为zip包。 obs: 函数代码来源于obs存储。 jar: 函数代码为jar包，主要针对Java函数。 Custom-Image-Swr: 函数代码来源与SWR自定义镜像。 创建自定义镜像函数此参数非必填，其他类型函数此参数必填。
        /// </summary>
        [JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public CodeTypeEnum CodeType { get; set; }
        /// <summary>
        /// 当CodeType为obs时，该值为函数代码包在OBS上的地址，CodeType为其他值时，该字段为空。
        /// </summary>
        [JsonProperty("code_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 函数的文件名，当CodeType为jar/zip时必须提供该字段，CodeType为其他值时不需要提供。
        /// </summary>
        [JsonProperty("code_filename", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_image", NullValueHandling = NullValueHandling.Ignore)]
        public CustomImage CustomImage { get; set; }

        /// <summary>
        /// 用户自定义的name/value信息。 在函数中使用的参数。 举例：如函数要访问某个主机，可以设置自定义参数：Host&#x3D;{host_ip}，最多定义20个，总长度不超过4KB。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 用户自定义的name/value信息，用于需要加密的配置。举例：如配置加密密码，可以设置自定义参数：password&#x3D;{1234}，最多定义20个，总长度不超过4KB。
        /// </summary>
        [JsonProperty("encrypted_user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedUserData { get; set; }

        /// <summary>
        /// 函数配置委托。需要IAM支持，并在IAM界面创建委托，当函数需要访问其他服务时，必须提供该字段。配置后用户可以通过函数执行入口方法中的context参数获取具有委托中权限的token、ak、sk，用于访问其他云服务。如果用户函数不访问任何云服务，则不用提供委托名称。
        /// </summary>
        [JsonProperty("xrole", NullValueHandling = NullValueHandling.Ignore)]
        public string Xrole { get; set; }

        /// <summary>
        /// 函数执行委托。可为函数执行单独配置执行委托，这将减小不必要的性能损耗；不单独配置执行委托时，函数执行和函数配置将使用同一委托。
        /// </summary>
        [JsonProperty("app_xrole", NullValueHandling = NullValueHandling.Ignore)]
        public string AppXrole { get; set; }

        /// <summary>
        /// 函数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("func_code", NullValueHandling = NullValueHandling.Ignore)]
        public FuncCode FuncCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mount_config", NullValueHandling = NullValueHandling.Ignore)]
        public MountConfig MountConfig { get; set; }

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
        /// 函数版本；部分局点只支持v1函数，缺省值则为v1
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_config", NullValueHandling = NullValueHandling.Ignore)]
        public FuncLogConfig LogConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_controller", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkControlConfig NetworkController { get; set; }

        /// <summary>
        /// 是否支持有状态，如果需要支持，需要固定传参为true，v2版本支持
        /// </summary>
        [JsonProperty("is_stateful_function", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsStatefulFunction { get; set; }

        /// <summary>
        /// 是否启动动态内存配置
        /// </summary>
        [JsonProperty("enable_dynamic_memory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDynamicMemory { get; set; }

        /// <summary>
        /// 是否开启日志，缺省值为false。创建函数时，若此开关为true，且未传入log_config，则由FunctionGraph自动创建日志组日志流。
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
        /// vpc中配置的内网域名。在函数配置调用DNS服务的接口解析内网域名时，则函数必须具备读取DNS资源权限的委托。
        /// </summary>
        [JsonProperty("domain_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainNames { get; set; }

        /// <summary>
        /// 函数标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFunctionRequestBody {\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("  package: ").Append(Package).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  handler: ").Append(Handler).Append("\n");
            sb.Append("  dependVersionList: ").Append(DependVersionList).Append("\n");
            sb.Append("  funcVpc: ").Append(FuncVpc).Append("\n");
            sb.Append("  memorySize: ").Append(MemorySize).Append("\n");
            sb.Append("  gpuMemory: ").Append(GpuMemory).Append("\n");
            sb.Append("  gpuType: ").Append(GpuType).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  customImage: ").Append(CustomImage).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  encryptedUserData: ").Append(EncryptedUserData).Append("\n");
            sb.Append("  xrole: ").Append(Xrole).Append("\n");
            sb.Append("  appXrole: ").Append(AppXrole).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  funcCode: ").Append(FuncCode).Append("\n");
            sb.Append("  mountConfig: ").Append(MountConfig).Append("\n");
            sb.Append("  initializerHandler: ").Append(InitializerHandler).Append("\n");
            sb.Append("  initializerTimeout: ").Append(InitializerTimeout).Append("\n");
            sb.Append("  preStopHandler: ").Append(PreStopHandler).Append("\n");
            sb.Append("  preStopTimeout: ").Append(PreStopTimeout).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  logConfig: ").Append(LogConfig).Append("\n");
            sb.Append("  networkController: ").Append(NetworkController).Append("\n");
            sb.Append("  isStatefulFunction: ").Append(IsStatefulFunction).Append("\n");
            sb.Append("  enableDynamicMemory: ").Append(EnableDynamicMemory).Append("\n");
            sb.Append("  enableLtsLog: ").Append(EnableLtsLog).Append("\n");
            sb.Append("  ltsCustomTag: ").Append(LtsCustomTag).Append("\n");
            sb.Append("  userDataEncryptKmsKeyId: ").Append(UserDataEncryptKmsKeyId).Append("\n");
            sb.Append("  codeEncryptKmsKeyId: ").Append(CodeEncryptKmsKeyId).Append("\n");
            sb.Append("  domainNames: ").Append(DomainNames).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFunctionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFunctionRequestBody input)
        {
            if (input == null) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;
            if (this.Package != input.Package || (this.Package != null && !this.Package.Equals(input.Package))) return false;
            if (this.Runtime != input.Runtime) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Handler != input.Handler || (this.Handler != null && !this.Handler.Equals(input.Handler))) return false;
            if (this.DependVersionList != input.DependVersionList || (this.DependVersionList != null && input.DependVersionList != null && !this.DependVersionList.SequenceEqual(input.DependVersionList))) return false;
            if (this.FuncVpc != input.FuncVpc || (this.FuncVpc != null && !this.FuncVpc.Equals(input.FuncVpc))) return false;
            if (this.MemorySize != input.MemorySize || (this.MemorySize != null && !this.MemorySize.Equals(input.MemorySize))) return false;
            if (this.GpuMemory != input.GpuMemory || (this.GpuMemory != null && !this.GpuMemory.Equals(input.GpuMemory))) return false;
            if (this.GpuType != input.GpuType || (this.GpuType != null && !this.GpuType.Equals(input.GpuType))) return false;
            if (this.CodeType != input.CodeType) return false;
            if (this.CodeUrl != input.CodeUrl || (this.CodeUrl != null && !this.CodeUrl.Equals(input.CodeUrl))) return false;
            if (this.CodeFilename != input.CodeFilename || (this.CodeFilename != null && !this.CodeFilename.Equals(input.CodeFilename))) return false;
            if (this.CustomImage != input.CustomImage || (this.CustomImage != null && !this.CustomImage.Equals(input.CustomImage))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.EncryptedUserData != input.EncryptedUserData || (this.EncryptedUserData != null && !this.EncryptedUserData.Equals(input.EncryptedUserData))) return false;
            if (this.Xrole != input.Xrole || (this.Xrole != null && !this.Xrole.Equals(input.Xrole))) return false;
            if (this.AppXrole != input.AppXrole || (this.AppXrole != null && !this.AppXrole.Equals(input.AppXrole))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FuncCode != input.FuncCode || (this.FuncCode != null && !this.FuncCode.Equals(input.FuncCode))) return false;
            if (this.MountConfig != input.MountConfig || (this.MountConfig != null && !this.MountConfig.Equals(input.MountConfig))) return false;
            if (this.InitializerHandler != input.InitializerHandler || (this.InitializerHandler != null && !this.InitializerHandler.Equals(input.InitializerHandler))) return false;
            if (this.InitializerTimeout != input.InitializerTimeout || (this.InitializerTimeout != null && !this.InitializerTimeout.Equals(input.InitializerTimeout))) return false;
            if (this.PreStopHandler != input.PreStopHandler || (this.PreStopHandler != null && !this.PreStopHandler.Equals(input.PreStopHandler))) return false;
            if (this.PreStopTimeout != input.PreStopTimeout || (this.PreStopTimeout != null && !this.PreStopTimeout.Equals(input.PreStopTimeout))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.LogConfig != input.LogConfig || (this.LogConfig != null && !this.LogConfig.Equals(input.LogConfig))) return false;
            if (this.NetworkController != input.NetworkController || (this.NetworkController != null && !this.NetworkController.Equals(input.NetworkController))) return false;
            if (this.IsStatefulFunction != input.IsStatefulFunction || (this.IsStatefulFunction != null && !this.IsStatefulFunction.Equals(input.IsStatefulFunction))) return false;
            if (this.EnableDynamicMemory != input.EnableDynamicMemory || (this.EnableDynamicMemory != null && !this.EnableDynamicMemory.Equals(input.EnableDynamicMemory))) return false;
            if (this.EnableLtsLog != input.EnableLtsLog || (this.EnableLtsLog != null && !this.EnableLtsLog.Equals(input.EnableLtsLog))) return false;
            if (this.LtsCustomTag != input.LtsCustomTag || (this.LtsCustomTag != null && input.LtsCustomTag != null && !this.LtsCustomTag.SequenceEqual(input.LtsCustomTag))) return false;
            if (this.UserDataEncryptKmsKeyId != input.UserDataEncryptKmsKeyId || (this.UserDataEncryptKmsKeyId != null && !this.UserDataEncryptKmsKeyId.Equals(input.UserDataEncryptKmsKeyId))) return false;
            if (this.CodeEncryptKmsKeyId != input.CodeEncryptKmsKeyId || (this.CodeEncryptKmsKeyId != null && !this.CodeEncryptKmsKeyId.Equals(input.CodeEncryptKmsKeyId))) return false;
            if (this.DomainNames != input.DomainNames || (this.DomainNames != null && !this.DomainNames.Equals(input.DomainNames))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;

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
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.Package != null) hashCode = hashCode * 59 + this.Package.GetHashCode();
                hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Handler != null) hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.DependVersionList != null) hashCode = hashCode * 59 + this.DependVersionList.GetHashCode();
                if (this.FuncVpc != null) hashCode = hashCode * 59 + this.FuncVpc.GetHashCode();
                if (this.MemorySize != null) hashCode = hashCode * 59 + this.MemorySize.GetHashCode();
                if (this.GpuMemory != null) hashCode = hashCode * 59 + this.GpuMemory.GetHashCode();
                if (this.GpuType != null) hashCode = hashCode * 59 + this.GpuType.GetHashCode();
                hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null) hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null) hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.CustomImage != null) hashCode = hashCode * 59 + this.CustomImage.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.EncryptedUserData != null) hashCode = hashCode * 59 + this.EncryptedUserData.GetHashCode();
                if (this.Xrole != null) hashCode = hashCode * 59 + this.Xrole.GetHashCode();
                if (this.AppXrole != null) hashCode = hashCode * 59 + this.AppXrole.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FuncCode != null) hashCode = hashCode * 59 + this.FuncCode.GetHashCode();
                if (this.MountConfig != null) hashCode = hashCode * 59 + this.MountConfig.GetHashCode();
                if (this.InitializerHandler != null) hashCode = hashCode * 59 + this.InitializerHandler.GetHashCode();
                if (this.InitializerTimeout != null) hashCode = hashCode * 59 + this.InitializerTimeout.GetHashCode();
                if (this.PreStopHandler != null) hashCode = hashCode * 59 + this.PreStopHandler.GetHashCode();
                if (this.PreStopTimeout != null) hashCode = hashCode * 59 + this.PreStopTimeout.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LogConfig != null) hashCode = hashCode * 59 + this.LogConfig.GetHashCode();
                if (this.NetworkController != null) hashCode = hashCode * 59 + this.NetworkController.GetHashCode();
                if (this.IsStatefulFunction != null) hashCode = hashCode * 59 + this.IsStatefulFunction.GetHashCode();
                if (this.EnableDynamicMemory != null) hashCode = hashCode * 59 + this.EnableDynamicMemory.GetHashCode();
                if (this.EnableLtsLog != null) hashCode = hashCode * 59 + this.EnableLtsLog.GetHashCode();
                if (this.LtsCustomTag != null) hashCode = hashCode * 59 + this.LtsCustomTag.GetHashCode();
                if (this.UserDataEncryptKmsKeyId != null) hashCode = hashCode * 59 + this.UserDataEncryptKmsKeyId.GetHashCode();
                if (this.CodeEncryptKmsKeyId != null) hashCode = hashCode * 59 + this.CodeEncryptKmsKeyId.GetHashCode();
                if (this.DomainNames != null) hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
