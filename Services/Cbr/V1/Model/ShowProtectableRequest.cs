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
    public class ShowProtectableRequest 
    {
        /// <summary>
        /// Defines protectableType
        /// </summary>
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

            private static readonly Dictionary<string, ProtectableTypeEnum> StaticFields =
            new Dictionary<string, ProtectableTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
            };

            private string Value;

            private ProtectableTypeEnum(string value)
            {
                this.Value = value;
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
                return this.Value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProtectableTypeEnum a, ProtectableTypeEnum b)
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

            public static bool operator !=(ProtectableTypeEnum a, ProtectableTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("protectable_type", IsPath = true)]
        [JsonProperty("protectable_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectableTypeEnum ProtectableType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProtectableRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  protectableType: ").Append(ProtectableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProtectableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProtectableRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ProtectableType == input.ProtectableType ||
                    (this.ProtectableType != null &&
                    this.ProtectableType.Equals(input.ProtectableType))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ProtectableType != null)
                    hashCode = hashCode * 59 + this.ProtectableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
