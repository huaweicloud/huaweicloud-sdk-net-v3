using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTenantRepositoriesRequest 
    {
        /// <summary>
        /// **参数解释：** 仓库状态。 **取值范围：** - 0，正常。 - 3，冻结。 - 4，关闭。 - 5，清理中。 - 7，删除中。
        /// </summary>
        /// <value>**参数解释：** 仓库状态。 **取值范围：** - 0，正常。 - 3，冻结。 - 4，关闭。 - 5，清理中。 - 7，删除中。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly StatusEnum NUMBER_3 = new StatusEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly StatusEnum NUMBER_4 = new StatusEnum(4);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly StatusEnum NUMBER_5 = new StatusEnum(5);

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly StatusEnum NUMBER_7 = new StatusEnum(7);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
                { 5, NUMBER_5 },
                { 7, NUMBER_7 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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

            public int? GetValue()
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
        /// **参数解释：** 结果集排序方式。 **约束限制：** 与sort_field搭配使用。  **取值范围：** - asc，正序返回。 - desc，倒序返回。
        /// </summary>
        /// <value>**参数解释：** 结果集排序方式。 **约束限制：** 与sort_field搭配使用。  **取值范围：** - asc，正序返回。 - desc，倒序返回。</value>
        [JsonConverter(typeof(EnumClassConverter<SortEnum>))]
        public class SortEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortEnum ASC = new SortEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortEnum DESC = new SortEnum("desc");

            private static readonly Dictionary<string, SortEnum> StaticFields =
            new Dictionary<string, SortEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortEnum()
            {

            }

            public SortEnum(string value)
            {
                _value = value;
            }

            public static SortEnum FromValue(string value)
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

                if (this.Equals(obj as SortEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortEnum a, SortEnum b)
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

            public static bool operator !=(SortEnum a, SortEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 用作排序的字段。 - owner，仓库所有者。 - capacity，使用空间。 - status，状态。 - create_time，创建时间。 - member_number，成员数量。 - repository_name，仓库名称。
        /// </summary>
        /// <value>**参数解释：** 用作排序的字段。 - owner，仓库所有者。 - capacity，使用空间。 - status，状态。 - create_time，创建时间。 - member_number，成员数量。 - repository_name，仓库名称。</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum OWNER for value: owner
            /// </summary>
            public static readonly SortFieldEnum OWNER = new SortFieldEnum("owner");

            /// <summary>
            /// Enum CAPACITY for value: capacity
            /// </summary>
            public static readonly SortFieldEnum CAPACITY = new SortFieldEnum("capacity");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly SortFieldEnum STATUS = new SortFieldEnum("status");

            /// <summary>
            /// Enum CREATE_TIME for value: create_time
            /// </summary>
            public static readonly SortFieldEnum CREATE_TIME = new SortFieldEnum("create_time");

            /// <summary>
            /// Enum MEMBER_NUMBER for value: member_number
            /// </summary>
            public static readonly SortFieldEnum MEMBER_NUMBER = new SortFieldEnum("member_number");

            /// <summary>
            /// Enum REPOSITORY_NAME for value: repository_name
            /// </summary>
            public static readonly SortFieldEnum REPOSITORY_NAME = new SortFieldEnum("repository_name");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "owner", OWNER },
                { "capacity", CAPACITY },
                { "status", STATUS },
                { "create_time", CREATE_TIME },
                { "member_number", MEMBER_NUMBER },
                { "repository_name", REPOSITORY_NAME },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库名称。 **取值范围：** 字符串长度不少于1，不超过128。
        /// </summary>
        [SDKProperty("repository_name", IsQuery = true)]
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// **参数解释：** 成员数量。
        /// </summary>
        [SDKProperty("member_number", IsQuery = true)]
        [JsonProperty("member_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberNumber { get; set; }

        /// <summary>
        /// **参数解释：** 仓库状态。 **取值范围：** - 0，正常。 - 3，冻结。 - 4，关闭。 - 5，清理中。 - 7，删除中。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释：** 仓库所有者。 **取值范围：** 字符串长度不少于1，不超过128。
        /// </summary>
        [SDKProperty("owner", IsQuery = true)]
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// **参数解释：** 筛选在该时间之后创建的仓库。
        /// </summary>
        [SDKProperty("created_after", IsQuery = true)]
        [JsonProperty("created_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 筛选在该时间之前创建的仓库。
        /// </summary>
        [SDKProperty("created_before", IsQuery = true)]
        [JsonProperty("created_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 结果集排序方式。 **约束限制：** 与sort_field搭配使用。  **取值范围：** - asc，正序返回。 - desc，倒序返回。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 用作排序的字段。 - owner，仓库所有者。 - capacity，使用空间。 - status，状态。 - create_time，创建时间。 - member_number，成员数量。 - repository_name，仓库名称。
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantRepositoriesRequest {\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  memberNumber: ").Append(MemberNumber).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  createdAfter: ").Append(CreatedAfter).Append("\n");
            sb.Append("  createdBefore: ").Append(CreatedBefore).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantRepositoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantRepositoriesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.MemberNumber != input.MemberNumber || (this.MemberNumber != null && !this.MemberNumber.Equals(input.MemberNumber))) return false;
            if (this.Status != input.Status) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.CreatedAfter != input.CreatedAfter || (this.CreatedAfter != null && !this.CreatedAfter.Equals(input.CreatedAfter))) return false;
            if (this.CreatedBefore != input.CreatedBefore || (this.CreatedBefore != null && !this.CreatedBefore.Equals(input.CreatedBefore))) return false;
            if (this.Sort != input.Sort) return false;
            if (this.SortField != input.SortField) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.MemberNumber != null) hashCode = hashCode * 59 + this.MemberNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.CreatedAfter != null) hashCode = hashCode * 59 + this.CreatedAfter.GetHashCode();
                if (this.CreatedBefore != null) hashCode = hashCode * 59 + this.CreatedBefore.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
