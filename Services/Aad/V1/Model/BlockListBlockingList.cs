using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BlockListBlockingList 
    {
        /// <summary>
        /// 状态。unblocking：解封中；success：成功；failed：失败
        /// </summary>
        /// <value>状态。unblocking：解封中；success：成功；failed：失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum UNBLOCKING for value: unblocking
            /// </summary>
            public static readonly StatusEnum UNBLOCKING = new StatusEnum("unblocking");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "failed", FAILED },
                { "success", SUCCESS },
                { "unblocking", UNBLOCKING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 封堵时间
        /// </summary>
        [JsonProperty("blocking_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockingTime { get; set; }

        /// <summary>
        /// 预计解封时间
        /// </summary>
        [JsonProperty("estimated_unblocking_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EstimatedUnblockingTime { get; set; }

        /// <summary>
        /// 状态。unblocking：解封中；success：成功；failed：失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockListBlockingList {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  blockingTime: ").Append(BlockingTime).Append("\n");
            sb.Append("  estimatedUnblockingTime: ").Append(EstimatedUnblockingTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlockListBlockingList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BlockListBlockingList input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.BlockingTime != input.BlockingTime || (this.BlockingTime != null && !this.BlockingTime.Equals(input.BlockingTime))) return false;
            if (this.EstimatedUnblockingTime != input.EstimatedUnblockingTime || (this.EstimatedUnblockingTime != null && !this.EstimatedUnblockingTime.Equals(input.EstimatedUnblockingTime))) return false;
            if (this.Status != input.Status) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.BlockingTime != null) hashCode = hashCode * 59 + this.BlockingTime.GetHashCode();
                if (this.EstimatedUnblockingTime != null) hashCode = hashCode * 59 + this.EstimatedUnblockingTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
