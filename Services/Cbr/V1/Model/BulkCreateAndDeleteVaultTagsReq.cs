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
    /// 
    /// </summary>
    public class BulkCreateAndDeleteVaultTagsReq 
    {
        /// <summary>
        /// 操作标识：仅限于create（创建）、delete（删除）
        /// </summary>
        /// <value>操作标识：仅限于create（创建）、delete（删除）</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE for value: create
            /// </summary>
            public static readonly ActionEnum CREATE = new ActionEnum("create");

            /// <summary>
            /// Enum _DELETE for value:  delete
            /// </summary>
            public static readonly ActionEnum _DELETE = new ActionEnum(" delete");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "create", CREATE },
                { " delete", _DELETE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标签列表。  tags不允许为空列表。  tags中最多包含10个key。  tags中key不允许重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 系统标签列表。  op_service权限可以访问，和tags二选一。  目前TMS调用时只包含一个resource_tag结构体 ，key固定为：_sys_enterprise_project_id。  value是UUID或0,value为0表示默认企业项目。  现在仅支持create操作。
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<SysTag> SysTags { get; set; }

        /// <summary>
        /// 操作标识：仅限于create（创建）、delete（删除）
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkCreateAndDeleteVaultTagsReq {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BulkCreateAndDeleteVaultTagsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BulkCreateAndDeleteVaultTagsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
