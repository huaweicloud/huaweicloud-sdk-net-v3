using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgenciesTaskReq 
    {
        /// <summary>
        /// 操作标记，取值[CREATED,CANCELED]，CREATED表示授权, CANCELED表示取消授权 
        /// </summary>
        /// <value>操作标记，取值[CREATED,CANCELED]，CREATED表示授权, CANCELED表示取消授权 </value>
        [JsonConverter(typeof(EnumClassConverter<OperateTypeEnum>))]
        public class OperateTypeEnum
        {
            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly OperateTypeEnum CREATED = new OperateTypeEnum("CREATED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly OperateTypeEnum CANCELED = new OperateTypeEnum("CANCELED");

            private static readonly Dictionary<string, OperateTypeEnum> StaticFields =
            new Dictionary<string, OperateTypeEnum>()
            {
                { "CREATED", CREATED },
                { "CANCELED", CANCELED },
            };

            private string _value;

            public OperateTypeEnum()
            {

            }

            public OperateTypeEnum(string value)
            {
                _value = value;
            }

            public static OperateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateTypeEnum a, OperateTypeEnum b)
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

            public static bool operator !=(OperateTypeEnum a, OperateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 委托任务租户Id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作标记，取值[CREATED,CANCELED]，CREATED表示授权, CANCELED表示取消授权 
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperateTypeEnum OperateType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenciesTaskReq {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgenciesTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgenciesTaskReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.OperateType != null)
                    hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
