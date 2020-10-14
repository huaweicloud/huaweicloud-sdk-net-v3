using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DetachServerVolumeRequest 
    {
        /// <summary>
        /// Defines deleteFlag
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteFlagEnum>))]
        public class DeleteFlagEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly DeleteFlagEnum _0 = new DeleteFlagEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly DeleteFlagEnum _1 = new DeleteFlagEnum("1");

            private static readonly Dictionary<string, DeleteFlagEnum> StaticFields =
            new Dictionary<string, DeleteFlagEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string Value;

            public DeleteFlagEnum(string value)
            {
                Value = value;
            }

            public static DeleteFlagEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteFlagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteFlagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteFlagEnum a, DeleteFlagEnum b)
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

            public static bool operator !=(DeleteFlagEnum a, DeleteFlagEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("server_id", IsPath = true)]
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("volume_id", IsPath = true)]
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_flag", IsQuery = true)]
        [JsonProperty("delete_flag", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteFlagEnum DeleteFlag { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachServerVolumeRequest {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  deleteFlag: ").Append(DeleteFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachServerVolumeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachServerVolumeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.DeleteFlag == input.DeleteFlag ||
                    (this.DeleteFlag != null &&
                    this.DeleteFlag.Equals(input.DeleteFlag))
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
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.DeleteFlag != null)
                    hashCode = hashCode * 59 + this.DeleteFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
