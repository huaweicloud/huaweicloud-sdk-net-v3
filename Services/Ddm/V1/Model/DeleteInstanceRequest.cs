using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteInstanceRequest 
    {
        /// <summary>
        /// 是否同时删除关联后端数据库实例上存储的数据。  - 取值为空或“true”：删除。 - 取值为“false”：不删除。 默认值为空。
        /// </summary>
        /// <value>是否同时删除关联后端数据库实例上存储的数据。  - 取值为空或“true”：删除。 - 取值为“false”：不删除。 默认值为空。</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteRdsDataEnum>))]
        public class DeleteRdsDataEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteRdsDataEnum TRUE = new DeleteRdsDataEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteRdsDataEnum FALSE = new DeleteRdsDataEnum("false");

            private static readonly Dictionary<string, DeleteRdsDataEnum> StaticFields =
            new Dictionary<string, DeleteRdsDataEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public DeleteRdsDataEnum()
            {

            }

            public DeleteRdsDataEnum(string value)
            {
                _value = value;
            }

            public static DeleteRdsDataEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteRdsDataEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteRdsDataEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteRdsDataEnum a, DeleteRdsDataEnum b)
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

            public static bool operator !=(DeleteRdsDataEnum a, DeleteRdsDataEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// DDM实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否同时删除关联后端数据库实例上存储的数据。  - 取值为空或“true”：删除。 - 取值为“false”：不删除。 默认值为空。
        /// </summary>
        [SDKProperty("delete_rds_data", IsQuery = true)]
        [JsonProperty("delete_rds_data", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteRdsDataEnum DeleteRdsData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInstanceRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  deleteRdsData: ").Append(DeleteRdsData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInstanceRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.DeleteRdsData != input.DeleteRdsData) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteRdsData.GetHashCode();
                return hashCode;
            }
        }
    }
}
