using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AwInstanceRes 
    {

        /// <summary>
        /// AW内容描述字段
        /// </summary>
        [JsonProperty("alias_runaw", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasRunaw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authentication_info", NullValueHandling = NullValueHandling.Ignore)]
        public AuthInfo AuthenticationInfo { get; set; }

        /// <summary>
        /// 认证类型,0-无认证;1-aksk认证
        /// </summary>
        [JsonProperty("authentication_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// 脚本模板描述信息，在用例更新时添加
        /// </summary>
        [JsonProperty("aw_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AwDescription { get; set; }

        /// <summary>
        /// aw id
        /// </summary>
        [JsonProperty("aw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AwId { get; set; }

        /// <summary>
        /// aw类型 0-setup;1-test;2-teardown
        /// </summary>
        [JsonProperty("aw_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AwType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic_aw", NullValueHandling = NullValueHandling.Ignore)]
        public BasicAwRes BasicAw { get; set; }

        /// <summary>
        /// instance的参数body体类型：form/text
        /// </summary>
        [JsonProperty("body_param_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyParamType { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [JsonProperty("by_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ByOrder { get; set; }

        /// <summary>
        /// change sign
        /// </summary>
        [JsonProperty("changeSign", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeSign { get; set; }

        /// <summary>
        /// 检查点List
        /// </summary>
        [JsonProperty("check_point_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckPoint> CheckPointList { get; set; }

        /// <summary>
        /// aw实例
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwInstanceRes> Children { get; set; }

        /// <summary>
        /// 条件语句
        /// </summary>
        [JsonProperty("condition_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionStatement { get; set; }

        /// <summary>
        /// 条件类型 0-not condition;1-if begin;2-if
        /// </summary>
        [JsonProperty("condition_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConditionType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// 创建时间字符串
        /// </summary>
        [JsonProperty("create_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeString { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 测试步骤自定义请求头List；后续自定义URL请求头不再使用该字段
        /// </summary>
        [JsonProperty("custom_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> CustomHeader { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 该aw是否来自外部工程 0-no;1-yes
        /// </summary>
        [JsonProperty("from_outside", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromOutside { get; set; }

        /// <summary>
        /// level
        /// </summary>
        [JsonProperty("hasLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? HasLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("header_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArrayNode> HeaderArray { get; set; }

        /// <summary>
        /// 值不为null表示老的IF判断语句；值为null表示新的IF判断语句
        /// </summary>
        [JsonProperty("his_script", NullValueHandling = NullValueHandling.Ignore)]
        public string HisScript { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否模板类型测试步骤 0：自定义URL配置类型；1：模板类型测试步骤
        /// </summary>
        [JsonProperty("is_basic", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsBasic { get; set; }

        /// <summary>
        /// 是否是契约AW 0-否；1-yes
        /// </summary>
        [JsonProperty("is_contract_aw", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsContractAw { get; set; }

        /// <summary>
        /// 是否被禁用 0-否；1-yes
        /// </summary>
        [JsonProperty("is_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDisabled { get; set; }

        /// <summary>
        /// 是否是安全测试aw
        /// </summary>
        [JsonProperty("is_sectest_aw", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsSectestAw { get; set; }

        /// <summary>
        /// 用例级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数依赖规则
        /// </summary>
        [JsonProperty("param_dependent", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamDependent { get; set; }

        /// <summary>
        /// 是否启用参数依赖
        /// </summary>
        [JsonProperty("param_dependent_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParamDependentEnabled { get; set; }

        /// <summary>
        /// 参数类型和参数值对应List
        /// </summary>
        [JsonProperty("param_type_and_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> ParamTypeAndValue { get; set; }

        /// <summary>
        /// awinstance所在的用例\\逻辑用例\\组合aw所属项目,该字段是新增字段,因此部分awinstance是无值的,所以只可写该值,而不能读取该值
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// awId层级关系
        /// </summary>
        [JsonProperty("relation", NullValueHandling = NullValueHandling.Ignore)]
        public string Relation { get; set; }

        /// <summary>
        /// relation id
        /// </summary>
        [JsonProperty("relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationId { get; set; }

        /// <summary>
        /// 映射类型 1-反向删除映射;2-用例自动添加的方向删除步骤
        /// </summary>
        [JsonProperty("relation_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelationType { get; set; }

        /// <summary>
        /// 重试间隔时间 (ms) 为空表示不等待
        /// </summary>
        [JsonProperty("retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryInterval { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [JsonProperty("retry_times", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryTimes { get; set; }

        /// <summary>
        /// 获取脚本生成时，要使用的步骤名称
        /// </summary>
        [JsonProperty("scriptName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// aw所来自工程的服务名和阶段名 fromOutside为1时该值有效
        /// </summary>
        [JsonProperty("service_and_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAndStage { get; set; }

        /// <summary>
        /// 测试步骤来源
        /// </summary>
        [JsonProperty("special_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpecialType { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("update_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeStamp { get; set; }

        /// <summary>
        /// 更新时间字符串
        /// </summary>
        [JsonProperty("update_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimeString { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("update_user", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUser { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 定义的变量信息
        /// </summary>
        [JsonProperty("variable_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> VariableList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AwInstanceRes {\n");
            sb.Append("  aliasRunaw: ").Append(AliasRunaw).Append("\n");
            sb.Append("  authenticationInfo: ").Append(AuthenticationInfo).Append("\n");
            sb.Append("  authenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  awDescription: ").Append(AwDescription).Append("\n");
            sb.Append("  awId: ").Append(AwId).Append("\n");
            sb.Append("  awType: ").Append(AwType).Append("\n");
            sb.Append("  basicAw: ").Append(BasicAw).Append("\n");
            sb.Append("  bodyParamType: ").Append(BodyParamType).Append("\n");
            sb.Append("  byOrder: ").Append(ByOrder).Append("\n");
            sb.Append("  changeSign: ").Append(ChangeSign).Append("\n");
            sb.Append("  checkPointList: ").Append(CheckPointList).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  conditionStatement: ").Append(ConditionStatement).Append("\n");
            sb.Append("  conditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  createTimeString: ").Append(CreateTimeString).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  customHeader: ").Append(CustomHeader).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  fromOutside: ").Append(FromOutside).Append("\n");
            sb.Append("  hasLevel: ").Append(HasLevel).Append("\n");
            sb.Append("  headerArray: ").Append(HeaderArray).Append("\n");
            sb.Append("  hisScript: ").Append(HisScript).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isBasic: ").Append(IsBasic).Append("\n");
            sb.Append("  isContractAw: ").Append(IsContractAw).Append("\n");
            sb.Append("  isDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  isSectestAw: ").Append(IsSectestAw).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  paramDependent: ").Append(ParamDependent).Append("\n");
            sb.Append("  paramDependentEnabled: ").Append(ParamDependentEnabled).Append("\n");
            sb.Append("  paramTypeAndValue: ").Append(ParamTypeAndValue).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  relation: ").Append(Relation).Append("\n");
            sb.Append("  relationId: ").Append(RelationId).Append("\n");
            sb.Append("  relationType: ").Append(RelationType).Append("\n");
            sb.Append("  retryInterval: ").Append(RetryInterval).Append("\n");
            sb.Append("  retryTimes: ").Append(RetryTimes).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  serviceAndStage: ").Append(ServiceAndStage).Append("\n");
            sb.Append("  specialType: ").Append(SpecialType).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  updateTimeString: ").Append(UpdateTimeString).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  variableList: ").Append(VariableList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AwInstanceRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AwInstanceRes input)
        {
            if (input == null) return false;
            if (this.AliasRunaw != input.AliasRunaw || (this.AliasRunaw != null && !this.AliasRunaw.Equals(input.AliasRunaw))) return false;
            if (this.AuthenticationInfo != input.AuthenticationInfo || (this.AuthenticationInfo != null && !this.AuthenticationInfo.Equals(input.AuthenticationInfo))) return false;
            if (this.AuthenticationType != input.AuthenticationType || (this.AuthenticationType != null && !this.AuthenticationType.Equals(input.AuthenticationType))) return false;
            if (this.AwDescription != input.AwDescription || (this.AwDescription != null && !this.AwDescription.Equals(input.AwDescription))) return false;
            if (this.AwId != input.AwId || (this.AwId != null && !this.AwId.Equals(input.AwId))) return false;
            if (this.AwType != input.AwType || (this.AwType != null && !this.AwType.Equals(input.AwType))) return false;
            if (this.BasicAw != input.BasicAw || (this.BasicAw != null && !this.BasicAw.Equals(input.BasicAw))) return false;
            if (this.BodyParamType != input.BodyParamType || (this.BodyParamType != null && !this.BodyParamType.Equals(input.BodyParamType))) return false;
            if (this.ByOrder != input.ByOrder || (this.ByOrder != null && !this.ByOrder.Equals(input.ByOrder))) return false;
            if (this.ChangeSign != input.ChangeSign || (this.ChangeSign != null && !this.ChangeSign.Equals(input.ChangeSign))) return false;
            if (this.CheckPointList != input.CheckPointList || (this.CheckPointList != null && input.CheckPointList != null && !this.CheckPointList.SequenceEqual(input.CheckPointList))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.ConditionStatement != input.ConditionStatement || (this.ConditionStatement != null && !this.ConditionStatement.Equals(input.ConditionStatement))) return false;
            if (this.ConditionType != input.ConditionType || (this.ConditionType != null && !this.ConditionType.Equals(input.ConditionType))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.CreateTimeString != input.CreateTimeString || (this.CreateTimeString != null && !this.CreateTimeString.Equals(input.CreateTimeString))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.CustomHeader != input.CustomHeader || (this.CustomHeader != null && input.CustomHeader != null && !this.CustomHeader.SequenceEqual(input.CustomHeader))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.FromOutside != input.FromOutside || (this.FromOutside != null && !this.FromOutside.Equals(input.FromOutside))) return false;
            if (this.HasLevel != input.HasLevel || (this.HasLevel != null && !this.HasLevel.Equals(input.HasLevel))) return false;
            if (this.HeaderArray != input.HeaderArray || (this.HeaderArray != null && input.HeaderArray != null && !this.HeaderArray.SequenceEqual(input.HeaderArray))) return false;
            if (this.HisScript != input.HisScript || (this.HisScript != null && !this.HisScript.Equals(input.HisScript))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsBasic != input.IsBasic || (this.IsBasic != null && !this.IsBasic.Equals(input.IsBasic))) return false;
            if (this.IsContractAw != input.IsContractAw || (this.IsContractAw != null && !this.IsContractAw.Equals(input.IsContractAw))) return false;
            if (this.IsDisabled != input.IsDisabled || (this.IsDisabled != null && !this.IsDisabled.Equals(input.IsDisabled))) return false;
            if (this.IsSectestAw != input.IsSectestAw || (this.IsSectestAw != null && !this.IsSectestAw.Equals(input.IsSectestAw))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParamDependent != input.ParamDependent || (this.ParamDependent != null && !this.ParamDependent.Equals(input.ParamDependent))) return false;
            if (this.ParamDependentEnabled != input.ParamDependentEnabled || (this.ParamDependentEnabled != null && !this.ParamDependentEnabled.Equals(input.ParamDependentEnabled))) return false;
            if (this.ParamTypeAndValue != input.ParamTypeAndValue || (this.ParamTypeAndValue != null && input.ParamTypeAndValue != null && !this.ParamTypeAndValue.SequenceEqual(input.ParamTypeAndValue))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Relation != input.Relation || (this.Relation != null && !this.Relation.Equals(input.Relation))) return false;
            if (this.RelationId != input.RelationId || (this.RelationId != null && !this.RelationId.Equals(input.RelationId))) return false;
            if (this.RelationType != input.RelationType || (this.RelationType != null && !this.RelationType.Equals(input.RelationType))) return false;
            if (this.RetryInterval != input.RetryInterval || (this.RetryInterval != null && !this.RetryInterval.Equals(input.RetryInterval))) return false;
            if (this.RetryTimes != input.RetryTimes || (this.RetryTimes != null && !this.RetryTimes.Equals(input.RetryTimes))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ServiceAndStage != input.ServiceAndStage || (this.ServiceAndStage != null && !this.ServiceAndStage.Equals(input.ServiceAndStage))) return false;
            if (this.SpecialType != input.SpecialType || (this.SpecialType != null && !this.SpecialType.Equals(input.SpecialType))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.UpdateTimeString != input.UpdateTimeString || (this.UpdateTimeString != null && !this.UpdateTimeString.Equals(input.UpdateTimeString))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.VariableList != input.VariableList || (this.VariableList != null && input.VariableList != null && !this.VariableList.SequenceEqual(input.VariableList))) return false;

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
                if (this.AliasRunaw != null) hashCode = hashCode * 59 + this.AliasRunaw.GetHashCode();
                if (this.AuthenticationInfo != null) hashCode = hashCode * 59 + this.AuthenticationInfo.GetHashCode();
                if (this.AuthenticationType != null) hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.AwDescription != null) hashCode = hashCode * 59 + this.AwDescription.GetHashCode();
                if (this.AwId != null) hashCode = hashCode * 59 + this.AwId.GetHashCode();
                if (this.AwType != null) hashCode = hashCode * 59 + this.AwType.GetHashCode();
                if (this.BasicAw != null) hashCode = hashCode * 59 + this.BasicAw.GetHashCode();
                if (this.BodyParamType != null) hashCode = hashCode * 59 + this.BodyParamType.GetHashCode();
                if (this.ByOrder != null) hashCode = hashCode * 59 + this.ByOrder.GetHashCode();
                if (this.ChangeSign != null) hashCode = hashCode * 59 + this.ChangeSign.GetHashCode();
                if (this.CheckPointList != null) hashCode = hashCode * 59 + this.CheckPointList.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.ConditionStatement != null) hashCode = hashCode * 59 + this.ConditionStatement.GetHashCode();
                if (this.ConditionType != null) hashCode = hashCode * 59 + this.ConditionType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.CreateTimeString != null) hashCode = hashCode * 59 + this.CreateTimeString.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.CustomHeader != null) hashCode = hashCode * 59 + this.CustomHeader.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.FromOutside != null) hashCode = hashCode * 59 + this.FromOutside.GetHashCode();
                if (this.HasLevel != null) hashCode = hashCode * 59 + this.HasLevel.GetHashCode();
                if (this.HeaderArray != null) hashCode = hashCode * 59 + this.HeaderArray.GetHashCode();
                if (this.HisScript != null) hashCode = hashCode * 59 + this.HisScript.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsBasic != null) hashCode = hashCode * 59 + this.IsBasic.GetHashCode();
                if (this.IsContractAw != null) hashCode = hashCode * 59 + this.IsContractAw.GetHashCode();
                if (this.IsDisabled != null) hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.IsSectestAw != null) hashCode = hashCode * 59 + this.IsSectestAw.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParamDependent != null) hashCode = hashCode * 59 + this.ParamDependent.GetHashCode();
                if (this.ParamDependentEnabled != null) hashCode = hashCode * 59 + this.ParamDependentEnabled.GetHashCode();
                if (this.ParamTypeAndValue != null) hashCode = hashCode * 59 + this.ParamTypeAndValue.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Relation != null) hashCode = hashCode * 59 + this.Relation.GetHashCode();
                if (this.RelationId != null) hashCode = hashCode * 59 + this.RelationId.GetHashCode();
                if (this.RelationType != null) hashCode = hashCode * 59 + this.RelationType.GetHashCode();
                if (this.RetryInterval != null) hashCode = hashCode * 59 + this.RetryInterval.GetHashCode();
                if (this.RetryTimes != null) hashCode = hashCode * 59 + this.RetryTimes.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ServiceAndStage != null) hashCode = hashCode * 59 + this.ServiceAndStage.GetHashCode();
                if (this.SpecialType != null) hashCode = hashCode * 59 + this.SpecialType.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.UpdateTimeString != null) hashCode = hashCode * 59 + this.UpdateTimeString.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.VariableList != null) hashCode = hashCode * 59 + this.VariableList.GetHashCode();
                return hashCode;
            }
        }
    }
}
