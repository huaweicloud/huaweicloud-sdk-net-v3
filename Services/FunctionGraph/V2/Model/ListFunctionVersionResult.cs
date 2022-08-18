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
    public class ListFunctionVersionResult 
    {
        /// <summary>
        /// FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Nodejs14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本
        /// </summary>
        /// <value>FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Nodejs14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本</value>
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
            /// Enum PYTHON2_7 for value: Python2.7
            /// </summary>
            public static readonly RuntimeEnum PYTHON2_7 = new RuntimeEnum("Python2.7");

            /// <summary>
            /// Enum PYTHON3_6 for value: Python3.6
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_6 = new RuntimeEnum("Python3.6");

            /// <summary>
            /// Enum GO1_8 for value: Go1.8
            /// </summary>
            public static readonly RuntimeEnum GO1_8 = new RuntimeEnum("Go1.8");

            /// <summary>
            /// Enum GO1_X for value: Go1.x
            /// </summary>
            public static readonly RuntimeEnum GO1_X = new RuntimeEnum("Go1.x");

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
            /// Enum PHP7_3 for value: PHP7.3
            /// </summary>
            public static readonly RuntimeEnum PHP7_3 = new RuntimeEnum("PHP7.3");

            /// <summary>
            /// Enum PYTHON3_9 for value: Python3.9
            /// </summary>
            public static readonly RuntimeEnum PYTHON3_9 = new RuntimeEnum("Python3.9");

            private static readonly Dictionary<string, RuntimeEnum> StaticFields =
            new Dictionary<string, RuntimeEnum>()
            {
                { "Java8", JAVA8 },
                { "Java11", JAVA11 },
                { "Node.js6.10", NODE_JS6_10 },
                { "Node.js8.10", NODE_JS8_10 },
                { "Node.js10.16", NODE_JS10_16 },
                { "Node.js12.13", NODE_JS12_13 },
                { "Node.js14.18", NODE_JS14_18 },
                { "Python2.7", PYTHON2_7 },
                { "Python3.6", PYTHON3_6 },
                { "Go1.8", GO1_8 },
                { "Go1.x", GO1_X },
                { "C#(.NET Core 2.0)", C_NET_CORE_2_0_ },
                { "C#(.NET Core 2.1)", C_NET_CORE_2_1_ },
                { "C#(.NET Core 3.1)", C_NET_CORE_3_1_ },
                { "PHP7.3", PHP7_3 },
                { "Python3.9", PYTHON3_9 },
            };

            private string Value;

            public RuntimeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Nodejs14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
        /// <summary>
        /// 函数执行超时时间，超时函数将被强行停止，范围3～900秒，可以通过白名单配置延长到12小时，具体可以咨询华为云函数工作流服务进行配置
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
        /// 函数占用的cpu资源。 单位为millicore（1 core&#x3D;1000 millicores）。 取值与MemorySize成比例，默认是128M内存占0.1个核（100 millicores）。 函数占用的CPU为基础CPU：200 millicores，再加上内存按比例占用的CPU，计算方法：内存/128 *100 + 200。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cpu { get; set; }

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
        /// 函数大小，单位：字节。
        /// </summary>
        [JsonProperty("code_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? CodeSize { get; set; }

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
        /// 函数版本号，由系统自动生成，规则：vYYYYMMDD-HHMMSS（v+年月日-时分秒）。
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
        /// 函数最后一次更新时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 用户的vpcid
        /// </summary>
        [JsonProperty("func_vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncVpcId { get; set; }

        /// <summary>
        /// 0：函数被禁用;-1：函数被启用。
        /// </summary>
        [JsonProperty("concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// 并发实例数
        /// </summary>
        [JsonProperty("concurrent_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy_config", NullValueHandling = NullValueHandling.Ignore)]
        public StrategyConfig StrategyConfig { get; set; }

        /// <summary>
        /// 函数初始化入口，规则：xx.xx，必须包含“. ”。 举例：对于node.js函数：myfunction.initializer，则表示函数的文件名为myfunction.js，初始化的入口函数名为initializer。
        /// </summary>
        [JsonProperty("initializer_handler", NullValueHandling = NullValueHandling.Ignore)]
        public string InitializerHandler { get; set; }

        /// <summary>
        /// 初始化超时时间，超时函数将被强行停止，范围1～300秒。
        /// </summary>
        [JsonProperty("initializer_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitializerTimeout { get; set; }

        /// <summary>
        /// 是否是支持长时间运行
        /// </summary>
        [JsonProperty("long_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LongTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("function_async_config", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionAsyncConfig FunctionAsyncConfig { get; set; }

        /// <summary>
        /// 函数版本
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 是否启用cloud debug功能
        /// </summary>
        [JsonProperty("enable_cloud_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableCloudDebug { get; set; }

        /// <summary>
        /// 是否启用动态内存功能
        /// </summary>
        [JsonProperty("enable_dynamic_memory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDynamicMemory { get; set; }

        /// <summary>
        /// 企业项目ID，在企业用户创建函数时必填。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否支持有状态，如果需要支持，需要固定传参为true，v2版本支持
        /// </summary>
        [JsonProperty("is_stateful_function", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsStatefulFunction { get; set; }

        /// <summary>
        /// 是否允许在请求头中添加鉴权信息
        /// </summary>
        [JsonProperty("enable_auth_in_header", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAuthInHeader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_image", NullValueHandling = NullValueHandling.Ignore)]
        public CustomImage CustomImage { get; set; }

        /// <summary>
        /// 是否开启预留实例闲置模式
        /// </summary>
        [JsonProperty("reserved_instance_idle_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReservedInstanceIdleMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionVersionResult {\n");
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
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  codeSize: ").Append(CodeSize).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  encryptedUserData: ").Append(EncryptedUserData).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  xrole: ").Append(Xrole).Append("\n");
            sb.Append("  appXrole: ").Append(AppXrole).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  funcVpcId: ").Append(FuncVpcId).Append("\n");
            sb.Append("  concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  concurrentNum: ").Append(ConcurrentNum).Append("\n");
            sb.Append("  strategyConfig: ").Append(StrategyConfig).Append("\n");
            sb.Append("  initializerHandler: ").Append(InitializerHandler).Append("\n");
            sb.Append("  initializerTimeout: ").Append(InitializerTimeout).Append("\n");
            sb.Append("  longTime: ").Append(LongTime).Append("\n");
            sb.Append("  functionAsyncConfig: ").Append(FunctionAsyncConfig).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enableCloudDebug: ").Append(EnableCloudDebug).Append("\n");
            sb.Append("  enableDynamicMemory: ").Append(EnableDynamicMemory).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isStatefulFunction: ").Append(IsStatefulFunction).Append("\n");
            sb.Append("  enableAuthInHeader: ").Append(EnableAuthInHeader).Append("\n");
            sb.Append("  customImage: ").Append(CustomImage).Append("\n");
            sb.Append("  reservedInstanceIdleMode: ").Append(ReservedInstanceIdleMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionVersionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionVersionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuncUrn == input.FuncUrn ||
                    (this.FuncUrn != null &&
                    this.FuncUrn.Equals(input.FuncUrn))
                ) && 
                (
                    this.FuncName == input.FuncName ||
                    (this.FuncName != null &&
                    this.FuncName.Equals(input.FuncName))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Handler == input.Handler ||
                    (this.Handler != null &&
                    this.Handler.Equals(input.Handler))
                ) && 
                (
                    this.MemorySize == input.MemorySize ||
                    (this.MemorySize != null &&
                    this.MemorySize.Equals(input.MemorySize))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
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
                    this.CodeSize == input.CodeSize ||
                    (this.CodeSize != null &&
                    this.CodeSize.Equals(input.CodeSize))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.EncryptedUserData == input.EncryptedUserData ||
                    (this.EncryptedUserData != null &&
                    this.EncryptedUserData.Equals(input.EncryptedUserData))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.Xrole == input.Xrole ||
                    (this.Xrole != null &&
                    this.Xrole.Equals(input.Xrole))
                ) && 
                (
                    this.AppXrole == input.AppXrole ||
                    (this.AppXrole != null &&
                    this.AppXrole.Equals(input.AppXrole))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.FuncVpcId == input.FuncVpcId ||
                    (this.FuncVpcId != null &&
                    this.FuncVpcId.Equals(input.FuncVpcId))
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.ConcurrentNum == input.ConcurrentNum ||
                    (this.ConcurrentNum != null &&
                    this.ConcurrentNum.Equals(input.ConcurrentNum))
                ) && 
                (
                    this.StrategyConfig == input.StrategyConfig ||
                    (this.StrategyConfig != null &&
                    this.StrategyConfig.Equals(input.StrategyConfig))
                ) && 
                (
                    this.InitializerHandler == input.InitializerHandler ||
                    (this.InitializerHandler != null &&
                    this.InitializerHandler.Equals(input.InitializerHandler))
                ) && 
                (
                    this.InitializerTimeout == input.InitializerTimeout ||
                    (this.InitializerTimeout != null &&
                    this.InitializerTimeout.Equals(input.InitializerTimeout))
                ) && 
                (
                    this.LongTime == input.LongTime ||
                    (this.LongTime != null &&
                    this.LongTime.Equals(input.LongTime))
                ) && 
                (
                    this.FunctionAsyncConfig == input.FunctionAsyncConfig ||
                    (this.FunctionAsyncConfig != null &&
                    this.FunctionAsyncConfig.Equals(input.FunctionAsyncConfig))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.EnableCloudDebug == input.EnableCloudDebug ||
                    (this.EnableCloudDebug != null &&
                    this.EnableCloudDebug.Equals(input.EnableCloudDebug))
                ) && 
                (
                    this.EnableDynamicMemory == input.EnableDynamicMemory ||
                    (this.EnableDynamicMemory != null &&
                    this.EnableDynamicMemory.Equals(input.EnableDynamicMemory))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.IsStatefulFunction == input.IsStatefulFunction ||
                    (this.IsStatefulFunction != null &&
                    this.IsStatefulFunction.Equals(input.IsStatefulFunction))
                ) && 
                (
                    this.EnableAuthInHeader == input.EnableAuthInHeader ||
                    (this.EnableAuthInHeader != null &&
                    this.EnableAuthInHeader.Equals(input.EnableAuthInHeader))
                ) && 
                (
                    this.CustomImage == input.CustomImage ||
                    (this.CustomImage != null &&
                    this.CustomImage.Equals(input.CustomImage))
                ) && 
                (
                    this.ReservedInstanceIdleMode == input.ReservedInstanceIdleMode ||
                    (this.ReservedInstanceIdleMode != null &&
                    this.ReservedInstanceIdleMode.Equals(input.ReservedInstanceIdleMode))
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
                if (this.FuncUrn != null)
                    hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.FuncName != null)
                    hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.MemorySize != null)
                    hashCode = hashCode * 59 + this.MemorySize.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.CodeType != null)
                    hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null)
                    hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null)
                    hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.CodeSize != null)
                    hashCode = hashCode * 59 + this.CodeSize.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.EncryptedUserData != null)
                    hashCode = hashCode * 59 + this.EncryptedUserData.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.Xrole != null)
                    hashCode = hashCode * 59 + this.Xrole.GetHashCode();
                if (this.AppXrole != null)
                    hashCode = hashCode * 59 + this.AppXrole.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.FuncVpcId != null)
                    hashCode = hashCode * 59 + this.FuncVpcId.GetHashCode();
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.ConcurrentNum != null)
                    hashCode = hashCode * 59 + this.ConcurrentNum.GetHashCode();
                if (this.StrategyConfig != null)
                    hashCode = hashCode * 59 + this.StrategyConfig.GetHashCode();
                if (this.InitializerHandler != null)
                    hashCode = hashCode * 59 + this.InitializerHandler.GetHashCode();
                if (this.InitializerTimeout != null)
                    hashCode = hashCode * 59 + this.InitializerTimeout.GetHashCode();
                if (this.LongTime != null)
                    hashCode = hashCode * 59 + this.LongTime.GetHashCode();
                if (this.FunctionAsyncConfig != null)
                    hashCode = hashCode * 59 + this.FunctionAsyncConfig.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnableCloudDebug != null)
                    hashCode = hashCode * 59 + this.EnableCloudDebug.GetHashCode();
                if (this.EnableDynamicMemory != null)
                    hashCode = hashCode * 59 + this.EnableDynamicMemory.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsStatefulFunction != null)
                    hashCode = hashCode * 59 + this.IsStatefulFunction.GetHashCode();
                if (this.EnableAuthInHeader != null)
                    hashCode = hashCode * 59 + this.EnableAuthInHeader.GetHashCode();
                if (this.CustomImage != null)
                    hashCode = hashCode * 59 + this.CustomImage.GetHashCode();
                if (this.ReservedInstanceIdleMode != null)
                    hashCode = hashCode * 59 + this.ReservedInstanceIdleMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
