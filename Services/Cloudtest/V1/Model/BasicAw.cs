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
    public class BasicAw 
    {

        /// <summary>
        /// aw代码, hasCode为1时有效
        /// </summary>
        [JsonProperty("aw_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AwCode { get; set; }

        /// <summary>
        /// 脚本模板描述信息，在用例更新时添加
        /// </summary>
        [JsonProperty("aw_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AwDescription { get; set; }

        /// <summary>
        /// 组合aw包含的aw实例信息，awType为2时该字段有效
        /// </summary>
        [JsonProperty("aw_ins_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwInstance> AwInsList { get; set; }

        /// <summary>
        /// aw标记 0-normal；1-new；2-update 3-delete
        /// </summary>
        [JsonProperty("aw_mark", NullValueHandling = NullValueHandling.Ignore)]
        public int? AwMark { get; set; }

        /// <summary>
        /// 接口的operationId
        /// </summary>
        [JsonProperty("aw_operationid", NullValueHandling = NullValueHandling.Ignore)]
        public string AwOperationid { get; set; }

        /// <summary>
        /// 接口的tags
        /// </summary>
        [JsonProperty("aw_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string AwTags { get; set; }

        /// <summary>
        /// AW类型1-普通aw,2-组合aw,3-导入aw
        /// </summary>
        [JsonProperty("aw_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AwType { get; set; }

        /// <summary>
        /// awOperationId_awTags的拼接
        /// </summary>
        [JsonProperty("aw_uniqueid", NullValueHandling = NullValueHandling.Ignore)]
        public string AwUniqueid { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [JsonProperty("by_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ByOrder { get; set; }

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
        /// 创建人id
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// aw库的文件列表
        /// </summary>
        [JsonProperty("custom_aw_libs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UploadFile> CustomAwLibs { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [JsonProperty("delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTime { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        [JsonProperty("delete_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteUser { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 默认检查点List
        /// </summary>
        [JsonProperty("dft_check_point_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckPoint> DftCheckPointList { get; set; }

        /// <summary>
        /// 默认请求头参数对象
        /// </summary>
        [JsonProperty("dft_custom_header", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> DftCustomHeader { get; set; }

        /// <summary>
        /// 重试间隔时间 (ms) 为空表示不等待
        /// </summary>
        [JsonProperty("dft_retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string DftRetryInterval { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [JsonProperty("dft_retry_times", NullValueHandling = NullValueHandling.Ignore)]
        public string DftRetryTimes { get; set; }

        /// <summary>
        /// 定义的变量信息
        /// </summary>
        [JsonProperty("dft_variable_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> DftVariableList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public JsonNode ExtraInfo { get; set; }

        /// <summary>
        /// 组名
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否自带代码 0-不自带代码，该aw依赖source字段中的源；1-自带代码
        /// </summary>
        [JsonProperty("has_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? HasCode { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 导入的包
        /// </summary>
        [JsonProperty("import_package", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImportPackage { get; set; }

        /// <summary>
        /// 接口的x-extend
        /// </summary>
        [JsonProperty("interface_label", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceLabel { get; set; }

        /// <summary>
        /// 是否是当前工程的收藏aw，该字段不存数据库，每次获取时实时判断
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsFavorite { get; set; }

        /// <summary>
        /// 关键字局部变量
        /// </summary>
        [JsonProperty("keyword_variable_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> KeywordVariableValue { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// aw在页面上显示的名字
        /// </summary>
        [JsonProperty("nameView", NullValueHandling = NullValueHandling.Ignore)]
        public string NameView { get; set; }

        /// <summary>
        /// 源工程信息，如果该aw是从其他工程过来的(继承或者copy to local)
        /// </summary>
        [JsonProperty("origin_project", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProject { get; set; }

        /// <summary>
        /// 组合aw的输出参数信息，该字段不存数据库，实时获取
        /// </summary>
        [JsonProperty("output_param_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> OutputParamList { get; set; }

        /// <summary>
        /// 参数类型和参数默认值对应List
        /// </summary>
        [JsonProperty("param_type_and_dft_value", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwParam> ParamTypeAndDftValue { get; set; }

        /// <summary>
        /// 工程ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 协议类型 (http/dsf/other)
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public_aw_lib", NullValueHandling = NullValueHandling.Ignore)]
        public PublicAwLib PublicAwLib { get; set; }

        /// <summary>
        /// 所属公共aw库Id
        /// </summary>
        [JsonProperty("public_aw_lib_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAwLibId { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 返回类型
        /// </summary>
        [JsonProperty("return_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnType { get; set; }

        /// <summary>
        /// root id
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 测试步骤来源
        /// </summary>
        [JsonProperty("special_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpecialType { get; set; }

        /// <summary>
        /// 关键字管理的用例编号
        /// </summary>
        [JsonProperty("tmssCaseNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssCaseNumber { get; set; }

        /// <summary>
        /// 关键字aw管理的用例ID
        /// </summary>
        [JsonProperty("tmss_case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssCaseId { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

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
        /// 警告信息
        /// </summary>
        [JsonProperty("warningMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string WarningMsg { get; set; }

        /// <summary>
        /// 所属yaml文件名称,该字段不存库，用来记录从哪个yaml文件导入
        /// </summary>
        [JsonProperty("yamlName", NullValueHandling = NullValueHandling.Ignore)]
        public string YamlName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicAw {\n");
            sb.Append("  awCode: ").Append(AwCode).Append("\n");
            sb.Append("  awDescription: ").Append(AwDescription).Append("\n");
            sb.Append("  awInsList: ").Append(AwInsList).Append("\n");
            sb.Append("  awMark: ").Append(AwMark).Append("\n");
            sb.Append("  awOperationid: ").Append(AwOperationid).Append("\n");
            sb.Append("  awTags: ").Append(AwTags).Append("\n");
            sb.Append("  awType: ").Append(AwType).Append("\n");
            sb.Append("  awUniqueid: ").Append(AwUniqueid).Append("\n");
            sb.Append("  byOrder: ").Append(ByOrder).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  createTimeString: ").Append(CreateTimeString).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  customAwLibs: ").Append(CustomAwLibs).Append("\n");
            sb.Append("  deleteTime: ").Append(DeleteTime).Append("\n");
            sb.Append("  deleteUser: ").Append(DeleteUser).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  dftCheckPointList: ").Append(DftCheckPointList).Append("\n");
            sb.Append("  dftCustomHeader: ").Append(DftCustomHeader).Append("\n");
            sb.Append("  dftRetryInterval: ").Append(DftRetryInterval).Append("\n");
            sb.Append("  dftRetryTimes: ").Append(DftRetryTimes).Append("\n");
            sb.Append("  dftVariableList: ").Append(DftVariableList).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  hasCode: ").Append(HasCode).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  importPackage: ").Append(ImportPackage).Append("\n");
            sb.Append("  interfaceLabel: ").Append(InterfaceLabel).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  keywordVariableValue: ").Append(KeywordVariableValue).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameView: ").Append(NameView).Append("\n");
            sb.Append("  originProject: ").Append(OriginProject).Append("\n");
            sb.Append("  outputParamList: ").Append(OutputParamList).Append("\n");
            sb.Append("  paramTypeAndDftValue: ").Append(ParamTypeAndDftValue).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  publicAwLib: ").Append(PublicAwLib).Append("\n");
            sb.Append("  publicAwLibId: ").Append(PublicAwLibId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  returnType: ").Append(ReturnType).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  specialType: ").Append(SpecialType).Append("\n");
            sb.Append("  tmssCaseNumber: ").Append(TmssCaseNumber).Append("\n");
            sb.Append("  tmssCaseId: ").Append(TmssCaseId).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  updateTimeString: ").Append(UpdateTimeString).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("  warningMsg: ").Append(WarningMsg).Append("\n");
            sb.Append("  yamlName: ").Append(YamlName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BasicAw);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasicAw input)
        {
            if (input == null) return false;
            if (this.AwCode != input.AwCode || (this.AwCode != null && !this.AwCode.Equals(input.AwCode))) return false;
            if (this.AwDescription != input.AwDescription || (this.AwDescription != null && !this.AwDescription.Equals(input.AwDescription))) return false;
            if (this.AwInsList != input.AwInsList || (this.AwInsList != null && input.AwInsList != null && !this.AwInsList.SequenceEqual(input.AwInsList))) return false;
            if (this.AwMark != input.AwMark || (this.AwMark != null && !this.AwMark.Equals(input.AwMark))) return false;
            if (this.AwOperationid != input.AwOperationid || (this.AwOperationid != null && !this.AwOperationid.Equals(input.AwOperationid))) return false;
            if (this.AwTags != input.AwTags || (this.AwTags != null && !this.AwTags.Equals(input.AwTags))) return false;
            if (this.AwType != input.AwType || (this.AwType != null && !this.AwType.Equals(input.AwType))) return false;
            if (this.AwUniqueid != input.AwUniqueid || (this.AwUniqueid != null && !this.AwUniqueid.Equals(input.AwUniqueid))) return false;
            if (this.ByOrder != input.ByOrder || (this.ByOrder != null && !this.ByOrder.Equals(input.ByOrder))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.CreateTimeString != input.CreateTimeString || (this.CreateTimeString != null && !this.CreateTimeString.Equals(input.CreateTimeString))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.CreateUserId != input.CreateUserId || (this.CreateUserId != null && !this.CreateUserId.Equals(input.CreateUserId))) return false;
            if (this.CustomAwLibs != input.CustomAwLibs || (this.CustomAwLibs != null && input.CustomAwLibs != null && !this.CustomAwLibs.SequenceEqual(input.CustomAwLibs))) return false;
            if (this.DeleteTime != input.DeleteTime || (this.DeleteTime != null && !this.DeleteTime.Equals(input.DeleteTime))) return false;
            if (this.DeleteUser != input.DeleteUser || (this.DeleteUser != null && !this.DeleteUser.Equals(input.DeleteUser))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DftCheckPointList != input.DftCheckPointList || (this.DftCheckPointList != null && input.DftCheckPointList != null && !this.DftCheckPointList.SequenceEqual(input.DftCheckPointList))) return false;
            if (this.DftCustomHeader != input.DftCustomHeader || (this.DftCustomHeader != null && input.DftCustomHeader != null && !this.DftCustomHeader.SequenceEqual(input.DftCustomHeader))) return false;
            if (this.DftRetryInterval != input.DftRetryInterval || (this.DftRetryInterval != null && !this.DftRetryInterval.Equals(input.DftRetryInterval))) return false;
            if (this.DftRetryTimes != input.DftRetryTimes || (this.DftRetryTimes != null && !this.DftRetryTimes.Equals(input.DftRetryTimes))) return false;
            if (this.DftVariableList != input.DftVariableList || (this.DftVariableList != null && input.DftVariableList != null && !this.DftVariableList.SequenceEqual(input.DftVariableList))) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.HasCode != input.HasCode || (this.HasCode != null && !this.HasCode.Equals(input.HasCode))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ImportPackage != input.ImportPackage || (this.ImportPackage != null && input.ImportPackage != null && !this.ImportPackage.SequenceEqual(input.ImportPackage))) return false;
            if (this.InterfaceLabel != input.InterfaceLabel || (this.InterfaceLabel != null && !this.InterfaceLabel.Equals(input.InterfaceLabel))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.KeywordVariableValue != input.KeywordVariableValue || (this.KeywordVariableValue != null && input.KeywordVariableValue != null && !this.KeywordVariableValue.SequenceEqual(input.KeywordVariableValue))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameView != input.NameView || (this.NameView != null && !this.NameView.Equals(input.NameView))) return false;
            if (this.OriginProject != input.OriginProject || (this.OriginProject != null && !this.OriginProject.Equals(input.OriginProject))) return false;
            if (this.OutputParamList != input.OutputParamList || (this.OutputParamList != null && input.OutputParamList != null && !this.OutputParamList.SequenceEqual(input.OutputParamList))) return false;
            if (this.ParamTypeAndDftValue != input.ParamTypeAndDftValue || (this.ParamTypeAndDftValue != null && input.ParamTypeAndDftValue != null && !this.ParamTypeAndDftValue.SequenceEqual(input.ParamTypeAndDftValue))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProtocolType != input.ProtocolType || (this.ProtocolType != null && !this.ProtocolType.Equals(input.ProtocolType))) return false;
            if (this.PublicAwLib != input.PublicAwLib || (this.PublicAwLib != null && !this.PublicAwLib.Equals(input.PublicAwLib))) return false;
            if (this.PublicAwLibId != input.PublicAwLibId || (this.PublicAwLibId != null && !this.PublicAwLibId.Equals(input.PublicAwLibId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ReturnType != input.ReturnType || (this.ReturnType != null && !this.ReturnType.Equals(input.ReturnType))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SpecialType != input.SpecialType || (this.SpecialType != null && !this.SpecialType.Equals(input.SpecialType))) return false;
            if (this.TmssCaseNumber != input.TmssCaseNumber || (this.TmssCaseNumber != null && !this.TmssCaseNumber.Equals(input.TmssCaseNumber))) return false;
            if (this.TmssCaseId != input.TmssCaseId || (this.TmssCaseId != null && !this.TmssCaseId.Equals(input.TmssCaseId))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.UpdateTimeString != input.UpdateTimeString || (this.UpdateTimeString != null && !this.UpdateTimeString.Equals(input.UpdateTimeString))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;
            if (this.WarningMsg != input.WarningMsg || (this.WarningMsg != null && !this.WarningMsg.Equals(input.WarningMsg))) return false;
            if (this.YamlName != input.YamlName || (this.YamlName != null && !this.YamlName.Equals(input.YamlName))) return false;

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
                if (this.AwCode != null) hashCode = hashCode * 59 + this.AwCode.GetHashCode();
                if (this.AwDescription != null) hashCode = hashCode * 59 + this.AwDescription.GetHashCode();
                if (this.AwInsList != null) hashCode = hashCode * 59 + this.AwInsList.GetHashCode();
                if (this.AwMark != null) hashCode = hashCode * 59 + this.AwMark.GetHashCode();
                if (this.AwOperationid != null) hashCode = hashCode * 59 + this.AwOperationid.GetHashCode();
                if (this.AwTags != null) hashCode = hashCode * 59 + this.AwTags.GetHashCode();
                if (this.AwType != null) hashCode = hashCode * 59 + this.AwType.GetHashCode();
                if (this.AwUniqueid != null) hashCode = hashCode * 59 + this.AwUniqueid.GetHashCode();
                if (this.ByOrder != null) hashCode = hashCode * 59 + this.ByOrder.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.CreateTimeString != null) hashCode = hashCode * 59 + this.CreateTimeString.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.CreateUserId != null) hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.CustomAwLibs != null) hashCode = hashCode * 59 + this.CustomAwLibs.GetHashCode();
                if (this.DeleteTime != null) hashCode = hashCode * 59 + this.DeleteTime.GetHashCode();
                if (this.DeleteUser != null) hashCode = hashCode * 59 + this.DeleteUser.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DftCheckPointList != null) hashCode = hashCode * 59 + this.DftCheckPointList.GetHashCode();
                if (this.DftCustomHeader != null) hashCode = hashCode * 59 + this.DftCustomHeader.GetHashCode();
                if (this.DftRetryInterval != null) hashCode = hashCode * 59 + this.DftRetryInterval.GetHashCode();
                if (this.DftRetryTimes != null) hashCode = hashCode * 59 + this.DftRetryTimes.GetHashCode();
                if (this.DftVariableList != null) hashCode = hashCode * 59 + this.DftVariableList.GetHashCode();
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.HasCode != null) hashCode = hashCode * 59 + this.HasCode.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImportPackage != null) hashCode = hashCode * 59 + this.ImportPackage.GetHashCode();
                if (this.InterfaceLabel != null) hashCode = hashCode * 59 + this.InterfaceLabel.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.KeywordVariableValue != null) hashCode = hashCode * 59 + this.KeywordVariableValue.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameView != null) hashCode = hashCode * 59 + this.NameView.GetHashCode();
                if (this.OriginProject != null) hashCode = hashCode * 59 + this.OriginProject.GetHashCode();
                if (this.OutputParamList != null) hashCode = hashCode * 59 + this.OutputParamList.GetHashCode();
                if (this.ParamTypeAndDftValue != null) hashCode = hashCode * 59 + this.ParamTypeAndDftValue.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProtocolType != null) hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.PublicAwLib != null) hashCode = hashCode * 59 + this.PublicAwLib.GetHashCode();
                if (this.PublicAwLibId != null) hashCode = hashCode * 59 + this.PublicAwLibId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ReturnType != null) hashCode = hashCode * 59 + this.ReturnType.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SpecialType != null) hashCode = hashCode * 59 + this.SpecialType.GetHashCode();
                if (this.TmssCaseNumber != null) hashCode = hashCode * 59 + this.TmssCaseNumber.GetHashCode();
                if (this.TmssCaseId != null) hashCode = hashCode * 59 + this.TmssCaseId.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.UpdateTimeString != null) hashCode = hashCode * 59 + this.UpdateTimeString.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                if (this.WarningMsg != null) hashCode = hashCode * 59 + this.WarningMsg.GetHashCode();
                if (this.YamlName != null) hashCode = hashCode * 59 + this.YamlName.GetHashCode();
                return hashCode;
            }
        }
    }
}
