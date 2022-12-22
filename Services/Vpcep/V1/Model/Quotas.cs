using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 创建配额接口请求结构体
    /// </summary>
    public class Quotas 
    {
        /// <summary>
        /// 资源类型。支持根据资源类型过滤查询指定类型的配额。 ● endpoint_service：终端节点服务 ● endpoint：终端节点
        /// </summary>
        /// <value>资源类型。支持根据资源类型过滤查询指定类型的配额。 ● endpoint_service：终端节点服务 ● endpoint：终端节点</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ENDPOINT_SERVICE for value: endpoint_service
            /// </summary>
            public static readonly TypeEnum ENDPOINT_SERVICE = new TypeEnum("endpoint_service");

            /// <summary>
            /// Enum ENDPOINT for value: endpoint
            /// </summary>
            public static readonly TypeEnum ENDPOINT = new TypeEnum("endpoint");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "endpoint_service", ENDPOINT_SERVICE },
                { "endpoint", ENDPOINT },
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
        /// 资源类型。支持根据资源类型过滤查询指定类型的配额。 ● endpoint_service：终端节点服务 ● endpoint：终端节点
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 已创建的资源个数。 取值范围：0~quota数。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 资源的最大配额数。 取值范围：各类型资源默认配额数的最大值。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quotas {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quotas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quotas input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                return hashCode;
            }
        }
    }
}
