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
    /// Request Object
    /// </summary>
    public class ListDependenciesRequest 
    {
        /// <summary>
        /// 依赖包类型public：公开,private:私有，all：全部。缺省时查询全量。
        /// </summary>
        /// <value>依赖包类型public：公开,private:私有，all：全部。缺省时查询全量。</value>
        [JsonConverter(typeof(EnumClassConverter<DependencyTypeEnum>))]
        public class DependencyTypeEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly DependencyTypeEnum PUBLIC = new DependencyTypeEnum("public");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly DependencyTypeEnum PRIVATE = new DependencyTypeEnum("private");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly DependencyTypeEnum ALL = new DependencyTypeEnum("all");

            private static readonly Dictionary<string, DependencyTypeEnum> StaticFields =
            new Dictionary<string, DependencyTypeEnum>()
            {
                { "public", PUBLIC },
                { "private", PRIVATE },
                { "all", ALL },
            };

            private string Value;

            public DependencyTypeEnum(string value)
            {
                Value = value;
            }

            public static DependencyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DependencyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DependencyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DependencyTypeEnum a, DependencyTypeEnum b)
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

            public static bool operator !=(DependencyTypeEnum a, DependencyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 运行时语言
        /// </summary>
        /// <value>运行时语言</value>
        [JsonConverter(typeof(EnumClassConverter<RuntimeEnum>))]
        public class RuntimeEnum
        {
            /// <summary>
            /// Enum JAVA_8 for value: Java 8
            /// </summary>
            public static readonly RuntimeEnum JAVA_8 = new RuntimeEnum("Java 8");

            /// <summary>
            /// Enum NODE_JS_6_10 for value: Node.js 6.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS_6_10 = new RuntimeEnum("Node.js 6.10");

            /// <summary>
            /// Enum NODE_JS_8_10 for value: Node.js 8.10
            /// </summary>
            public static readonly RuntimeEnum NODE_JS_8_10 = new RuntimeEnum("Node.js 8.10");

            /// <summary>
            /// Enum NODE_JS_10_16 for value: Node.js 10.16
            /// </summary>
            public static readonly RuntimeEnum NODE_JS_10_16 = new RuntimeEnum("Node.js 10.16");

            /// <summary>
            /// Enum NODE_JS_12_13 for value: Node.js 12.13
            /// </summary>
            public static readonly RuntimeEnum NODE_JS_12_13 = new RuntimeEnum("Node.js 12.13");

            /// <summary>
            /// Enum PYTHON_2_7 for value: Python 2.7
            /// </summary>
            public static readonly RuntimeEnum PYTHON_2_7 = new RuntimeEnum("Python 2.7");

            /// <summary>
            /// Enum PYTHON_3_6 for value: Python 3.6
            /// </summary>
            public static readonly RuntimeEnum PYTHON_3_6 = new RuntimeEnum("Python 3.6");

            /// <summary>
            /// Enum GO_1_8 for value: Go 1.8
            /// </summary>
            public static readonly RuntimeEnum GO_1_8 = new RuntimeEnum("Go 1.8");

            /// <summary>
            /// Enum GO_1_X for value: Go 1.x
            /// </summary>
            public static readonly RuntimeEnum GO_1_X = new RuntimeEnum("Go 1.x");

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
            /// Enum PHP_7_3 for value: PHP 7.3
            /// </summary>
            public static readonly RuntimeEnum PHP_7_3 = new RuntimeEnum("PHP 7.3");

            private static readonly Dictionary<string, RuntimeEnum> StaticFields =
            new Dictionary<string, RuntimeEnum>()
            {
                { "Java 8", JAVA_8 },
                { "Node.js 6.10", NODE_JS_6_10 },
                { "Node.js 8.10", NODE_JS_8_10 },
                { "Node.js 10.16", NODE_JS_10_16 },
                { "Node.js 12.13", NODE_JS_12_13 },
                { "Python 2.7", PYTHON_2_7 },
                { "Python 3.6", PYTHON_3_6 },
                { "Go 1.8", GO_1_8 },
                { "Go 1.x", GO_1_X },
                { "C#(.NET Core 2.0)", C_NET_CORE_2_0_ },
                { "C#(.NET Core 2.1)", C_NET_CORE_2_1_ },
                { "C#(.NET Core 3.1)", C_NET_CORE_3_1_ },
                { "PHP 7.3", PHP_7_3 },
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
        /// 依赖包类型public：公开,private:私有，all：全部。缺省时查询全量。
        /// </summary>
        [SDKProperty("dependency_type", IsQuery = true)]
        [JsonProperty("dependency_type", NullValueHandling = NullValueHandling.Ignore)]
        public DependencyTypeEnum DependencyType { get; set; }
        /// <summary>
        /// 运行时语言
        /// </summary>
        [SDKProperty("runtime", IsQuery = true)]
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeEnum Runtime { get; set; }
        /// <summary>
        /// 依赖包名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 上一次查询依赖包的最后记录位置，默认为\&quot;0\&quot;。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 本次查询可获取的依赖包的最大数目，默认为\&quot;400\&quot;。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDependenciesRequest {\n");
            sb.Append("  dependencyType: ").Append(DependencyType).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDependenciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDependenciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DependencyType == input.DependencyType ||
                    (this.DependencyType != null &&
                    this.DependencyType.Equals(input.DependencyType))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.DependencyType != null)
                    hashCode = hashCode * 59 + this.DependencyType.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
