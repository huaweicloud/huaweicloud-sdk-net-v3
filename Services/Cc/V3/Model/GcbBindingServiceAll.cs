using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GcbBindingServiceAll 
    {
        /// <summary>
        /// 功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型
        /// </summary>
        /// <value>功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型</value>
        [JsonConverter(typeof(EnumClassConverter<BindingServiceEnum>))]
        public class BindingServiceEnum
        {
            /// <summary>
            /// Enum CC for value: CC
            /// </summary>
            public static readonly BindingServiceEnum CC = new BindingServiceEnum("CC");

            /// <summary>
            /// Enum GEIP for value: GEIP
            /// </summary>
            public static readonly BindingServiceEnum GEIP = new BindingServiceEnum("GEIP");

            /// <summary>
            /// Enum GCN for value: GCN
            /// </summary>
            public static readonly BindingServiceEnum GCN = new BindingServiceEnum("GCN");

            /// <summary>
            /// Enum GSN for value: GSN
            /// </summary>
            public static readonly BindingServiceEnum GSN = new BindingServiceEnum("GSN");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly BindingServiceEnum ALL = new BindingServiceEnum("ALL");

            private static readonly Dictionary<string, BindingServiceEnum> StaticFields =
            new Dictionary<string, BindingServiceEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
                { "ALL", ALL },
            };

            private string _value;

            public BindingServiceEnum()
            {

            }

            public BindingServiceEnum(string value)
            {
                _value = value;
            }

            public static BindingServiceEnum FromValue(string value)
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

                if (this.Equals(obj as BindingServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BindingServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BindingServiceEnum a, BindingServiceEnum b)
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

            public static bool operator !=(BindingServiceEnum a, BindingServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：绑定的服务类型。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络 - ALL: 所有实例类型
        /// </summary>
        [JsonProperty("binding_service", NullValueHandling = NullValueHandling.Ignore)]
        public BindingServiceEnum BindingService { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbBindingServiceAll {\n");
            sb.Append("  bindingService: ").Append(BindingService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbBindingServiceAll);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbBindingServiceAll input)
        {
            if (input == null) return false;
            if (this.BindingService != input.BindingService) return false;

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
                hashCode = hashCode * 59 + this.BindingService.GetHashCode();
                return hashCode;
            }
        }
    }
}
