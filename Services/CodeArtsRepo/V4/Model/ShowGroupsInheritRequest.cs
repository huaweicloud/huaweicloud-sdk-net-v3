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
    public class ShowGroupsInheritRequest 
    {
        /// <summary>
        /// **参数解释：** 必填项，设置类型protected_branches保护分支 protected_tags保护tag push_rules推送规则 merge_requests合并请求 mr_branch_policies合并分支 reviews检视意见 e2e_settings e2e设置 webhook_settings hook设置 deploy_keys 部署key watermark水印 repository_settings仓库设置。
        /// </summary>
        /// <value>**参数解释：** 必填项，设置类型protected_branches保护分支 protected_tags保护tag push_rules推送规则 merge_requests合并请求 mr_branch_policies合并分支 reviews检视意见 e2e_settings e2e设置 webhook_settings hook设置 deploy_keys 部署key watermark水印 repository_settings仓库设置。</value>
        [JsonConverter(typeof(EnumClassConverter<SettingTypeEnum>))]
        public class SettingTypeEnum
        {
            /// <summary>
            /// Enum PROTECTED_BRANCHES for value: protected_branches
            /// </summary>
            public static readonly SettingTypeEnum PROTECTED_BRANCHES = new SettingTypeEnum("protected_branches");

            /// <summary>
            /// Enum PROTECTED_TAGS for value: protected_tags
            /// </summary>
            public static readonly SettingTypeEnum PROTECTED_TAGS = new SettingTypeEnum("protected_tags");

            /// <summary>
            /// Enum PUSH_RULES for value: push_rules
            /// </summary>
            public static readonly SettingTypeEnum PUSH_RULES = new SettingTypeEnum("push_rules");

            /// <summary>
            /// Enum MERGE_REQUESTS for value: merge_requests
            /// </summary>
            public static readonly SettingTypeEnum MERGE_REQUESTS = new SettingTypeEnum("merge_requests");

            /// <summary>
            /// Enum MR_BRANCH_POLICIES for value: mr_branch_policies
            /// </summary>
            public static readonly SettingTypeEnum MR_BRANCH_POLICIES = new SettingTypeEnum("mr_branch_policies");

            /// <summary>
            /// Enum REVIEWS for value: reviews
            /// </summary>
            public static readonly SettingTypeEnum REVIEWS = new SettingTypeEnum("reviews");

            /// <summary>
            /// Enum E2E_SETTINGS for value: e2e_settings
            /// </summary>
            public static readonly SettingTypeEnum E2E_SETTINGS = new SettingTypeEnum("e2e_settings");

            /// <summary>
            /// Enum WEBHOOK_SETTINGS for value: webhook_settings
            /// </summary>
            public static readonly SettingTypeEnum WEBHOOK_SETTINGS = new SettingTypeEnum("webhook_settings");

            /// <summary>
            /// Enum DEPLOY_KEYS for value: deploy_keys
            /// </summary>
            public static readonly SettingTypeEnum DEPLOY_KEYS = new SettingTypeEnum("deploy_keys");

            /// <summary>
            /// Enum WATERMARK for value: watermark
            /// </summary>
            public static readonly SettingTypeEnum WATERMARK = new SettingTypeEnum("watermark");

            /// <summary>
            /// Enum REPOSITORY_SETTINGS for value: repository_settings
            /// </summary>
            public static readonly SettingTypeEnum REPOSITORY_SETTINGS = new SettingTypeEnum("repository_settings");

            private static readonly Dictionary<string, SettingTypeEnum> StaticFields =
            new Dictionary<string, SettingTypeEnum>()
            {
                { "protected_branches", PROTECTED_BRANCHES },
                { "protected_tags", PROTECTED_TAGS },
                { "push_rules", PUSH_RULES },
                { "merge_requests", MERGE_REQUESTS },
                { "mr_branch_policies", MR_BRANCH_POLICIES },
                { "reviews", REVIEWS },
                { "e2e_settings", E2E_SETTINGS },
                { "webhook_settings", WEBHOOK_SETTINGS },
                { "deploy_keys", DEPLOY_KEYS },
                { "watermark", WATERMARK },
                { "repository_settings", REPOSITORY_SETTINGS },
            };

            private string _value;

            public SettingTypeEnum()
            {

            }

            public SettingTypeEnum(string value)
            {
                _value = value;
            }

            public static SettingTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SettingTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SettingTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SettingTypeEnum a, SettingTypeEnum b)
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

            public static bool operator !=(SettingTypeEnum a, SettingTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 代码组id，代码组首页，Group ID后的数字Id
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; }

        /// <summary>
        /// **参数解释：** 必填项，设置类型protected_branches保护分支 protected_tags保护tag push_rules推送规则 merge_requests合并请求 mr_branch_policies合并分支 reviews检视意见 e2e_settings e2e设置 webhook_settings hook设置 deploy_keys 部署key watermark水印 repository_settings仓库设置。
        /// </summary>
        [SDKProperty("setting_type", IsQuery = true)]
        [JsonProperty("setting_type", NullValueHandling = NullValueHandling.Ignore)]
        public SettingTypeEnum SettingType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupsInheritRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  settingType: ").Append(SettingType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupsInheritRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupsInheritRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.SettingType != input.SettingType) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                hashCode = hashCode * 59 + this.SettingType.GetHashCode();
                return hashCode;
            }
        }
    }
}
