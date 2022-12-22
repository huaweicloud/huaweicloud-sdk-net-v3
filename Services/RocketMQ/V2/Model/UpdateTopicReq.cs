using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTopicReq 
    {
        /// <summary>
        /// 权限。
        /// </summary>
        /// <value>权限。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionEnum>))]
        public class PermissionEnum
        {
            /// <summary>
            /// Enum SUB for value: sub
            /// </summary>
            public static readonly PermissionEnum SUB = new PermissionEnum("sub");

            /// <summary>
            /// Enum PUB for value: pub
            /// </summary>
            public static readonly PermissionEnum PUB = new PermissionEnum("pub");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly PermissionEnum ALL = new PermissionEnum("all");

            private static readonly Dictionary<string, PermissionEnum> StaticFields =
            new Dictionary<string, PermissionEnum>()
            {
                { "sub", SUB },
                { "pub", PUB },
                { "all", ALL },
            };

            private string _value;

            public PermissionEnum()
            {

            }

            public PermissionEnum(string value)
            {
                _value = value;
            }

            public static PermissionEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionEnum a, PermissionEnum b)
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

            public static bool operator !=(PermissionEnum a, PermissionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 总读队列个数。
        /// </summary>
        [JsonProperty("read_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReadQueueNum { get; set; }

        /// <summary>
        /// 总写队列个数。
        /// </summary>
        [JsonProperty("write_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteQueueNum { get; set; }

        /// <summary>
        /// 权限。
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionEnum Permission { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTopicReq {\n");
            sb.Append("  readQueueNum: ").Append(ReadQueueNum).Append("\n");
            sb.Append("  writeQueueNum: ").Append(WriteQueueNum).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTopicReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadQueueNum == input.ReadQueueNum ||
                    (this.ReadQueueNum != null &&
                    this.ReadQueueNum.Equals(input.ReadQueueNum))
                ) && 
                (
                    this.WriteQueueNum == input.WriteQueueNum ||
                    (this.WriteQueueNum != null &&
                    this.WriteQueueNum.Equals(input.WriteQueueNum))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.ReadQueueNum != null)
                    hashCode = hashCode * 59 + this.ReadQueueNum.GetHashCode();
                if (this.WriteQueueNum != null)
                    hashCode = hashCode * 59 + this.WriteQueueNum.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                return hashCode;
            }
        }
    }
}
