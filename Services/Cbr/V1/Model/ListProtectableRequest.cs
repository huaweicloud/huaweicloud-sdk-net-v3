using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListProtectableRequest 
    {
        /// <summary>
        /// 对象类型
        /// </summary>
        /// <value>对象类型</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectableTypeEnum>))]
        public class ProtectableTypeEnum
        {
            /// <summary>
            /// Enum SERVER for value: server
            /// </summary>
            public static readonly ProtectableTypeEnum SERVER = new ProtectableTypeEnum("server");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly ProtectableTypeEnum DISK = new ProtectableTypeEnum("disk");

            /// <summary>
            /// Enum TURBO for value: turbo
            /// </summary>
            public static readonly ProtectableTypeEnum TURBO = new ProtectableTypeEnum("turbo");

            /// <summary>
            /// Enum WORKSPACE for value: workspace
            /// </summary>
            public static readonly ProtectableTypeEnum WORKSPACE = new ProtectableTypeEnum("workspace");

            /// <summary>
            /// Enum WORKSPACE_V2 for value: workspace_v2
            /// </summary>
            public static readonly ProtectableTypeEnum WORKSPACE_V2 = new ProtectableTypeEnum("workspace_v2");

            private static readonly Dictionary<string, ProtectableTypeEnum> StaticFields =
            new Dictionary<string, ProtectableTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
                { "turbo", TURBO },
                { "workspace", WORKSPACE },
                { "workspace_v2", WORKSPACE_V2 },
            };

            private string _value;

            public ProtectableTypeEnum()
            {

            }

            public ProtectableTypeEnum(string value)
            {
                _value = value;
            }

            public static ProtectableTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectableTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectableTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectableTypeEnum a, ProtectableTypeEnum b)
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

            public static bool operator !=(ProtectableTypeEnum a, ProtectableTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 每页显示的条目数量，每页最多支持50条
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一次查询最后一条的ID
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 按名称过滤
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 偏移值
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [SDKProperty("protectable_type", IsPath = true)]
        [JsonProperty("protectable_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectableTypeEnum ProtectableType { get; set; }
        /// <summary>
        /// 资源的状态，如available，error 等
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 根据资源id过滤
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 根据该id过滤属于该服务器的所有磁盘，支持企业多项目的用户才能传入此参数
        /// </summary>
        [SDKProperty("server_id", IsQuery = true)]
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProtectableRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  protectableType: ").Append(ProtectableType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProtectableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProtectableRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.ProtectableType != input.ProtectableType) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectableType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
