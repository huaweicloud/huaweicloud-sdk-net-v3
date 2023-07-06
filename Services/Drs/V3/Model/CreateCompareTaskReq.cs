using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCompareTaskReq 
    {
        /// <summary>
        /// 对象级对比类型，取值为空代表不创建对象级对比。object_level_compare_type和data_level_compare_info都为空时，只查询已创建的对比任务列表。
        /// </summary>
        /// <value>对象级对比类型，取值为空代表不创建对象级对比。object_level_compare_type和data_level_compare_info都为空时，只查询已创建的对比任务列表。</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectLevelCompareTypeEnum>))]
        public class ObjectLevelCompareTypeEnum
        {
            /// <summary>
            /// Enum OBJECTS for value: objects
            /// </summary>
            public static readonly ObjectLevelCompareTypeEnum OBJECTS = new ObjectLevelCompareTypeEnum("objects");

            private static readonly Dictionary<string, ObjectLevelCompareTypeEnum> StaticFields =
            new Dictionary<string, ObjectLevelCompareTypeEnum>()
            {
                { "objects", OBJECTS },
            };

            private string _value;

            public ObjectLevelCompareTypeEnum()
            {

            }

            public ObjectLevelCompareTypeEnum(string value)
            {
                _value = value;
            }

            public static ObjectLevelCompareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectLevelCompareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectLevelCompareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectLevelCompareTypeEnum a, ObjectLevelCompareTypeEnum b)
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

            public static bool operator !=(ObjectLevelCompareTypeEnum a, ObjectLevelCompareTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 对象级对比类型，取值为空代表不创建对象级对比。object_level_compare_type和data_level_compare_info都为空时，只查询已创建的对比任务列表。
        /// </summary>
        [JsonProperty("object_level_compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectLevelCompareTypeEnum ObjectLevelCompareType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_level_compare_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDataLevelCompareReq DataLevelCompareInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCompareTaskReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  objectLevelCompareType: ").Append(ObjectLevelCompareType).Append("\n");
            sb.Append("  dataLevelCompareInfo: ").Append(DataLevelCompareInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCompareTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCompareTaskReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ObjectLevelCompareType == input.ObjectLevelCompareType ||
                    (this.ObjectLevelCompareType != null &&
                    this.ObjectLevelCompareType.Equals(input.ObjectLevelCompareType))
                ) && 
                (
                    this.DataLevelCompareInfo == input.DataLevelCompareInfo ||
                    (this.DataLevelCompareInfo != null &&
                    this.DataLevelCompareInfo.Equals(input.DataLevelCompareInfo))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ObjectLevelCompareType != null)
                    hashCode = hashCode * 59 + this.ObjectLevelCompareType.GetHashCode();
                if (this.DataLevelCompareInfo != null)
                    hashCode = hashCode * 59 + this.DataLevelCompareInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
