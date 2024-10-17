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
    /// 函数依赖包结构。
    /// </summary>
    public class Dependency 
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
        /// 依赖包版本ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 依赖包属主的domainId。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 依赖包在OBS上的链接。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// FunctionGraph函数的执行环境 Java8: Java语言8版本。 Java11: Java语言11版本。 Java17: Java语言17版本（当前仅支持华北-乌兰察布二零二） Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Python3.10: Python语言3.10版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 Node.js16.17: Nodejs语言16.17版本。 Node.js18.15: Nodejs语言18.15版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 C#(.NET Core 6.0): C#语言6.0版本（当前仅支持华北-乌兰察布二零二）。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 Cangjie1.0：仓颉语言1.0版本。 http: HTTP函数。 Custom Image: 自定义镜像函数。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
        /// <summary>
        /// 依赖包的md5值
        /// </summary>
        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }

        /// <summary>
        /// 依赖包大小。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 依赖包名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 依赖包描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 依赖包文件名，如果创建方式为zip时。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 依赖包版本编号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        /// <summary>
        /// 依赖包ID
        /// </summary>
        [JsonProperty("dep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DepId { get; set; }

        /// <summary>
        /// 依赖包最后一次更新时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dependency {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  etag: ").Append(Etag).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  depId: ").Append(DepId).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Dependency);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Dependency input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Runtime != input.Runtime) return false;
            if (this.Etag != input.Etag || (this.Etag != null && !this.Etag.Equals(input.Etag))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.DepId != input.DepId || (this.DepId != null && !this.DepId.Equals(input.DepId))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Etag != null) hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.DepId != null) hashCode = hashCode * 59 + this.DepId.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                return hashCode;
            }
        }
    }
}
