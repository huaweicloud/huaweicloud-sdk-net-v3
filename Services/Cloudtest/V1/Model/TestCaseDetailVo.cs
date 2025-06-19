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
    public class TestCaseDetailVo 
    {

        /// <summary>
        /// 资源URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// 前置条件
        /// </summary>
        [JsonProperty("preparation", NullValueHandling = NullValueHandling.Ignore)]
        public string Preparation { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 测试阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 测试类型
        /// </summary>
        [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
        public string Activity { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public string Keywords { get; set; }

        /// <summary>
        /// apitest标记是否代码已提交
        /// </summary>
        [JsonProperty("market", NullValueHandling = NullValueHandling.Ignore)]
        public string Market { get; set; }

        /// <summary>
        /// 设计者
        /// </summary>
        [JsonProperty("designer", NullValueHandling = NullValueHandling.Ignore)]
        public string Designer { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 执行参数
        /// </summary>
        [JsonProperty("execute_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteParameter { get; set; }

        /// <summary>
        /// 逻辑region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 处理人id，IteratorTestCase字段
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleIssueVo Issue { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonProperty("last_modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifier { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("last_modified_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// 最后变更时间
        /// </summary>
        [JsonProperty("last_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastChangeTime { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 源资源URI
        /// </summary>
        [JsonProperty("origin_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUri { get; set; }

        /// <summary>
        /// 父资源URI
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 父资源路径
        /// </summary>
        [JsonProperty("parent_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentPath { get; set; }

        /// <summary>
        /// 创建版本URI
        /// </summary>
        [JsonProperty("creation_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationVersionUri { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("creation_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDateTimestamp { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [JsonProperty("case_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 执行平台类型
        /// </summary>
        [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlatformType { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 服务类型名称
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 测试类型
        /// </summary>
        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        /// <summary>
        /// 测试类型名称
        /// </summary>
        [JsonProperty("test_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTypeName { get; set; }

        /// <summary>
        /// 设计描述
        /// </summary>
        [JsonProperty("design_note", NullValueHandling = NullValueHandling.Ignore)]
        public string DesignNote { get; set; }

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("test_step", NullValueHandling = NullValueHandling.Ignore)]
        public string TestStep { get; set; }

        /// <summary>
        /// 期望结果
        /// </summary>
        [JsonProperty("expect_output", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectOutput { get; set; }

        /// <summary>
        /// 测试环境类型
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvType { get; set; }

        /// <summary>
        /// 执行平台
        /// </summary>
        [JsonProperty("exe_platform", NullValueHandling = NullValueHandling.Ignore)]
        public string ExePlatform { get; set; }

        /// <summary>
        /// 测试工程
        /// </summary>
        [JsonProperty("testcase_project", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseProject { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("svn_script_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SvnScriptPath { get; set; }

        /// <summary>
        /// 约束条件
        /// </summary>
        [JsonProperty("map_restrict", NullValueHandling = NullValueHandling.Ignore)]
        public string MapRestrict { get; set; }

        /// <summary>
        /// 网络脚本名
        /// </summary>
        [JsonProperty("network_script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkScriptName { get; set; }

        /// <summary>
        /// 自动化类型，非自动化:0, 是自动化:1
        /// </summary>
        [JsonProperty("auto_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoType { get; set; }

        /// <summary>
        /// 被自动化执行
        /// </summary>
        [JsonProperty("to_be_auto_exec", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToBeAutoExec { get; set; }

        /// <summary>
        /// 最后一次结果
        /// </summary>
        [JsonProperty("last_result", NullValueHandling = NullValueHandling.Ignore)]
        public string LastResult { get; set; }

        /// <summary>
        /// 最后一次结果Uri
        /// </summary>
        [JsonProperty("last_result_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string LastResultUri { get; set; }

        /// <summary>
        /// 目录Uri
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

        /// <summary>
        /// 目录名称
        /// </summary>
        [JsonProperty("feature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureName { get; set; }

        /// <summary>
        /// 测试接口名
        /// </summary>
        [JsonProperty("interface_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 网络问题ID
        /// </summary>
        [JsonProperty("snp_no", NullValueHandling = NullValueHandling.Ignore)]
        public string SnpNo { get; set; }

        /// <summary>
        /// 关联需求编号
        /// </summary>
        [JsonProperty("dr_relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DrRelationId { get; set; }

        /// <summary>
        /// 需求名称
        /// </summary>
        [JsonProperty("issue_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueName { get; set; }

        /// <summary>
        /// 测试基数
        /// </summary>
        [JsonProperty("test_base_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TestBaseNum { get; set; }

        /// <summary>
        /// 是否被自动化执行
        /// </summary>
        [JsonProperty("automatically_executed", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomaticallyExecuted { get; set; }

        /// <summary>
        /// 第一次执行时间
        /// </summary>
        [JsonProperty("first_execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstExecuteTime { get; set; }

        /// <summary>
        /// 检测类型
        /// </summary>
        [JsonProperty("detect_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DetectType { get; set; }

        /// <summary>
        /// 执行参数
        /// </summary>
        [JsonProperty("execute_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteParam { get; set; }

        /// <summary>
        /// 分析领域
        /// </summary>
        [JsonProperty("test_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string TestFeature { get; set; }

        /// <summary>
        /// 是否是契约用例，0:表示非契约用例, 1：表示契约用例
        /// </summary>
        [JsonProperty("is_contract_testcase", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsContractTestcase { get; set; }

        /// <summary>
        /// 总共耗时
        /// </summary>
        [JsonProperty("time_cost", NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeCost { get; set; }

        /// <summary>
        /// 记录用例由非自动化变为自动化类型的时间
        /// </summary>
        [JsonProperty("be_auto_type_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeAutoTypeTime { get; set; }

        /// <summary>
        /// 配对用例编号
        /// </summary>
        [JsonProperty("compare_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareNumber { get; set; }

        /// <summary>
        /// 场景标识
        /// </summary>
        [JsonProperty("scene_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneFlag { get; set; }

        /// <summary>
        /// 场景标识
        /// </summary>
        [JsonProperty("base_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseFlag { get; set; }

        /// <summary>
        /// 区别是否从yaml中生成的用例，默认false
        /// </summary>
        [JsonProperty("para_validator", NullValueHandling = NullValueHandling.Ignore)]
        public string ParaValidator { get; set; }

        /// <summary>
        /// knet节点id
        /// </summary>
        [JsonProperty("knet_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnetNodeId { get; set; }

        /// <summary>
        /// 最后一次执行用户
        /// </summary>
        [JsonProperty("last_exe_author", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExeAuthor { get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        [JsonProperty("cloud_carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudCarrier { get; set; }

        /// <summary>
        /// 应用市场
        /// </summary>
        [JsonProperty("market_place", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketPlace { get; set; }

        /// <summary>
        /// 脑图id
        /// </summary>
        [JsonProperty("test_mind_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestMindId { get; set; }

        /// <summary>
        /// 脑图url
        /// </summary>
        [JsonProperty("test_mind_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TestMindUrl { get; set; }

        /// <summary>
        /// git提交url
        /// </summary>
        [JsonProperty("commit_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitUrl { get; set; }

        /// <summary>
        /// 测试模式编号
        /// </summary>
        [JsonProperty("test_pattern_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestPatternNumber { get; set; }

        /// <summary>
        /// 测试因子编号
        /// </summary>
        [JsonProperty("test_factor_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestFactorNumber { get; set; }

        /// <summary>
        /// 状态Code
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCode { get; set; }

        /// <summary>
        /// 结果Code
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("release_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseId { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("label_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelId { get; set; }

        /// <summary>
        /// 用例标签名称列表
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelVo> Labels { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块path
        /// </summary>
        [JsonProperty("module_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePath { get; set; }

        /// <summary>
        /// 模块路径名称
        /// </summary>
        [JsonProperty("module_path_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePathName { get; set; }

        /// <summary>
        /// 最后执行时间
        /// </summary>
        [JsonProperty("execute_latest_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExecuteLatestTime { get; set; }

        /// <summary>
        /// 执行时长
        /// </summary>
        [JsonProperty("execute_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteDuration { get; set; }

        /// <summary>
        /// 执行次数
        /// </summary>
        [JsonProperty("execute_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteTimes { get; set; }

        /// <summary>
        /// 是否关键用例
        /// </summary>
        [JsonProperty("is_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsKeyword { get; set; }

        /// <summary>
        /// 测试版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 是否用户新增用例
        /// </summary>
        [JsonProperty("new_created", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCreated { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 创建版本名称，原逻辑marshall添加字段
        /// </summary>
        [JsonProperty("creation_version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationVersionName { get; set; }

        /// <summary>
        /// 特性路径，原逻辑marshall添加字段
        /// </summary>
        [JsonProperty("feature_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FeaturePath { get; set; }

        /// <summary>
        /// 实体用例Uri，IteratorTestCase字段
        /// </summary>
        [JsonProperty("testcase_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseUri { get; set; }

        /// <summary>
        /// 处理人名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 迭代用例Uri，IteratorTestCase字段
        /// </summary>
        [JsonProperty("iterator_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorCaseUri { get; set; }

        /// <summary>
        /// 脚本链接scriptLink
        /// </summary>
        [JsonProperty("script_link", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptLink { get; set; }

        /// <summary>
        /// 自定义字段1
        /// </summary>
        [JsonProperty("custom_field_1", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField1 { get; set; }

        /// <summary>
        /// 自定义字段2
        /// </summary>
        [JsonProperty("custom_field_2", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField2 { get; set; }

        /// <summary>
        /// 自定义字段3
        /// </summary>
        [JsonProperty("custom_field_3", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField3 { get; set; }

        /// <summary>
        /// 自定义字段4
        /// </summary>
        [JsonProperty("custom_field_4", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField4 { get; set; }

        /// <summary>
        /// 自定义字段5
        /// </summary>
        [JsonProperty("custom_field_5", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField5 { get; set; }

        /// <summary>
        /// 自定义字段6
        /// </summary>
        [JsonProperty("custom_field_6", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField6 { get; set; }

        /// <summary>
        /// 自定义字段7
        /// </summary>
        [JsonProperty("custom_field_7", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField7 { get; set; }

        /// <summary>
        /// 自定义字段8
        /// </summary>
        [JsonProperty("custom_field_8", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField8 { get; set; }

        /// <summary>
        /// 自定义字段9
        /// </summary>
        [JsonProperty("custom_field_9", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField9 { get; set; }

        /// <summary>
        /// 自定义字段10
        /// </summary>
        [JsonProperty("custom_field_10", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField10 { get; set; }

        /// <summary>
        /// 自定义字段11
        /// </summary>
        [JsonProperty("custom_field_11", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField11 { get; set; }

        /// <summary>
        /// 自定义字段12
        /// </summary>
        [JsonProperty("custom_field_12", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField12 { get; set; }

        /// <summary>
        /// 自定义字段13
        /// </summary>
        [JsonProperty("custom_field_13", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField13 { get; set; }

        /// <summary>
        /// 自定义字段14
        /// </summary>
        [JsonProperty("custom_field_14", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField14 { get; set; }

        /// <summary>
        /// 自定义字段15
        /// </summary>
        [JsonProperty("custom_field_15", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField15 { get; set; }

        /// <summary>
        /// 自定义字段16
        /// </summary>
        [JsonProperty("custom_field_16", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField16 { get; set; }

        /// <summary>
        /// 自定义字段17
        /// </summary>
        [JsonProperty("custom_field_17", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField17 { get; set; }

        /// <summary>
        /// 自定义字段18
        /// </summary>
        [JsonProperty("custom_field_18", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField18 { get; set; }

        /// <summary>
        /// 自定义字段19
        /// </summary>
        [JsonProperty("custom_field_19", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField19 { get; set; }

        /// <summary>
        /// 自定义字段20
        /// </summary>
        [JsonProperty("custom_field_20", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField20 { get; set; }

        /// <summary>
        /// 自定义字段21
        /// </summary>
        [JsonProperty("custom_field_21", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField21 { get; set; }

        /// <summary>
        /// 自定义字段22
        /// </summary>
        [JsonProperty("custom_field_22", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField22 { get; set; }

        /// <summary>
        /// 自定义字段23
        /// </summary>
        [JsonProperty("custom_field_23", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField23 { get; set; }

        /// <summary>
        /// 自定义字段24
        /// </summary>
        [JsonProperty("custom_field_24", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField24 { get; set; }

        /// <summary>
        /// 自定义字段25
        /// </summary>
        [JsonProperty("custom_field_25", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField25 { get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [JsonProperty("last_modifier_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifierName { get; set; }

        /// <summary>
        /// 迭代
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseStepVo> Steps { get; set; }

        /// <summary>
        /// 是否关联缺陷
        /// </summary>
        [JsonProperty("associate_defect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociateDefect { get; set; }

        /// <summary>
        /// 是否关联需求
        /// </summary>
        [JsonProperty("associate_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociateIssue { get; set; }

        /// <summary>
        /// 缺陷关联信息
        /// </summary>
        [JsonProperty("defect_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndIdVo> DefectList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseDetailVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  preparation: ").Append(Preparation).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  activity: ").Append(Activity).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  market: ").Append(Market).Append("\n");
            sb.Append("  designer: ").Append(Designer).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  executeParameter: ").Append(ExecuteParameter).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  issue: ").Append(Issue).Append("\n");
            sb.Append("  lastModifier: ").Append(LastModifier).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  lastModifiedTimestamp: ").Append(LastModifiedTimestamp).Append("\n");
            sb.Append("  lastChangeTime: ").Append(LastChangeTime).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  originUri: ").Append(OriginUri).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  parentPath: ").Append(ParentPath).Append("\n");
            sb.Append("  creationVersionUri: ").Append(CreationVersionUri).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  creationDateTimestamp: ").Append(CreationDateTimestamp).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  platformType: ").Append(PlatformType).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  testType: ").Append(TestType).Append("\n");
            sb.Append("  testTypeName: ").Append(TestTypeName).Append("\n");
            sb.Append("  designNote: ").Append(DesignNote).Append("\n");
            sb.Append("  testStep: ").Append(TestStep).Append("\n");
            sb.Append("  expectOutput: ").Append(ExpectOutput).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  exePlatform: ").Append(ExePlatform).Append("\n");
            sb.Append("  testcaseProject: ").Append(TestcaseProject).Append("\n");
            sb.Append("  svnScriptPath: ").Append(SvnScriptPath).Append("\n");
            sb.Append("  mapRestrict: ").Append(MapRestrict).Append("\n");
            sb.Append("  networkScriptName: ").Append(NetworkScriptName).Append("\n");
            sb.Append("  autoType: ").Append(AutoType).Append("\n");
            sb.Append("  toBeAutoExec: ").Append(ToBeAutoExec).Append("\n");
            sb.Append("  lastResult: ").Append(LastResult).Append("\n");
            sb.Append("  lastResultUri: ").Append(LastResultUri).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  featureName: ").Append(FeatureName).Append("\n");
            sb.Append("  interfaceName: ").Append(InterfaceName).Append("\n");
            sb.Append("  snpNo: ").Append(SnpNo).Append("\n");
            sb.Append("  drRelationId: ").Append(DrRelationId).Append("\n");
            sb.Append("  issueName: ").Append(IssueName).Append("\n");
            sb.Append("  testBaseNum: ").Append(TestBaseNum).Append("\n");
            sb.Append("  automaticallyExecuted: ").Append(AutomaticallyExecuted).Append("\n");
            sb.Append("  firstExecuteTime: ").Append(FirstExecuteTime).Append("\n");
            sb.Append("  detectType: ").Append(DetectType).Append("\n");
            sb.Append("  executeParam: ").Append(ExecuteParam).Append("\n");
            sb.Append("  testFeature: ").Append(TestFeature).Append("\n");
            sb.Append("  isContractTestcase: ").Append(IsContractTestcase).Append("\n");
            sb.Append("  timeCost: ").Append(TimeCost).Append("\n");
            sb.Append("  beAutoTypeTime: ").Append(BeAutoTypeTime).Append("\n");
            sb.Append("  compareNumber: ").Append(CompareNumber).Append("\n");
            sb.Append("  sceneFlag: ").Append(SceneFlag).Append("\n");
            sb.Append("  baseFlag: ").Append(BaseFlag).Append("\n");
            sb.Append("  paraValidator: ").Append(ParaValidator).Append("\n");
            sb.Append("  knetNodeId: ").Append(KnetNodeId).Append("\n");
            sb.Append("  lastExeAuthor: ").Append(LastExeAuthor).Append("\n");
            sb.Append("  cloudCarrier: ").Append(CloudCarrier).Append("\n");
            sb.Append("  marketPlace: ").Append(MarketPlace).Append("\n");
            sb.Append("  testMindId: ").Append(TestMindId).Append("\n");
            sb.Append("  testMindUrl: ").Append(TestMindUrl).Append("\n");
            sb.Append("  commitUrl: ").Append(CommitUrl).Append("\n");
            sb.Append("  testPatternNumber: ").Append(TestPatternNumber).Append("\n");
            sb.Append("  testFactorNumber: ").Append(TestFactorNumber).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  labelId: ").Append(LabelId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  modulePath: ").Append(ModulePath).Append("\n");
            sb.Append("  modulePathName: ").Append(ModulePathName).Append("\n");
            sb.Append("  executeLatestTime: ").Append(ExecuteLatestTime).Append("\n");
            sb.Append("  executeDuration: ").Append(ExecuteDuration).Append("\n");
            sb.Append("  executeTimes: ").Append(ExecuteTimes).Append("\n");
            sb.Append("  isKeyword: ").Append(IsKeyword).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  newCreated: ").Append(NewCreated).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  creationVersionName: ").Append(CreationVersionName).Append("\n");
            sb.Append("  featurePath: ").Append(FeaturePath).Append("\n");
            sb.Append("  testcaseUri: ").Append(TestcaseUri).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  iteratorCaseUri: ").Append(IteratorCaseUri).Append("\n");
            sb.Append("  scriptLink: ").Append(ScriptLink).Append("\n");
            sb.Append("  customField1: ").Append(CustomField1).Append("\n");
            sb.Append("  customField2: ").Append(CustomField2).Append("\n");
            sb.Append("  customField3: ").Append(CustomField3).Append("\n");
            sb.Append("  customField4: ").Append(CustomField4).Append("\n");
            sb.Append("  customField5: ").Append(CustomField5).Append("\n");
            sb.Append("  customField6: ").Append(CustomField6).Append("\n");
            sb.Append("  customField7: ").Append(CustomField7).Append("\n");
            sb.Append("  customField8: ").Append(CustomField8).Append("\n");
            sb.Append("  customField9: ").Append(CustomField9).Append("\n");
            sb.Append("  customField10: ").Append(CustomField10).Append("\n");
            sb.Append("  customField11: ").Append(CustomField11).Append("\n");
            sb.Append("  customField12: ").Append(CustomField12).Append("\n");
            sb.Append("  customField13: ").Append(CustomField13).Append("\n");
            sb.Append("  customField14: ").Append(CustomField14).Append("\n");
            sb.Append("  customField15: ").Append(CustomField15).Append("\n");
            sb.Append("  customField16: ").Append(CustomField16).Append("\n");
            sb.Append("  customField17: ").Append(CustomField17).Append("\n");
            sb.Append("  customField18: ").Append(CustomField18).Append("\n");
            sb.Append("  customField19: ").Append(CustomField19).Append("\n");
            sb.Append("  customField20: ").Append(CustomField20).Append("\n");
            sb.Append("  customField21: ").Append(CustomField21).Append("\n");
            sb.Append("  customField22: ").Append(CustomField22).Append("\n");
            sb.Append("  customField23: ").Append(CustomField23).Append("\n");
            sb.Append("  customField24: ").Append(CustomField24).Append("\n");
            sb.Append("  customField25: ").Append(CustomField25).Append("\n");
            sb.Append("  lastModifierName: ").Append(LastModifierName).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  associateDefect: ").Append(AssociateDefect).Append("\n");
            sb.Append("  associateIssue: ").Append(AssociateIssue).Append("\n");
            sb.Append("  defectList: ").Append(DefectList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseDetailVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseDetailVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.Preparation != input.Preparation || (this.Preparation != null && !this.Preparation.Equals(input.Preparation))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Activity != input.Activity || (this.Activity != null && !this.Activity.Equals(input.Activity))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && !this.Keywords.Equals(input.Keywords))) return false;
            if (this.Market != input.Market || (this.Market != null && !this.Market.Equals(input.Market))) return false;
            if (this.Designer != input.Designer || (this.Designer != null && !this.Designer.Equals(input.Designer))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.ExecuteParameter != input.ExecuteParameter || (this.ExecuteParameter != null && !this.ExecuteParameter.Equals(input.ExecuteParameter))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Issue != input.Issue || (this.Issue != null && !this.Issue.Equals(input.Issue))) return false;
            if (this.LastModifier != input.LastModifier || (this.LastModifier != null && !this.LastModifier.Equals(input.LastModifier))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.LastModifiedTimestamp != input.LastModifiedTimestamp || (this.LastModifiedTimestamp != null && !this.LastModifiedTimestamp.Equals(input.LastModifiedTimestamp))) return false;
            if (this.LastChangeTime != input.LastChangeTime || (this.LastChangeTime != null && !this.LastChangeTime.Equals(input.LastChangeTime))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.OriginUri != input.OriginUri || (this.OriginUri != null && !this.OriginUri.Equals(input.OriginUri))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.ParentPath != input.ParentPath || (this.ParentPath != null && !this.ParentPath.Equals(input.ParentPath))) return false;
            if (this.CreationVersionUri != input.CreationVersionUri || (this.CreationVersionUri != null && !this.CreationVersionUri.Equals(input.CreationVersionUri))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreationDateTimestamp != input.CreationDateTimestamp || (this.CreationDateTimestamp != null && !this.CreationDateTimestamp.Equals(input.CreationDateTimestamp))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.PlatformType != input.PlatformType || (this.PlatformType != null && !this.PlatformType.Equals(input.PlatformType))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.TestType != input.TestType || (this.TestType != null && !this.TestType.Equals(input.TestType))) return false;
            if (this.TestTypeName != input.TestTypeName || (this.TestTypeName != null && !this.TestTypeName.Equals(input.TestTypeName))) return false;
            if (this.DesignNote != input.DesignNote || (this.DesignNote != null && !this.DesignNote.Equals(input.DesignNote))) return false;
            if (this.TestStep != input.TestStep || (this.TestStep != null && !this.TestStep.Equals(input.TestStep))) return false;
            if (this.ExpectOutput != input.ExpectOutput || (this.ExpectOutput != null && !this.ExpectOutput.Equals(input.ExpectOutput))) return false;
            if (this.EnvType != input.EnvType || (this.EnvType != null && !this.EnvType.Equals(input.EnvType))) return false;
            if (this.ExePlatform != input.ExePlatform || (this.ExePlatform != null && !this.ExePlatform.Equals(input.ExePlatform))) return false;
            if (this.TestcaseProject != input.TestcaseProject || (this.TestcaseProject != null && !this.TestcaseProject.Equals(input.TestcaseProject))) return false;
            if (this.SvnScriptPath != input.SvnScriptPath || (this.SvnScriptPath != null && !this.SvnScriptPath.Equals(input.SvnScriptPath))) return false;
            if (this.MapRestrict != input.MapRestrict || (this.MapRestrict != null && !this.MapRestrict.Equals(input.MapRestrict))) return false;
            if (this.NetworkScriptName != input.NetworkScriptName || (this.NetworkScriptName != null && !this.NetworkScriptName.Equals(input.NetworkScriptName))) return false;
            if (this.AutoType != input.AutoType || (this.AutoType != null && !this.AutoType.Equals(input.AutoType))) return false;
            if (this.ToBeAutoExec != input.ToBeAutoExec || (this.ToBeAutoExec != null && !this.ToBeAutoExec.Equals(input.ToBeAutoExec))) return false;
            if (this.LastResult != input.LastResult || (this.LastResult != null && !this.LastResult.Equals(input.LastResult))) return false;
            if (this.LastResultUri != input.LastResultUri || (this.LastResultUri != null && !this.LastResultUri.Equals(input.LastResultUri))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.FeatureName != input.FeatureName || (this.FeatureName != null && !this.FeatureName.Equals(input.FeatureName))) return false;
            if (this.InterfaceName != input.InterfaceName || (this.InterfaceName != null && !this.InterfaceName.Equals(input.InterfaceName))) return false;
            if (this.SnpNo != input.SnpNo || (this.SnpNo != null && !this.SnpNo.Equals(input.SnpNo))) return false;
            if (this.DrRelationId != input.DrRelationId || (this.DrRelationId != null && !this.DrRelationId.Equals(input.DrRelationId))) return false;
            if (this.IssueName != input.IssueName || (this.IssueName != null && !this.IssueName.Equals(input.IssueName))) return false;
            if (this.TestBaseNum != input.TestBaseNum || (this.TestBaseNum != null && !this.TestBaseNum.Equals(input.TestBaseNum))) return false;
            if (this.AutomaticallyExecuted != input.AutomaticallyExecuted || (this.AutomaticallyExecuted != null && !this.AutomaticallyExecuted.Equals(input.AutomaticallyExecuted))) return false;
            if (this.FirstExecuteTime != input.FirstExecuteTime || (this.FirstExecuteTime != null && !this.FirstExecuteTime.Equals(input.FirstExecuteTime))) return false;
            if (this.DetectType != input.DetectType || (this.DetectType != null && !this.DetectType.Equals(input.DetectType))) return false;
            if (this.ExecuteParam != input.ExecuteParam || (this.ExecuteParam != null && !this.ExecuteParam.Equals(input.ExecuteParam))) return false;
            if (this.TestFeature != input.TestFeature || (this.TestFeature != null && !this.TestFeature.Equals(input.TestFeature))) return false;
            if (this.IsContractTestcase != input.IsContractTestcase || (this.IsContractTestcase != null && !this.IsContractTestcase.Equals(input.IsContractTestcase))) return false;
            if (this.TimeCost != input.TimeCost || (this.TimeCost != null && !this.TimeCost.Equals(input.TimeCost))) return false;
            if (this.BeAutoTypeTime != input.BeAutoTypeTime || (this.BeAutoTypeTime != null && !this.BeAutoTypeTime.Equals(input.BeAutoTypeTime))) return false;
            if (this.CompareNumber != input.CompareNumber || (this.CompareNumber != null && !this.CompareNumber.Equals(input.CompareNumber))) return false;
            if (this.SceneFlag != input.SceneFlag || (this.SceneFlag != null && !this.SceneFlag.Equals(input.SceneFlag))) return false;
            if (this.BaseFlag != input.BaseFlag || (this.BaseFlag != null && !this.BaseFlag.Equals(input.BaseFlag))) return false;
            if (this.ParaValidator != input.ParaValidator || (this.ParaValidator != null && !this.ParaValidator.Equals(input.ParaValidator))) return false;
            if (this.KnetNodeId != input.KnetNodeId || (this.KnetNodeId != null && !this.KnetNodeId.Equals(input.KnetNodeId))) return false;
            if (this.LastExeAuthor != input.LastExeAuthor || (this.LastExeAuthor != null && !this.LastExeAuthor.Equals(input.LastExeAuthor))) return false;
            if (this.CloudCarrier != input.CloudCarrier || (this.CloudCarrier != null && !this.CloudCarrier.Equals(input.CloudCarrier))) return false;
            if (this.MarketPlace != input.MarketPlace || (this.MarketPlace != null && !this.MarketPlace.Equals(input.MarketPlace))) return false;
            if (this.TestMindId != input.TestMindId || (this.TestMindId != null && !this.TestMindId.Equals(input.TestMindId))) return false;
            if (this.TestMindUrl != input.TestMindUrl || (this.TestMindUrl != null && !this.TestMindUrl.Equals(input.TestMindUrl))) return false;
            if (this.CommitUrl != input.CommitUrl || (this.CommitUrl != null && !this.CommitUrl.Equals(input.CommitUrl))) return false;
            if (this.TestPatternNumber != input.TestPatternNumber || (this.TestPatternNumber != null && !this.TestPatternNumber.Equals(input.TestPatternNumber))) return false;
            if (this.TestFactorNumber != input.TestFactorNumber || (this.TestFactorNumber != null && !this.TestFactorNumber.Equals(input.TestFactorNumber))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.ReleaseId != input.ReleaseId || (this.ReleaseId != null && !this.ReleaseId.Equals(input.ReleaseId))) return false;
            if (this.LabelId != input.LabelId || (this.LabelId != null && !this.LabelId.Equals(input.LabelId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.ModulePath != input.ModulePath || (this.ModulePath != null && !this.ModulePath.Equals(input.ModulePath))) return false;
            if (this.ModulePathName != input.ModulePathName || (this.ModulePathName != null && !this.ModulePathName.Equals(input.ModulePathName))) return false;
            if (this.ExecuteLatestTime != input.ExecuteLatestTime || (this.ExecuteLatestTime != null && !this.ExecuteLatestTime.Equals(input.ExecuteLatestTime))) return false;
            if (this.ExecuteDuration != input.ExecuteDuration || (this.ExecuteDuration != null && !this.ExecuteDuration.Equals(input.ExecuteDuration))) return false;
            if (this.ExecuteTimes != input.ExecuteTimes || (this.ExecuteTimes != null && !this.ExecuteTimes.Equals(input.ExecuteTimes))) return false;
            if (this.IsKeyword != input.IsKeyword || (this.IsKeyword != null && !this.IsKeyword.Equals(input.IsKeyword))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.NewCreated != input.NewCreated || (this.NewCreated != null && !this.NewCreated.Equals(input.NewCreated))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.CreationVersionName != input.CreationVersionName || (this.CreationVersionName != null && !this.CreationVersionName.Equals(input.CreationVersionName))) return false;
            if (this.FeaturePath != input.FeaturePath || (this.FeaturePath != null && !this.FeaturePath.Equals(input.FeaturePath))) return false;
            if (this.TestcaseUri != input.TestcaseUri || (this.TestcaseUri != null && !this.TestcaseUri.Equals(input.TestcaseUri))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.IteratorCaseUri != input.IteratorCaseUri || (this.IteratorCaseUri != null && !this.IteratorCaseUri.Equals(input.IteratorCaseUri))) return false;
            if (this.ScriptLink != input.ScriptLink || (this.ScriptLink != null && !this.ScriptLink.Equals(input.ScriptLink))) return false;
            if (this.CustomField1 != input.CustomField1 || (this.CustomField1 != null && !this.CustomField1.Equals(input.CustomField1))) return false;
            if (this.CustomField2 != input.CustomField2 || (this.CustomField2 != null && !this.CustomField2.Equals(input.CustomField2))) return false;
            if (this.CustomField3 != input.CustomField3 || (this.CustomField3 != null && !this.CustomField3.Equals(input.CustomField3))) return false;
            if (this.CustomField4 != input.CustomField4 || (this.CustomField4 != null && !this.CustomField4.Equals(input.CustomField4))) return false;
            if (this.CustomField5 != input.CustomField5 || (this.CustomField5 != null && !this.CustomField5.Equals(input.CustomField5))) return false;
            if (this.CustomField6 != input.CustomField6 || (this.CustomField6 != null && !this.CustomField6.Equals(input.CustomField6))) return false;
            if (this.CustomField7 != input.CustomField7 || (this.CustomField7 != null && !this.CustomField7.Equals(input.CustomField7))) return false;
            if (this.CustomField8 != input.CustomField8 || (this.CustomField8 != null && !this.CustomField8.Equals(input.CustomField8))) return false;
            if (this.CustomField9 != input.CustomField9 || (this.CustomField9 != null && !this.CustomField9.Equals(input.CustomField9))) return false;
            if (this.CustomField10 != input.CustomField10 || (this.CustomField10 != null && !this.CustomField10.Equals(input.CustomField10))) return false;
            if (this.CustomField11 != input.CustomField11 || (this.CustomField11 != null && !this.CustomField11.Equals(input.CustomField11))) return false;
            if (this.CustomField12 != input.CustomField12 || (this.CustomField12 != null && !this.CustomField12.Equals(input.CustomField12))) return false;
            if (this.CustomField13 != input.CustomField13 || (this.CustomField13 != null && !this.CustomField13.Equals(input.CustomField13))) return false;
            if (this.CustomField14 != input.CustomField14 || (this.CustomField14 != null && !this.CustomField14.Equals(input.CustomField14))) return false;
            if (this.CustomField15 != input.CustomField15 || (this.CustomField15 != null && !this.CustomField15.Equals(input.CustomField15))) return false;
            if (this.CustomField16 != input.CustomField16 || (this.CustomField16 != null && !this.CustomField16.Equals(input.CustomField16))) return false;
            if (this.CustomField17 != input.CustomField17 || (this.CustomField17 != null && !this.CustomField17.Equals(input.CustomField17))) return false;
            if (this.CustomField18 != input.CustomField18 || (this.CustomField18 != null && !this.CustomField18.Equals(input.CustomField18))) return false;
            if (this.CustomField19 != input.CustomField19 || (this.CustomField19 != null && !this.CustomField19.Equals(input.CustomField19))) return false;
            if (this.CustomField20 != input.CustomField20 || (this.CustomField20 != null && !this.CustomField20.Equals(input.CustomField20))) return false;
            if (this.CustomField21 != input.CustomField21 || (this.CustomField21 != null && !this.CustomField21.Equals(input.CustomField21))) return false;
            if (this.CustomField22 != input.CustomField22 || (this.CustomField22 != null && !this.CustomField22.Equals(input.CustomField22))) return false;
            if (this.CustomField23 != input.CustomField23 || (this.CustomField23 != null && !this.CustomField23.Equals(input.CustomField23))) return false;
            if (this.CustomField24 != input.CustomField24 || (this.CustomField24 != null && !this.CustomField24.Equals(input.CustomField24))) return false;
            if (this.CustomField25 != input.CustomField25 || (this.CustomField25 != null && !this.CustomField25.Equals(input.CustomField25))) return false;
            if (this.LastModifierName != input.LastModifierName || (this.LastModifierName != null && !this.LastModifierName.Equals(input.LastModifierName))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.AssociateDefect != input.AssociateDefect || (this.AssociateDefect != null && !this.AssociateDefect.Equals(input.AssociateDefect))) return false;
            if (this.AssociateIssue != input.AssociateIssue || (this.AssociateIssue != null && !this.AssociateIssue.Equals(input.AssociateIssue))) return false;
            if (this.DefectList != input.DefectList || (this.DefectList != null && input.DefectList != null && !this.DefectList.SequenceEqual(input.DefectList))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Preparation != null) hashCode = hashCode * 59 + this.Preparation.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Activity != null) hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Market != null) hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.Designer != null) hashCode = hashCode * 59 + this.Designer.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ExecuteParameter != null) hashCode = hashCode * 59 + this.ExecuteParameter.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Issue != null) hashCode = hashCode * 59 + this.Issue.GetHashCode();
                if (this.LastModifier != null) hashCode = hashCode * 59 + this.LastModifier.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedTimestamp != null) hashCode = hashCode * 59 + this.LastModifiedTimestamp.GetHashCode();
                if (this.LastChangeTime != null) hashCode = hashCode * 59 + this.LastChangeTime.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.OriginUri != null) hashCode = hashCode * 59 + this.OriginUri.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.ParentPath != null) hashCode = hashCode * 59 + this.ParentPath.GetHashCode();
                if (this.CreationVersionUri != null) hashCode = hashCode * 59 + this.CreationVersionUri.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreationDateTimestamp != null) hashCode = hashCode * 59 + this.CreationDateTimestamp.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.PlatformType != null) hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.TestType != null) hashCode = hashCode * 59 + this.TestType.GetHashCode();
                if (this.TestTypeName != null) hashCode = hashCode * 59 + this.TestTypeName.GetHashCode();
                if (this.DesignNote != null) hashCode = hashCode * 59 + this.DesignNote.GetHashCode();
                if (this.TestStep != null) hashCode = hashCode * 59 + this.TestStep.GetHashCode();
                if (this.ExpectOutput != null) hashCode = hashCode * 59 + this.ExpectOutput.GetHashCode();
                if (this.EnvType != null) hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.ExePlatform != null) hashCode = hashCode * 59 + this.ExePlatform.GetHashCode();
                if (this.TestcaseProject != null) hashCode = hashCode * 59 + this.TestcaseProject.GetHashCode();
                if (this.SvnScriptPath != null) hashCode = hashCode * 59 + this.SvnScriptPath.GetHashCode();
                if (this.MapRestrict != null) hashCode = hashCode * 59 + this.MapRestrict.GetHashCode();
                if (this.NetworkScriptName != null) hashCode = hashCode * 59 + this.NetworkScriptName.GetHashCode();
                if (this.AutoType != null) hashCode = hashCode * 59 + this.AutoType.GetHashCode();
                if (this.ToBeAutoExec != null) hashCode = hashCode * 59 + this.ToBeAutoExec.GetHashCode();
                if (this.LastResult != null) hashCode = hashCode * 59 + this.LastResult.GetHashCode();
                if (this.LastResultUri != null) hashCode = hashCode * 59 + this.LastResultUri.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.FeatureName != null) hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                if (this.InterfaceName != null) hashCode = hashCode * 59 + this.InterfaceName.GetHashCode();
                if (this.SnpNo != null) hashCode = hashCode * 59 + this.SnpNo.GetHashCode();
                if (this.DrRelationId != null) hashCode = hashCode * 59 + this.DrRelationId.GetHashCode();
                if (this.IssueName != null) hashCode = hashCode * 59 + this.IssueName.GetHashCode();
                if (this.TestBaseNum != null) hashCode = hashCode * 59 + this.TestBaseNum.GetHashCode();
                if (this.AutomaticallyExecuted != null) hashCode = hashCode * 59 + this.AutomaticallyExecuted.GetHashCode();
                if (this.FirstExecuteTime != null) hashCode = hashCode * 59 + this.FirstExecuteTime.GetHashCode();
                if (this.DetectType != null) hashCode = hashCode * 59 + this.DetectType.GetHashCode();
                if (this.ExecuteParam != null) hashCode = hashCode * 59 + this.ExecuteParam.GetHashCode();
                if (this.TestFeature != null) hashCode = hashCode * 59 + this.TestFeature.GetHashCode();
                if (this.IsContractTestcase != null) hashCode = hashCode * 59 + this.IsContractTestcase.GetHashCode();
                if (this.TimeCost != null) hashCode = hashCode * 59 + this.TimeCost.GetHashCode();
                if (this.BeAutoTypeTime != null) hashCode = hashCode * 59 + this.BeAutoTypeTime.GetHashCode();
                if (this.CompareNumber != null) hashCode = hashCode * 59 + this.CompareNumber.GetHashCode();
                if (this.SceneFlag != null) hashCode = hashCode * 59 + this.SceneFlag.GetHashCode();
                if (this.BaseFlag != null) hashCode = hashCode * 59 + this.BaseFlag.GetHashCode();
                if (this.ParaValidator != null) hashCode = hashCode * 59 + this.ParaValidator.GetHashCode();
                if (this.KnetNodeId != null) hashCode = hashCode * 59 + this.KnetNodeId.GetHashCode();
                if (this.LastExeAuthor != null) hashCode = hashCode * 59 + this.LastExeAuthor.GetHashCode();
                if (this.CloudCarrier != null) hashCode = hashCode * 59 + this.CloudCarrier.GetHashCode();
                if (this.MarketPlace != null) hashCode = hashCode * 59 + this.MarketPlace.GetHashCode();
                if (this.TestMindId != null) hashCode = hashCode * 59 + this.TestMindId.GetHashCode();
                if (this.TestMindUrl != null) hashCode = hashCode * 59 + this.TestMindUrl.GetHashCode();
                if (this.CommitUrl != null) hashCode = hashCode * 59 + this.CommitUrl.GetHashCode();
                if (this.TestPatternNumber != null) hashCode = hashCode * 59 + this.TestPatternNumber.GetHashCode();
                if (this.TestFactorNumber != null) hashCode = hashCode * 59 + this.TestFactorNumber.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ReleaseId != null) hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.LabelId != null) hashCode = hashCode * 59 + this.LabelId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ModulePath != null) hashCode = hashCode * 59 + this.ModulePath.GetHashCode();
                if (this.ModulePathName != null) hashCode = hashCode * 59 + this.ModulePathName.GetHashCode();
                if (this.ExecuteLatestTime != null) hashCode = hashCode * 59 + this.ExecuteLatestTime.GetHashCode();
                if (this.ExecuteDuration != null) hashCode = hashCode * 59 + this.ExecuteDuration.GetHashCode();
                if (this.ExecuteTimes != null) hashCode = hashCode * 59 + this.ExecuteTimes.GetHashCode();
                if (this.IsKeyword != null) hashCode = hashCode * 59 + this.IsKeyword.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.NewCreated != null) hashCode = hashCode * 59 + this.NewCreated.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.CreationVersionName != null) hashCode = hashCode * 59 + this.CreationVersionName.GetHashCode();
                if (this.FeaturePath != null) hashCode = hashCode * 59 + this.FeaturePath.GetHashCode();
                if (this.TestcaseUri != null) hashCode = hashCode * 59 + this.TestcaseUri.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.IteratorCaseUri != null) hashCode = hashCode * 59 + this.IteratorCaseUri.GetHashCode();
                if (this.ScriptLink != null) hashCode = hashCode * 59 + this.ScriptLink.GetHashCode();
                if (this.CustomField1 != null) hashCode = hashCode * 59 + this.CustomField1.GetHashCode();
                if (this.CustomField2 != null) hashCode = hashCode * 59 + this.CustomField2.GetHashCode();
                if (this.CustomField3 != null) hashCode = hashCode * 59 + this.CustomField3.GetHashCode();
                if (this.CustomField4 != null) hashCode = hashCode * 59 + this.CustomField4.GetHashCode();
                if (this.CustomField5 != null) hashCode = hashCode * 59 + this.CustomField5.GetHashCode();
                if (this.CustomField6 != null) hashCode = hashCode * 59 + this.CustomField6.GetHashCode();
                if (this.CustomField7 != null) hashCode = hashCode * 59 + this.CustomField7.GetHashCode();
                if (this.CustomField8 != null) hashCode = hashCode * 59 + this.CustomField8.GetHashCode();
                if (this.CustomField9 != null) hashCode = hashCode * 59 + this.CustomField9.GetHashCode();
                if (this.CustomField10 != null) hashCode = hashCode * 59 + this.CustomField10.GetHashCode();
                if (this.CustomField11 != null) hashCode = hashCode * 59 + this.CustomField11.GetHashCode();
                if (this.CustomField12 != null) hashCode = hashCode * 59 + this.CustomField12.GetHashCode();
                if (this.CustomField13 != null) hashCode = hashCode * 59 + this.CustomField13.GetHashCode();
                if (this.CustomField14 != null) hashCode = hashCode * 59 + this.CustomField14.GetHashCode();
                if (this.CustomField15 != null) hashCode = hashCode * 59 + this.CustomField15.GetHashCode();
                if (this.CustomField16 != null) hashCode = hashCode * 59 + this.CustomField16.GetHashCode();
                if (this.CustomField17 != null) hashCode = hashCode * 59 + this.CustomField17.GetHashCode();
                if (this.CustomField18 != null) hashCode = hashCode * 59 + this.CustomField18.GetHashCode();
                if (this.CustomField19 != null) hashCode = hashCode * 59 + this.CustomField19.GetHashCode();
                if (this.CustomField20 != null) hashCode = hashCode * 59 + this.CustomField20.GetHashCode();
                if (this.CustomField21 != null) hashCode = hashCode * 59 + this.CustomField21.GetHashCode();
                if (this.CustomField22 != null) hashCode = hashCode * 59 + this.CustomField22.GetHashCode();
                if (this.CustomField23 != null) hashCode = hashCode * 59 + this.CustomField23.GetHashCode();
                if (this.CustomField24 != null) hashCode = hashCode * 59 + this.CustomField24.GetHashCode();
                if (this.CustomField25 != null) hashCode = hashCode * 59 + this.CustomField25.GetHashCode();
                if (this.LastModifierName != null) hashCode = hashCode * 59 + this.LastModifierName.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.AssociateDefect != null) hashCode = hashCode * 59 + this.AssociateDefect.GetHashCode();
                if (this.AssociateIssue != null) hashCode = hashCode * 59 + this.AssociateIssue.GetHashCode();
                if (this.DefectList != null) hashCode = hashCode * 59 + this.DefectList.GetHashCode();
                return hashCode;
            }
        }
    }
}
