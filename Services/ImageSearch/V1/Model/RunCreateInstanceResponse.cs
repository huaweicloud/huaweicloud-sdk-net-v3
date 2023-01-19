using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RunCreateInstanceResponse : SdkResponse
    {
        /// <summary>
        /// 实例的状态，有以下状态信息：   - NORMAL：正常。   - ARREARAGE：欠费。   - CREATION：创建中。   - CREATION_FAILD：创建失败。   - DELETING：删除中。   - DELETING_FAILED：删除失败。   - ABNORMAL：异常。
        /// </summary>
        /// <value>实例的状态，有以下状态信息：   - NORMAL：正常。   - ARREARAGE：欠费。   - CREATION：创建中。   - CREATION_FAILD：创建失败。   - DELETING：删除中。   - DELETING_FAILED：删除失败。   - ABNORMAL：异常。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly StatusEnum NORMAL = new StatusEnum("NORMAL");

            /// <summary>
            /// Enum ARREARAGE for value: ARREARAGE
            /// </summary>
            public static readonly StatusEnum ARREARAGE = new StatusEnum("ARREARAGE");

            /// <summary>
            /// Enum CREATION for value: CREATION
            /// </summary>
            public static readonly StatusEnum CREATION = new StatusEnum("CREATION");

            /// <summary>
            /// Enum CREATION_FAILD for value: CREATION_FAILD
            /// </summary>
            public static readonly StatusEnum CREATION_FAILD = new StatusEnum("CREATION_FAILD");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum DELETING_FAILED for value: DELETING_FAILED
            /// </summary>
            public static readonly StatusEnum DELETING_FAILED = new StatusEnum("DELETING_FAILED");

            /// <summary>
            /// Enum ABNORMAL for value: ABNORMAL
            /// </summary>
            public static readonly StatusEnum ABNORMAL = new StatusEnum("ABNORMAL");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "NORMAL", NORMAL },
                { "ARREARAGE", ARREARAGE },
                { "CREATION", CREATION },
                { "CREATION_FAILD", CREATION_FAILD },
                { "DELETING", DELETING },
                { "DELETING_FAILED", DELETING_FAILED },
                { "ABNORMAL", ABNORMAL },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 模型展示名或领域名称。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 注册时间。
        /// </summary>
        [JsonProperty("registerDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegisterDate { get; set; }

        /// <summary>
        /// 过期时间，-1表示永不过期。
        /// </summary>
        [JsonProperty("expiredDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiredDate { get; set; }

        /// <summary>
        /// 规格，即实例的图片数量规格，默认为30000000（单位：张）。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 图片自定义标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 实例的状态，有以下状态信息：   - NORMAL：正常。   - ARREARAGE：欠费。   - CREATION：创建中。   - CREATION_FAILD：创建失败。   - DELETING：删除中。   - DELETING_FAILED：删除失败。   - ABNORMAL：异常。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instanceName", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunCreateInstanceResponse {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  registerDate: ").Append(RegisterDate).Append("\n");
            sb.Append("  expiredDate: ").Append(ExpiredDate).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunCreateInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunCreateInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.RegisterDate == input.RegisterDate ||
                    (this.RegisterDate != null &&
                    this.RegisterDate.Equals(input.RegisterDate))
                ) && 
                (
                    this.ExpiredDate == input.ExpiredDate ||
                    (this.ExpiredDate != null &&
                    this.ExpiredDate.Equals(input.ExpiredDate))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.RegisterDate != null)
                    hashCode = hashCode * 59 + this.RegisterDate.GetHashCode();
                if (this.ExpiredDate != null)
                    hashCode = hashCode * 59 + this.ExpiredDate.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
