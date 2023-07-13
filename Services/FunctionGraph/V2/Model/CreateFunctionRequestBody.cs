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
        /// FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 http: HTTP函数。
        /// </summary>
        /// <value>FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 http: HTTP函数。</value>
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

            /// <summary>
            /// Enum CUSTOM for value: Custom
            /// </summary>
            public static readonly RuntimeEnum CUSTOM = new RuntimeEnum("Custom");

            /// <summary>
            /// Enum HTTP for value: http
            /// </summary>
            public static readonly RuntimeEnum HTTP = new RuntimeEnum("http");

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
                { "Custom", CUSTOM },
                { "http", HTTP },
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
        /// FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 http: HTTP函数。
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
        /// 用户自定义的name/value信息。 在函数中使用的参数。 举例：如函数要访问某个主机，可以设置自定义参数：Host&#x3D;{host_ip}，最多定义20个，总长度不超过4KB。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("func_code", NullValueHandling = NullValueHandling.Ignore)]
        public FuncCode FuncCode { get; set; }

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
            sb.Append("  codeType: ").Append(CodeType).Append("\n");
            sb.Append("  codeUrl: ").Append(CodeUrl).Append("\n");
            sb.Append("  codeFilename: ").Append(CodeFilename).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  xrole: ").Append(Xrole).Append("\n");
            sb.Append("  appXrole: ").Append(AppXrole).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  funcCode: ").Append(FuncCode).Append("\n");
            sb.Append("  initializerHandler: ").Append(InitializerHandler).Append("\n");
            sb.Append("  initializerTimeout: ").Append(InitializerTimeout).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  logConfig: ").Append(LogConfig).Append("\n");
            sb.Append("  networkController: ").Append(NetworkController).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.FuncName == input.FuncName ||
                    (this.FuncName != null &&
                    this.FuncName.Equals(input.FuncName))
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
                    this.DependVersionList == input.DependVersionList ||
                    this.DependVersionList != null &&
                    input.DependVersionList != null &&
                    this.DependVersionList.SequenceEqual(input.DependVersionList)
                ) && 
                (
                    this.FuncVpc == input.FuncVpc ||
                    (this.FuncVpc != null &&
                    this.FuncVpc.Equals(input.FuncVpc))
                ) && 
                (
                    this.MemorySize == input.MemorySize ||
                    (this.MemorySize != null &&
                    this.MemorySize.Equals(input.MemorySize))
                ) && 
                (
                    this.GpuMemory == input.GpuMemory ||
                    (this.GpuMemory != null &&
                    this.GpuMemory.Equals(input.GpuMemory))
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
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FuncCode == input.FuncCode ||
                    (this.FuncCode != null &&
                    this.FuncCode.Equals(input.FuncCode))
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LogConfig == input.LogConfig ||
                    (this.LogConfig != null &&
                    this.LogConfig.Equals(input.LogConfig))
                ) && 
                (
                    this.NetworkController == input.NetworkController ||
                    (this.NetworkController != null &&
                    this.NetworkController.Equals(input.NetworkController))
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
                if (this.FuncName != null)
                    hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.DependVersionList != null)
                    hashCode = hashCode * 59 + this.DependVersionList.GetHashCode();
                if (this.FuncVpc != null)
                    hashCode = hashCode * 59 + this.FuncVpc.GetHashCode();
                if (this.MemorySize != null)
                    hashCode = hashCode * 59 + this.MemorySize.GetHashCode();
                if (this.GpuMemory != null)
                    hashCode = hashCode * 59 + this.GpuMemory.GetHashCode();
                if (this.CodeType != null)
                    hashCode = hashCode * 59 + this.CodeType.GetHashCode();
                if (this.CodeUrl != null)
                    hashCode = hashCode * 59 + this.CodeUrl.GetHashCode();
                if (this.CodeFilename != null)
                    hashCode = hashCode * 59 + this.CodeFilename.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Xrole != null)
                    hashCode = hashCode * 59 + this.Xrole.GetHashCode();
                if (this.AppXrole != null)
                    hashCode = hashCode * 59 + this.AppXrole.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FuncCode != null)
                    hashCode = hashCode * 59 + this.FuncCode.GetHashCode();
                if (this.InitializerHandler != null)
                    hashCode = hashCode * 59 + this.InitializerHandler.GetHashCode();
                if (this.InitializerTimeout != null)
                    hashCode = hashCode * 59 + this.InitializerTimeout.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LogConfig != null)
                    hashCode = hashCode * 59 + this.LogConfig.GetHashCode();
                if (this.NetworkController != null)
                    hashCode = hashCode * 59 + this.NetworkController.GetHashCode();
                return hashCode;
            }
        }
    }
}
