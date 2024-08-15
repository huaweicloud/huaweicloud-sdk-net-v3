# 3.1.108 2024-08-15

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EstimateExecutionPlanPrice**
    - changes of response param
      - `+ items.module_address`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNodePool**
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **UpdateNodePool**
    - changes of request param
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **DeleteNodePool**
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **CreateNodePool**
    - changes of request param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
    - changes of response param
      - `+ status.scaleGroupStatuses`
      - `* spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`
  - **ListNodePools**
    - changes of response param
      - `+ items.status.scaleGroupStatuses`
      - `* items.spec.extensionScaleGroups: object<ExtensionScaleGroup> -> list<ExtensionScaleGroup>`

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `BatchRestartOnlineMigrationTasks`
- _Bug Fix_
  - None
- _Change_
  - **BatchStopMigrationTasks**
    - changes of response param
      - `+ migration_tasks.error_msg`
      - `+ migration_tasks.error_code`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdatePrePaidBandwidth**
    - changes of request param
      - `+ extendParam.period_type`
      - `+ extendParam.period_num`
  - **ListEipBandwidths**
    - changes of response param
      - `* eip_bandwidths.tenant_id: uuid -> string`
  - **ListProjectGeipBindings**
    - changes of response param
      - `* geip_bindings.vnic.vni: int32 -> string`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAvailabilityZones**
    - changes of response param
      - `+ spec_code`
  - **ListFlavors**
    - changes of request param
      - `- loadbalancer_type`
  - **ShowLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **UpdateLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchAddAvailableZones**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **BatchRemoveAvailableZones**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
  - **ListLoadBalancers**
    - changes of response param
      - `+ loadbalancers.gw_flavor_id`
      - `+ loadbalancers.loadbalancer_type`
  - **CreateLoadBalancer**
    - changes of response param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstance**
    - changes of request param
      - `+ ha.instance_mode`
  - **ShowBatchUpgradeCandidateVersions**
    - changes of response param
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of request param
      - `+ visibility: enum value [shared]`
    - changes of response param
      - `+ images.visibility: enum value [shared]`
  - **UpdateImage**
    - changes of response param
      - `+ visibility: enum value [shared]`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogs**
    - changes of request param
      - `+ query`
      - `+ is_analysis_query`
    - changes of response param
      - `+ analysisLogs`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeTransportationLicense**
    - changes of response param
      - `+ result.expiry_date`
      - `+ result.review_expiry_date`
      - `+ result.assessed_technical_level`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointWhite**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
    - changes of response param
      - `+ policy_statement.Effect: enum value [Deny]`
      - `- policy_statement.Effect: enum value [Refuse]`
  - **ListEndpoints**
    - changes of response param
      - `+ endpoints.policy_statement.Effect: enum value [Deny]`
      - `- endpoints.policy_statement.Effect: enum value [Refuse]`

# 3.1.107 2024-08-08

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ single_orientation_mode`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSubNetworkInterfaces**
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **CreateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **BatchCreateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.tags`
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **ShowSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **UpdateSubNetworkInterface**
    - changes of request param
      - `+ sub_network_interface.allowed_address_pairs`
    - changes of response param
      - `+ sub_network_interface.allowed_address_pairs`
      - `+ sub_network_interface.state`
      - `+ sub_network_interface.instance_id`
      - `+ sub_network_interface.instance_type`
      - `+ sub_network_interface.scope`
      - `* sub_network_interface.tags: list<string> -> list<ResourceTag>`
  - **MigrateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.allowed_address_pairs`
      - `+ sub_network_interfaces.state`
      - `+ sub_network_interfaces.instance_id`
      - `+ sub_network_interfaces.instance_type`
      - `+ sub_network_interfaces.scope`
      - `* sub_network_interfaces.tags: list<string> -> list<ResourceTag>`
  - **UpdateTrafficMirrorSession**
    - changes of request param
      - `- traffic_mirror_session.type`

# 3.1.106 2024-08-01

### HuaweiCloud SDK LTS

- _Features_
  - Support the following APIs:
    - `ListConsumerGroup`
    - `CreateConsumerGroup`
    - `ConsumerGroupHeartBeat`
    - `ShowLogStreamShards`
    - `ListDetailsConsumerGroup`
    - `UpdateCheckPoint`
    - `DeleteConsumerGroup`
    - `ShowCursorByTime`
    - `ShowCursorTime`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ policy_document`
  - **UpdateEndpointWhite**
    - changes of response param
      - `+ policy_document`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_document`
    - changes of response param
      - `+ policy_document`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `+ policy_document`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_document`
    - changes of response param
      - `+ policy_document`
  - **ListEndpoints**
    - changes of response param
      - `+ endpoints.policy_document`

# 3.1.105 2024-07-25

### HuaweiCloud SDK CCE

- _Features_
  - Support the following APIs:
    - `SyncNodePool`
    - `UpgradeNodePool`
    - `ShowClusterSupportConfiguration`
    - `ShowResourceInstances`
    - `BatchCreateDeleteResourceTags`
    - `ShowResourceTags`
    - `ShowCustomizeClusterTagsByProjectId`
    - `UpdateAutopilotClusterEip`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - Support the API `BatchCheckImageSync`
- _Bug Fix_
  - None
- _Change_
  - **RunTextModeration**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **CheckImageModeration**
    - changes of request param
      - `+ Enterprise-Project-Id`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeCambodianIdCard**
    - changes of request param
      - `+ detect_reproduce`
    - changes of response param
      - `+ result.detect_reproduce_result`
      - `+ result.score_info.reproduce_score`

# 3.1.104 2024-07-18

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ interval_alarm_actions.percentage`
      - `* interval_alarm_actions.lower_bound: int32 -> double`
      - `* interval_alarm_actions.upper_bound: int32 -> double`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policy.interval_alarm_actions.percentage`
      - `* scaling_policy.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policy.interval_alarm_actions.upper_bound: int32 -> double`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scaling_policy_type: enum value [INTERVAL_ALARM]`
      - `+ scaling_policies.interval_alarm_actions.percentage`
      - `* scaling_policies.interval_alarm_actions.lower_bound: int32 -> double`
      - `* scaling_policies.interval_alarm_actions.upper_bound: int32 -> double`

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`

### HuaweiCloud SDK CCE

- _Features_
  - Support the following APIs:
    - `ListAutopilotClusters`
    - `CreateAutopilotCluster`
    - `ShowAutopilotCluster`
    - `UpdateAutopilotCluster`
    - `DeleteAutopilotCluster`
    - `CreateAutopilotKubernetesClusterCert`
    - `ShowAutopilotJob`
    - `ShowAutopilotClusterEndpoints`
    - `ListAutopilotAddonInstances`
    - `CreateAutopilotAddonInstance`
    - `ListAutopilotAddonTemplates`
    - `ShowAutopilotAddonInstance`
    - `UpdateAutopilotAddonInstance`
    - `DeleteAutopilotAddonInstance`
    - `RollbackAutopilotAddonInstance`
    - `UpgradeAutopilotCluster`
    - `ShowAutopilotUpgradeClusterTask`
    - `RetryAutopilotUpgradeClusterTask`
    - `ListAutopilotUpgradeClusterTasks`
    - `CreateAutopilotPreCheck`
    - `ShowAutopilotPreCheck`
    - `ListAutopilotPreCheckTasks`
    - `CreateAutopilotPostCheck`
    - `CreateAutopilotClusterMasterSnapshot`
    - `ListAutopilotClusterMasterSnapshotTasks`
    - `ShowAutopilotClusterUpgradeInfo`
    - `ListAutopilotClusterUpgradePaths`
    - `ListAutopilotClusterUpgradeFeatureGates`
    - `ListAutopilotUpgradeWorkFlows`
    - `CreateAutopilotUpgradeWorkFlow`
    - `ShowAutopilotUpgradeWorkFlow`
    - `UpgradeAutopilotWorkFlowUpdate`
    - `ShowAutopilotQuotas`
    - `BatchCreateAutopilotClusterTags`
    - `BatchDeleteAutopilotClusterTags`
    - `ListAutopilotCharts`
    - `UploadAutopilotChart`
    - `ListAutopilotReleases`
    - `CreateAutopilotRelease`
    - `ShowAutopilotChart`
    - `UpdateAutopilotChart`
    - `DeleteAutopilotChart`
    - `ShowAutopilotRelease`
    - `UpdateAutopilotRelease`
    - `DeleteAutopilotRelease`
    - `DownloadAutopilotChart`
    - `ShowAutopilotChartValues`
    - `ShowAutopilotReleaseHistory`
    - `ShowAutopilotUserChartsQuotas`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTraces**
    - changes of request param
      - `+ access_key_id`
      - `+ enterprise_project_id`
    - changes of response param
      - `+ traces.enterprise_project_id`
      - `+ traces.resource_account_id`
      - `+ traces.user.user_name`
      - `+ traces.user.account_id`
      - `+ traces.user.access_key_id`
      - `+ traces.user.principal_urn`
      - `+ traces.user.principal_id`
      - `+ traces.user.principal_is_root_user`
      - `+ traces.user.type`
      - `+ traces.user.invoked_by`
      - `+ traces.user.session_context`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`
  - **BatchUpdateJob**
    - changes of request param
      - `+ jobs.node_type: enum value [micro,small,medium,xlarge,2xlarge]`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowServer**
    - changes of response param
      - `+ server.flavor.gpus`
      - `+ server.flavor.asic_accelerators`
  - **ListServersDetails**
    - changes of response param
      - `+ servers.flavor.gpus`
      - `+ servers.flavor.asic_accelerators`

### HuaweiCloud SDK ELB

- _Features_
  - Support the APIs `ShowCertificatePrivateKeyEcho`, `CreateCertificatePrivateKeyEcho`
- _Bug Fix_
  - None
- _Change_
  - **ShowQuota**
    - changes of response param
      - `+ quota.free_instance_members_per_pool`
      - `+ quota.free_instance_listeners_per_loadbalancer`
  - **ChangeLoadbalancerChargeMode**
    - changes of request param
      - `+ pay_type`
      - `+ prepaid_options.cloud_service_console_url`
  - **ListCertificates**
    - changes of request param
      - `+ common_name`
      - `+ fingerprint`
    - changes of response param
      - `+ certificates.common_name`
      - `+ certificates.fingerprint`
      - `+ certificates.subject_alternative_names`
  - **CreateCertificate**
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ShowCertificate**
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **UpdateCertificate**
    - changes of request param
      - `+ certificate.scm_certificate_id`
    - changes of response param
      - `+ certificate.common_name`
      - `+ certificate.fingerprint`
      - `+ certificate.subject_alternative_names`
  - **ListFlavors**
    - changes of request param
      - `+ loadbalancer_type`
    - changes of response param
      - `+ flavors.public_border_group`
      - `+ flavors.category`
  - **ShowFlavor**
    - changes of response param
      - `+ flavor.public_border_group`
      - `+ flavor.category`
  - **UpdateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.gw_flavor_id`
  - **ListIpGroups**
    - changes of request param
      - `+ enterprise_project_id`
    - changes of response param
      - `+ ipgroups.enterprise_project_id`
  - **CreateIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **ShowIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpGroup**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **UpdateIpList**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **BatchDeleteIpList**
    - changes of response param
      - `+ ipgroup.enterprise_project_id`
  - **ListListeners**
    - changes of response param
      - `+ listeners.insert_headers.X-Nuwa-Trace`
  - **CreateListener**
    - changes of request param
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ShowListener**
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **UpdateListener**
    - changes of request param
      - `+ listener.insert_headers.X-Nuwa-Trace`
    - changes of response param
      - `+ listener.insert_headers.X-Nuwa-Trace`
  - **ListPools**
    - changes of request param
      - `+ pool_health`
      - `+ any_port_enable`
      - `+ public_border_group`
    - changes of response param
      - `+ pools.enterprise_project_id`
      - `+ pools.pool_health`
      - `+ pools.public_border_group`
  - **CreatePool**
    - changes of request param
      - `+ pool.target_rebalance`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ShowPool**
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **UpdatePool**
    - changes of request param
      - `+ pool.pool_health`
    - changes of response param
      - `+ pool.enterprise_project_id`
      - `+ pool.pool_health`
      - `+ pool.public_border_group`
  - **ListMembers**
    - changes of response param
      - `- members.pool_id`
      - `- members.device_owner`
      - `- members.device_id`
      - `- members.loadbalancer_id`
      - `- members.loadbalancers`
  - **CreateMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ShowMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **UpdateMember**
    - changes of response param
      - `- member.pool_id`
      - `- member.device_owner`
      - `- member.device_id`
      - `- member.loadbalancer_id`
      - `- member.loadbalancers`
  - **ListAllMembers**
    - changes of response param
      - `* members: list<Member> -> list<MemberInfo>`
  - **BatchUpdateMembers**
    - changes of response param
      - `+ members.created_at`
      - `+ members.updated_at`
  - **UpdateHealthMonitor**
    - changes of request param
      - `- healthmonitor.http_method: enum value [PUT,DELETE,TRACE,OPTIONS,CONNECT,PATCH]`
  - **ListLoadBalancers**
    - changes of request param
      - `+ loadbalancer_type`
  - **CreateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.gw_flavor_id`
      - `+ loadbalancer.loadbalancer_type`
      - `+ loadbalancer.prepaid_options.promotion_info`
      - `+ loadbalancer.prepaid_options.cloud_service_console_url`
  - **ListL7Policies**
    - changes of response param
      - `+ l7policies.redirect_pools_config`
      - `+ l7policies.redirect_pools_sticky_session_config`
      - `+ l7policies.redirect_url_config.insert_headers_config`
      - `+ l7policies.redirect_url_config.remove_headers_config`
      - `+ l7policies.fixed_response_config.insert_headers_config`
      - `+ l7policies.fixed_response_config.remove_headers_config`
      - `+ l7policies.fixed_response_config.traffic_limit_config`
      - `+ l7policies.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policies.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policies.redirect_pools_extend_config.traffic_limit_config`
  - **CreateL7Policy**
    - changes of request param
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
    - changes of response param
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
  - **ShowL7Policy**
    - changes of response param
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
  - **UpdateL7Policy**
    - changes of request param
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`
      - `* l7policy.redirect_pools_extend_config.rewrite_url_config: object<CreateRewriteUrlConfig> -> object<UpdateRewriteUrlConfig>`
    - changes of response param
      - `+ l7policy.redirect_pools_config`
      - `+ l7policy.redirect_pools_sticky_session_config`
      - `+ l7policy.redirect_url_config.insert_headers_config`
      - `+ l7policy.redirect_url_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.insert_headers_config`
      - `+ l7policy.fixed_response_config.remove_headers_config`
      - `+ l7policy.fixed_response_config.traffic_limit_config`
      - `+ l7policy.redirect_pools_extend_config.insert_headers_config`
      - `+ l7policy.redirect_pools_extend_config.remove_headers_config`
      - `+ l7policy.redirect_pools_extend_config.traffic_limit_config`

### HuaweiCloud SDK EVS

- _Features_
  - Support the APIs `ChangeVolumeChargeMode`, `UnsubscribePostpaidVolume`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListWorkflowExecutions**
    - changes of request param
      - `+ offset`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAgencies**
    - changes of response param
      - `- agencies.duration`
  - **CreateAgency**
    - changes of response param
      - `- agency.duration`
  - **ShowAgency**
    - changes of response param
      - `- agency.duration`
  - **UpdateAgency**
    - changes of response param
      - `- agency.duration`
  - **ListRolesForGroupOnEnterpriseProject**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListPermissions**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneShowPermission**
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListDomainPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListProjectPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **KeystoneListAllProjectPermissionsForGroup**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListDomainPermissionsForAgency**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListProjectPermissionsForAgency**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **ListRolesForUserOnEnterpriseProject**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: object -> list<string>`
    - changes of response param
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **UpdateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: object -> list<string>`
    - changes of response param
      - `* role.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByToken**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`
  - **CreateTemporaryAccessKeyByAgency**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: object -> list<string>`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of request param
      - `+ __platform: enum value [Huawei Cloud EulerOS]`

### HuaweiCloud SDK KMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListKeys**
    - changes of response param
      - `- key_details.key_label`
  - **ListKeyDetail**
    - changes of response param
      - `- key_info.key_label`
  - **ListKmsByTags**
    - changes of response param
      - `- resources.resource_detail.key_label`

### HuaweiCloud SDK Live

- _Features_
  - Support the API `ListPlayDomainStreamInfo`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VOD

- _Features_
  - Support the API `DeleteTranscodeProduct`
- _Bug Fix_
  - None
- _Change_
  - **ShowVodStatistics**
    - changes of response param
      - `+ sample_data.storage_warm`
      - `+ sample_data.storage_cold`

# 3.1.103 2024-07-11

### HuaweiCloud SDK CCE

- _Features_
  - Support the API `ScaleNodePool`
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **UpdateNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **DeleteNode**
    - changes of response param
      - `+ metadata.ownerReference`
  - **CreateNode**
    - changes of request param
      - `+ metadata.ownerReference`
    - changes of response param
      - `+ metadata.ownerReference`
  - **ListNodes**
    - changes of response param
      - `+ items.metadata.ownerReference`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.extensionScaleGroups`
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.extensionScaleGroups`
    - changes of response param
      - `+ spec.extensionScaleGroups`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.extensionScaleGroups`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Deprecate the following APIs:
    - `ShowBlackWhiteList`
    - `UpdateBlackWhiteList`
    - `UpdatePrivateBucketAccess`
    - `BatchDeleteTags`
    - `ShowOriginHost`
    - `UpdateOriginHost`
    - `UpdateRangeSwitch`
    - `UpdateFollow302Switch`
    - `ShowRefer`
    - `UpdateRefer`
    - `ShowIpInfo`
    - `ShowResponseHeader`
    - `UpdateResponseHeader`
    - `CreateRefreshTasks`
    - `CreatePreheatingTasks`
    - `ShowHistoryTasks`
    - `ShowHistoryTaskDetails`
    - `ShowUrlTaskInfo`
    - `ShowQuota`
    - `ShowTags`
    - `CreateTags`
    - `CreateDomain`
    - `ShowDomainDetail`
    - `DeleteDomain`
    - `EnableDomain`
    - `DisableDomain`
    - `UpdateDomainOrigin`
    - `ShowHttpInfo`
    - `UpdateHttpsInfo`
    - `UpdateDomainMultiCertificates`
    - `ShowCertificatesHttpsInfo`
    - `ShowCacheRules`
    - `UpdateCacheRules`
  - **ListCdnDomainTopRefers**
    - changes of response param
      - `- top_refer_summary.ratio`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateEvents**
    - changes of request param
      - `+ detail.dimensions`
  - **ListNotificationMasks**
    - changes of response param
      - `+ notification_masks.policies.selected_unit`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - Support the following APIs:
    - `ListHostGroupPermissions`
    - `UpdateHostGroupPermissions`
    - `CheckWhetherHostGroupCanBeCreated`
    - `ListEnvironmentPermissions`
    - `UpdateEnvironmentPermission`
    - `CopyHostsToTarget`
    - `BatchDeleteHosts`
    - `ListAssociateEnvironmentsInfos`
    - `ListHostGroupBaseInfos`
    - `ListEnvironmentHosts`
    - `CopyApplication`
    - `BatchDeleteApp`
    - `ListApplicationPermissions`
    - `BatchUpdateApplicationPermissions`
    - `BatchUpdatePermissionLevel`
    - `ListAppGroups`
    - `CreateAppGroups`
    - `UpdateAppGroups`
    - `DeleteAppGroups`
    - `MoveAppGroups`
    - `MoveAppToGroup`
    - `CheckIsDuplicateAppName`
    - `CheckCanCreate`
    - `UpdateAppDisableStatus`
    - `UpdateHostCluster`
    - `DeleteHostCluster`
    - `UpdateHostInfo`
    - `DeleteHost`
    - `UpdateEnvironment`
    - `UpdateAppInfo`
- _Bug Fix_
  - None
- _Change_
  - **CreateApp**
    - changes of request param
      - `+ arrange_infos.operation_list.id`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.info:gpus`
      - `+ flavors.os_extra_specs.info:asic_accelerators`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.info:gpus`
      - `+ flavors.extra_specs.info:asic_accelerators`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `ListSupportKernelPlugins`
    - `ListKernelPlugins`
    - `SetKernelPluginLicense`
    - `InstallKernelPlugin`
    - `ListPluginExtensions`
    - `ResumePluginExtensions`
- _Bug Fix_
  - None
- _Change_
  - **RestoreInstance**
    - changes of request param
      - `- source.table_list`
      - `- source.schema_type`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstance**
    - changes of request param
      - `- kafka_manager_user`
      - `- kafka_manager_password`

### HuaweiCloud SDK Live

- _Features_
  - Support the following APIs:
    - `ShowRefererChain`
    - `SetRefererChain`
    - `DeleteRefererChain`
    - `ListHlsConfig`
    - `UpdateHlsConfig`
- _Bug Fix_
  - None
- _Change_
  - **ShowPullSourcesConfig**
    - changes of response param
      - `+ source_port`
  - **UpdatePullSourcesConfig**
    - changes of request param
      - `+ source_port`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeBankReceipt**
    - changes of request param
      - `+ page_num`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs,fcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs,fcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs,fcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs,fcs),[c6.4u16g.cluster.arm](tag:hcs,fcs),[c6.8u32g.cluster.arm](tag:hcs,fcs),[c6.16u64g.cluster.arm](tag:hcs,fcs),[c6.32u128g.cluster.arm](tag:hcs,fcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`

# 3.1.102 2024-07-04

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.url_auth.time_arg`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.url_auth.time_arg`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ResizeStarRocksFlavor`
    - `ShowStarrocksParams`
    - `UpdateStarrocksParams`
    - `SyncStarRocksUsers`
    - `CheckStarrocksParams`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`
  - **ListInstancesDetails**
    - changes of response param
      - `+ instances.datastore.target_version`
      - `+ instances.datastore.hotfix_finished_times`

### HuaweiCloud SDK KMS

- _Features_
  - Support the APIs `UpdatePrimaryRegion`, `ReplicateKey`, `ListSupportRegions`
- _Bug Fix_
  - None
- _Change_
  - **ListKeys**
    - changes of response param
      - `- key_details.partition_type`
  - **ListKeyDetail**
    - changes of response param
      - `- key_info.partition_type`
  - **ListKmsByTags**
    - changes of response param
      - `- resources.resource_detail.partition_type`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeCambodianIdCard**
    - changes of request param
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_glare`
      - `+ return_adjusted_image`
      - `+ detect_tampering`
    - changes of response param
      - `+ result.adjusted_image`
      - `+ result.detect_border_integrity_result`
      - `+ result.detect_blocking_within_border_result`
      - `+ result.detect_blur_result`
      - `+ result.detect_glare_result`
      - `+ result.detect_tampering_result`
      - `+ result.score_info`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - Support the following APIs:
    - `ListVhosts`
    - `CreateVhost`
    - `BatchDeleteVhosts`
    - `ListExchanges`
    - `CreateExchange`
    - `BatchDeleteExchanges`
    - `ListQueues`
    - `CreateQueue`
    - `BatchDeleteQueues`
    - `ShowQueueDetails`
    - `DeleteQueueInfo`
    - `ListBindings`
    - `CreateBinding`
    - `DeleteBinding`
    - `ListUser`
    - `CreateUser`
    - `UpdateUser`
    - `DeleteUser`
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstanceByEngine**
    - changes of request param
      - `- engine_version: enum value [3.8.35]`
  - **UpdateInstance**
    - changes of request param
      - `+ enable_acl`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [3.8.35]`

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `CreateInstanceIam5`, `UnlockNodeReadonlyStatus`, `DeleteDisasterRecovery`, `ListFlavorsResize`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.101 2024-06-27

### HuaweiCloud SDK Core

- _Features_
  - None
- _Bug Fix_
  - Solve the problem of failed signature verification when calling some service apis.
- _Change_
  - None

### HuaweiCloud SDK AOM

- _Features_
  - Support the APIs `ListMetricOrEventAlarmRule`, `AddOrUpdateMetricOrEventAlarmRule`, `DeleteMetricOrEventAlarmRule`
- _Bug Fix_
  - None
- _Change_
  - **ListEvent2alarmRule**
    - changes of response param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **UpdateEventRule**
    - changes of request param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **AddEvent2alarmRule**
    - changes of request param
      - `* create_time: int32 -> int64`
      - `* update_time: int32 -> int64`
  - **ListNotifiedHistories**
    - changes of response param
      - `* notified_histories.notifications.smn_channel.smn_notified_history.smn_subscription_status: string -> int32`
  - **CreateApp**
    - changes of request param
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **UpdateApp**
    - changes of request param
      - `+ register_type: enum value [CONSOLESERVICE_DISCOVERY]`
      - `- register_type: enum value [CONSOLE,SERVICE_DISCOVERY]`
  - **CreateComponent**
    - changes of request param
      - `- model_type: enum value [APPLICATION,SUB_APPLICATION]`
  - **CreateEnv**
    - changes of request param
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`
  - **ListResourceUnderNode**
    - changes of request param
      - `- ci_type: enum value [APPLICATION,SUB_APPLICATION,COMPONENT,ENVIRONMENT]`
  - **UpdateEnv**
    - changes of request param
      - `- env_type: enum value [DEV,TEST,PRE,ONLINE]`
      - `- os_type: enum value [LINUX,WINDOWS]`
      - `- register_type: enum value [API,CONSOLE,SERVICE_DISCOVERY]`

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **GetStackTemplate**
    - changes of request param
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
  - **ShowStackSetTemplate**
    - changes of request param
      - `+ access_control_source_ips`
      - `+ access_control_source_vpc_ids`
      - `+ call_identity`
  - **ShowStackInstance**
    - changes of request param
      - `+ call_identity`
  - **ShowTemplateVersionContent**
    - changes of request param
      - `+ access_control_source_vpc_ids`
      - `+ access_control_source_ips`
  - **ListStackSets**
    - changes of request param
      - `+ call_identity`
    - changes of response param
      - `+ stack_sets.permission_model: enum value [SERVICE_MANAGED]`
  - **CreateStackSet**
    - changes of request param
      - `+ call_identity`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackSetOperations**
    - changes of request param
      - `+ call_identity`
  - **ShowStackSetMetadata**
    - changes of request param
      - `+ call_identity`
    - changes of response param
      - `+ organizational_unit_ids`
      - `+ permission_model: enum value [SERVICE_MANAGED]`
  - **ListStackInstances**
    - changes of request param
      - `+ call_identity`
  - **CreateStackInstance**
    - changes of request param
      - `+ call_identity`
  - **DeleteStackInstanceDeprecated**
    - changes of request param
      - `+ call_identity`
  - **UpdateStackInstances**
    - changes of request param
      - `+ call_identity`
  - **DeleteStackInstance**
    - changes of request param
      - `+ call_identity`
  - **DeployStackSet**
    - changes of request param
      - `+ call_identity`
      - `- var_overrides`
  - **DeleteStackSet**
    - changes of request param
      - `+ call_identity`
  - **UpdateStackSet**
    - changes of request param
      - `+ call_identity`
      - `- permission_model`
  - **ShowStackSetOperationMetadata**
    - changes of request param
      - `+ call_identity`

### HuaweiCloud SDK CFW

- _Features_
  - Support the following APIs:
    - `CreateTag`
    - `DeleteTag`
    - `ListCaptureTask`
    - `CreateCaptureTask`
    - `DeleteCaptureTask`
    - `ListCaptureResult`
    - `CancelCaptureTask`
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `+ protocol: enum value [6,17,1,58]`
    - changes of response param
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
  - **ListAccessControlLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
    - changes of response param
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
  - **ListBlackWhiteLists**
    - changes of request param
      - `+ address_type: enum value [0,1,2]`
    - changes of response param
      - `- data.object_id`
  - **AddServiceSet**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListDomainParseDetail**
    - changes of request param
      - `* address_type: string -> int32`
  - **UpdateDnsServers**
    - changes of request param
      - `* fw_instance_id: optional -> required`
  - **ListDnsServers**
    - changes of request param
      - `* fw_instance_id: optional -> required`
  - **ChangeIpsSwitchStatus**
    - changes of response param
      - `- trace_id`
  - **ListAttackLogs**
    - changes of request param
      - `+ src_province_name`
      - `+ dst_province_name`
      - `+ src_city_name`
      - `+ dst_city_name`
      - `- source`
      - `+ protocol: enum value [6,17,1,58]`
      - `+ action: enum value [0,1]`
      - `+ direction: enum value [0,1]`
    - changes of response param
      - `+ data.records.src_province_id`
      - `+ data.records.src_province_name`
      - `+ data.records.src_city_id`
      - `+ data.records.src_city_name`
      - `+ data.records.dst_province_id`
      - `+ data.records.dst_province_name`
      - `+ data.records.dst_city_id`
      - `+ data.records.dst_city_name`
      - `- data.records.dst_host`
      - `* data.records.hit_time: int32 -> int64`
  - **UpdateBlackWhiteList**
    - changes of request param
      - `- list_type`
      - `- object_id`
  - **ChangeIpsProtectMode**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **UpdateServiceSet**
    - changes of response param
      - `- data.name`
      - `* data: object<IdObject> -> object`
  - **ListServiceItems**
    - changes of response param
      - `- data.records.name`
  - **AddServiceItems**
    - changes of request param
      - `- service_items.item_id`
      - `- service_items.name`
    - changes of response param
      - `- data.items.name`
      - `* data.items: list<IdObject> -> list<object>`
  - **CreateFirewall**
    - changes of request param
      - `- X-Trace-Id`
  - **UpdateAddressSet**
    - changes of request param
      - `- address_type`
  - **UpdateDomainSet**
    - changes of request param
      - `* fw_instance_id: optional -> required`
      - `- set_id`
      - `- domain_set_type`
  - **ListProtectedVpcs**
    - changes of response param
      - `- trace_id`
      - `- data.protect_vpcs.id`
      - `- data.protect_vpcs.name`
      - `- data.protect_vpcs.virsubnet_id`
      - `- data.protect_vpcs.state`
      - `- data.protect_vpcs.created_at`
      - `- data.protect_vpcs.updated_at`
      - `- data.protect_vpcs.tags`
      - `- data.protect_vpcs.description`
      - `- data.protect_vpcs.project_id`
      - `- data.protect_vpcs.vpc_project_id`
      - `- data.protect_vpcs.enterprise_project_id`
  - **CreateEastWestFirewall**
    - changes of response param
      - `+ data.er`
      - `+ data.inspertion_vpc`
      - `- data.name`
      - `* data: object<IdObject> -> object<CreateEWFirewallResp>`
  - **ListEastWestFirewall**
    - changes of request param
      - `* fw_instance_id: optional -> required`
    - changes of response param
      - `+ data.er.attachment_id`
  - **AddAclRule**
    - changes of request param
      - `- rules.profile`
      - `+ rules.source.address_group`
      - `* rules.service.service_group_names: list<AddressGroupVO> -> list<ServiceGroupVO>`
  - **UpdateAclRule**
    - changes of request param
      - `- profile`
      - `+ source.address_group_names.address_set_type`
      - `- source.address_group_names.protocols`
      - `- source.address_group_names.service_set_type`
  - **ListAclRules**
    - changes of request param
      - `- protocol`
    - changes of response param
      - `- data.records.sequence`
      - `- data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.address_set_type`
      - `- data.records.source.address_group_names.protocols`
      - `- data.records.source.address_group_names.service_set_type`
      - `* data.records.source: object<RuleAddressDto> -> object<RuleAddressDtoForResponse>`
      - `- data.records.service.predefined_group`
      - `* data.records.service: object<RuleServiceDto> -> object<RuleServiceDtoForResponse>`
  - **ListServiceSets**
    - changes of response param
      - `- data.records.status`
  - **ListDomains**
    - changes of request param
      - `- description`
      - `- set_id`
  - **ListFirewallDetail**
    - changes of response param
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`
  - **ListFirewallList**
    - changes of response param
      - `- data.records.flavor.session_concurrent`
      - `- data.records.flavor.session_create`
      - `- data.records.flavor.total_rule_count`
      - `- data.records.flavor.used_rule_count`
      - `- data.records.flavor.vpc_bandwith`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.is_open_fast_clean`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.is_open_fast_clean`
  - **ShowDbObjectTemplateResult**
    - changes of request param
      - `+ file_export_object_level`
  - **DownloadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level: enum value [column]`
  - **UploadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level: enum value [column]`
  - **ShowDbObjectTemplateProgress**
    - changes of request param
      - `+ type`
  - **ShowSupportObjectType**
    - changes of response param
      - `+ is_import_cloumn`
  - **ShowReplayResults**
    - changes of request param
      - `+ is_sample`
      - `+ error_type`
      - `+ sql_template_md5`
      - `+ type: enum value [error_classification]`
    - changes of response param
      - `+ error_classifications`
      - `+ slow_sql_templates.sql_template_md5`
      - `+ error_sql_templates.sql_template_md5`
  - **CreateJob**
    - changes of request param
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.base_info.is_open_fast_clean`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.base_info.is_open_fast_clean`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.base_info.is_open_fast_clean`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.base_info.is_open_fast_clean`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [set_readonly]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [set_readonly]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [postgresql,ecs_postgresql,cloud_postgresql,mongodb,ecs_mongodb,cloud_mongodb]`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.os_extra_specs.security:enclave_supported`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.network_interface:traffic_mirroring_supported`
      - `+ flavors.extra_specs.security:enclave_supported`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListQuotas**
    - changes of response param
      - `+ quotas.resources.type: enum value [fgs_on_demand_instance_limit,fgs_func_qos_limit]`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ResumeStarRocksDataReplication`
    - `PauseStarRocksDataReplication`
    - `ListClickHouseInstanceNode`
    - `ShowClickHouseSlowLogDetail`
    - `ShowClickHouseSlowLogSensitiveStatus`
    - `UpdateClickHouseSlowLogSensitiveStatus`
    - `ShowClickHouseLtsConfig`
    - `UpdateClickHouseLtsConfig`
    - `DeleteClickHouseLtsConfig`
    - `CheckClickHouseDataBaseConfig`
    - `CheckClickHouseTableConfig`
    - `ListClickHouseDataBase`
    - `ListClickHouseDataBaseReplicationConfig`
    - `ListClickHouseDataBaseParameter`
    - `CreateClickHouseInstance`
    - `ListClickHouseInstance`
    - `DeleteClickHouseInstance`
    - `ResizeClickHouseInstance`
    - `RebootClickHouseInstance`
    - `ShowClickHouseDatabaseUser`
    - `CreateClickHouseDatabaseUser`
    - `UpdateClickHouseDatabaseUserPassword`
    - `UpdateClickHouseDatabaseUserPermission`
    - `ListClickHouseDataBaseReplication`
    - `CreateClickHouseDataBaseReplication`
    - `DeleteClickHouseDataBaseReplication`
    - `UpdateClickHouseDataBaseConfig`
    - `DeleteClickHouseDataBaseConfig`
    - `ResizeClickHouseFlavor`
    - `DeleteClickHouseDatabaseUser`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `SetNewBackupPolicy`
    - `ListInstanceDetails`
    - `ShowBatchUpgradeCandidateVersions`
    - `UpgradeInstancesVersion`
    - `ConfirmRestoredData`
- _Bug Fix_
  - None
- _Change_
  - **CreateInstance**
    - changes of request param
      - `- replica_num: enum value [2]`
  - **CreateDbInstance**
    - changes of request param
      - `- replica_num: enum value [2]`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
    - `CountPortsByTags`
    - `ListPortsByTags`
    - `ShowPortTags`
    - `CreatePortTag`
    - `ListPortTags`
    - `BatchCreatePortTags`
    - `DeletePortTag`
    - `BatchDeletePortTags`
- _Bug Fix_
  - None
- _Change_
  - **ListFirewallTags**
    - changes of request param
      - `+ limit`
      - `+ offset`
    - changes of response param
      - `+ total_count`
      - `* tags: object<ListTag> -> list<ListTag>`
  - **ShowFirewallTags**
    - changes of response param
      - `- sys_tags`
      - `* tags: object<ResourceTag> -> list<ResourceTag>`
  - **BatchDeleteFirewallTags**
    - changes of request param
      - `* tags: list<ResourceTag> -> list<DeleteResourceTagRequestBody>`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateEndpointService**
    - changes of response param
      - `+ ip_version`
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ ipv6_address`
  - **CreateEndpointService**
    - changes of request param
      - `+ ip_version`
      - `- enable_policy`
    - changes of response param
      - `+ ip_version`
  - **CreateEndpoint**
    - changes of request param
      - `+ policy_statement`
      - `+ ip_version`
      - `+ ipv6_address`
    - changes of response param
      - `+ ipv6_address`
  - **ListEndpoints**
    - changes of request param
      - `- public_border_group`

# 3.1.100 2024-06-20

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListProvisioningTemplates`
    - `CreateProvisioningTemplate`
    - `ShowProvisioningTemplate`
    - `UpdateProvisioningTemplate`
    - `DeleteProvisioningTemplate`
    - `ListDeviceAuthorizers`
    - `CreateDeviceAuthorizer`
    - `ShowDeviceAuthorizer`
    - `UpdateDeviceAuthorizer`
    - `DeleteDeviceAuthorizer`
    - `ListDevicePolicies`
    - `CreateDevicePolicy`
    - `ShowDevicePolicy`
    - `UpdateDevicePolicy`
    - `DeleteDevicePolicy`
    - `BindDevicePolicy`
    - `UnbindDevicePolicy`
    - `ShowTargetsInDevicePolicy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowConnectorTask**
    - changes of response param
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **CreateConnectorTask**
    - changes of response param
      - `- sink_task.connector_class`
      - `- sink_task.storage_class`
      - `- sink_task.format_class`
  - **ListConnectorTasks**
    - changes of response param
      - `- tasks.sink_task.connector_class`
      - `- tasks.sink_task.storage_class`
      - `- tasks.sink_task.format_class`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateAudioStreamModerationJob**
    - changes of request param
      - `+ data.language`
  - **RunCreateAudioModerationJob**
    - changes of request param
      - `+ data.language`

# 3.1.99 2024-06-13

### HuaweiCloud SDK Core

- _Features_
  - Support retry for request.
- _Bug Fix_
  - None
- _Change_
  - Add non-null check to method SetAk/SetSk of Credentials.

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ interval_alarm_actions`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.interval_alarm_actions`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ interval_alarm_actions`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.interval_alarm_actions`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.interval_alarm_actions`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateMigrationTask**
    - changes of request param
      - `+ target_instance.task_status`
  - **ShowMigrationTask**
    - changes of response param
      - `+ target_instance.task_status`
  - **StopMigrationTask**
    - changes of response param
      - `+ target_instance.task_status`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowServer**
    - changes of response param
      - `- server.fault.code`
      - `- server.fault.created`
      - `- server.fault.message`
      - `- server.fault.details`
      - `* server.fault: object<ServerFault> -> object`
  - **ListServersDetails**
    - changes of response param
      - `- servers.fault.code`
      - `- servers.fault.created`
      - `- servers.fault.message`
      - `- servers.fault.details`
      - `* servers.fault: object<ServerFault> -> object`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DisassociatePublicips**
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`
  - **AssociatePublicips**
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`
  - **UpdatePublicip**
    - changes of request param
      - `+ publicip.associate_instance_type: enum value [VPN]`
      - `- publicip.associate_instance_type: enum value []`
    - changes of response param
      - `- publicip.associate_instance_type: enum value [null]`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDedicatedResourceInfo**
    - changes of response param
      - `+ resource_name`
      - `- name`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowReplayDelayStatus**
    - changes of response param
      - `+ delay_time_value_range`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
    - `ListSecurityGroupsByTags`
    - `BatchCreateSecurityGroupTags`
    - `BatchDeleteSecurityGroupTags`
    - `ShowSecurityGroupTags`
    - `CreateSecurityGroupTag`
    - `DeleteSecurityGroupTag`
    - `ListSecurityGroupTags`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.98 2024-06-06

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **UpdateNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **DeleteNode**
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **CreateNode**
    - changes of request param
      - `+ spec.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.serverEnterpriseProjectID`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.serverEnterpriseProjectID`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **UpdateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
    - changes of response param
      - `+ spec.nodeTemplate.serverEnterpriseProjectID`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.serverEnterpriseProjectID`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ChangeVpc**
    - changes of request param
      - `* nic.security_groups: object<ChangeVpcSecurityGroups> -> list<ChangeVpcSecurityGroups>`
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.cond:storage:type`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.cond:storage:type`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ShowLtsConfigs`
    - `CreateLtsConfigs`
    - `DeleteLtsConfigs`
    - `ShowRecyclePolicy`
    - `SetRecyclePolicy`
    - `ListRecycleInstances`
    - `ShowSlowlogSensitiveStatus`
    - `UpdateSlowlogSensitiveSwitch`
    - `RestartProxyInstance`
    - `RenameInstanceNode`
    - `ShowAutoScalingHistory`
    - `UpdateServerlessPolicy`
    - `ModifyNodePriority`
    - `ShowInstanceEip`
    - `ListParamsTemplateApplyHistory`
    - `ShowProxyConfigurations`
- _Bug Fix_
  - None
- _Change_
  - **ShowProxyIpgroup**
    - changes of response param
      - `+ ip_group.id`
      - `+ ip_group.name`
      - `+ ip_group.ip_list`
      - `* ip_group: object -> object<ProxyIpGroupDetail>`
  - **UpdateGaussMySqlInstanceName**
    - changes of request param
      - `+ is_modify_node_name`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **OfflineNodes**
    - changes of response param
      - `+ job_id`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAvailableFlavors**
    - changes of response param
      - `+ flavors.spec_code`
      - `- flavors.spec_cpde`
  - **ListRestorableInstances**
    - changes of response param
      - `* instances.version: number -> string`
  - **ListDbUsers**
    - changes of response param
      - `+ users.attribute`
      - `+ users.lock_status`
      - `- users.attributes`
  - **ShowUpgradeCandidateVersions**
    - changes of response param
      - `+ hotfix_upgrade_infos`
      - `+ hotfix_rollback_infos`

### HuaweiCloud SDK ImageSearch

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunSearch**
    - changes of request param
      - `+ text`
      - `+ search_type: enum value [TEXT]`
      - `+ optional_params.text_lang`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStreamIndex**
    - changes of request param
      - `+ sqlAnalysisEnable`

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`, `ListShareBackups`
- _Bug Fix_
  - None
- _Change_
  - **ListBackups**
    - changes of request param
      - `+ status`

# 3.1.97 2024-05-30

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowHistoryTaskDetails**
    - changes of response param
      - `+ urls.fail_classify`
      - `+ urls.fail_desc`
  - **ListDomains**
    - changes of response param
      - `+ domains.sources.obs_bucket_type`
  - **CreateDomain**
    - changes of request param
      - `+ domain.sources.obs_bucket_type`
      - `* domain.sources: list<Sources> -> list<SourcesRequestBody>`
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **DeleteDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **EnableDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **DisableDomain**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.access_area_filter`
      - `* configs.sources: list<SourcesConfig> -> list<SourcesConfigResponseBody>`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.access_area_filter`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `ChangeServerNetworkInterface`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the APIs `UpgradeProxyVersion`, `UpdateProxyName`, `ShowProxyIpgroup`, `ShowProxyVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **SearchAutoEnlargePolicy**
    - changes of response param
      - `+ step_percent`
      - `+ step_size`
  - **UpdateInstanceConfiguration**
    - changes of response param
      - `+ job_id`
  - **CreateConfigurationTemplate**
    - changes of request param
      - `+ datastore.instance_mode: enum value [ha:readonly]`
  - **ListDatabases**
    - changes of response param
      - `+ databases.datctype`
      - `+ databases.compatibility_type`
  - **ListTasks**
    - changes of response param
      - `+ tasks.created_at`
      - `+ tasks.ended_at`
  - **ListComponentInfos**
    - changes of response param
      - `+ nodes.components.type`
      - `+ nodes.components.detail`
  - **ShowUpgradeCandidateVersions**
    - changes of response param
      - `+ upgrade_type_list.is_parallel_upgrade`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListBridges`
    - `AddBridge`
    - `DeleteBridge`
    - `ResetBridgeSecret`
    - `ListDeviceGroupsByDevice`
    - `UpdateCertificate`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPC

- _Features_
  - Support the following APIs:
    - `ListClouddcnSubnets`
    - `CreateClouddcnSubnet`
    - `ShowClouddcnSubnet`
    - `UpdateClouddcnSubnet`
    - `DeleteClouddcnSubnet`
    - `ShowClouddcnSubnetsTags`
    - `AddClouddcnSubnetsTags`
    - `ListClouddcnSubnetsFilterTags`
    - `DeleteClouddcnSubnetsTag`
    - `ListClouddcnSubnetsCountFilterTags`
    - `ListClouddcnSubnetsTags`
    - `BatchDeleteClouddcnSubnetsTags`
    - `BatchCreateClouddcnSubnetsTags`
- _Bug Fix_
  - None
- _Change_
  - **ListSecurityGroups**
    - changes of response param
      - `+ security_groups.tags`
  - **CreateSecurityGroup**
    - changes of request param
      - `+ security_group.tags`
    - changes of response param
      - `+ security_group.tags`
  - **ShowSecurityGroup**
    - changes of response param
      - `+ security_group.tags`
  - **UpdateSecurityGroup**
    - changes of response param
      - `+ security_group.tags`
  - **CreateFirewall**
    - changes of request param
      - `+ firewall.tags`

# 3.1.96 2024-05-23

### HuaweiCloud SDK Organizations

- _Features_
  - Support `Organizations`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingGroup**
    - changes of request param
      - `+ tags`
  - **ListScalingGroups**
    - changes of response param
      - `+ scaling_groups.tags`
  - **ShowScalingGroup**
    - changes of response param
      - `+ scaling_group.tags`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the APIs `ShowRedisBigKeys`, `ShowPasswordlessConfig`, `UpdatePasswordlessConfig`
- _Bug Fix_
  - None
- _Change_
  - **OfflineNodes**
    - changes of request param
      - `* x-auth-token: optional -> required`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `DownloadErrorlog`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.95 2024-05-16

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Deprecate the APIs `UpdateDomainFullConfig`, `ShowDomainFullConfig`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.certificates`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.https.enc_certificate_value`
      - `+ configs.https.enc_private_key`
      - `+ configs.https.certificates`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListClients**
    - changes of response param
      - `* clients.idle: string -> int32`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `CreateStarrocksInstance`
    - `ListStarrocksInstanceInfo`
    - `DeleteStarrocksInstance`
    - `RestartStarrocksInstance`
    - `RestartStarrocksNode`
    - `CheckStarRocksResource`
    - `ListHtapDataStore`
    - `ListHtapStorageType`
    - `ListHtapFlavor`
    - `ListHtapInstanceInfo`
    - `ShowStarRocksDatabaseUser`
    - `CreateStarRocksDatabaseUser`
    - `DeleteStarRocksDatabaseUser`
    - `UpdateStarRocksDatabaseUserPassword`
    - `UpdateStarRocksDatabaseUserPermission`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the API `RestoreInstance`
- _Bug Fix_
  - None
- _Change_
  - **CreateDbInstance**
    - changes of request param
      - `+ enable_single_float_ip`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListCustomPolicies**
    - changes of response param
      - `* roles.policy.Statement.Resource: list<string> -> object`
  - **CreateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: list<string> -> object`
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **ShowCustomPolicy**
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **UpdateCloudServiceCustomPolicy**
    - changes of request param
      - `* role.policy.Statement.Resource: list<string> -> object`
    - changes of response param
      - `* role.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByToken**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`
  - **CreateTemporaryAccessKeyByAgency**
    - changes of request param
      - `* auth.identity.policy.Statement.Resource: list<string> -> object`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListLogs**
    - changes of request param
      - `+ __time__`
  - **ListStructuredLogsWithTimeRange**
    - changes of request param
      - `* time_range.start_time: string -> int64`
      - `* time_range.end_time: string -> int64`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ pdf_page_number`

# 3.1.94 2024-05-09

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
    - `ListObejectLevelCompareOverview`
    - `CreateObjectLevelCompareJob`
    - `ListObejectLevelCompareDetail`
    - `ListContentCompareDifference`
    - `DownloadCompareResultFile`
    - `CreateCompareResultFile`
    - `ShowHealthCompareJobDetail`
    - `ShowHealthObjectCompareJobOverview`
    - `UpdateComparePolicy`
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchValidateConnections**
    - changes of request param
      - `+ jobs.kafka_security_config.endpoint_algorithm`
      - `+ jobs.kafka_security_config.sasl_mechanism`
      - `+ jobs.kafka_security_config.delegation_tokens`
      - `+ jobs.kafka_security_config.enable_key_store`
      - `+ jobs.kafka_security_config.key_store_key`
      - `+ jobs.kafka_security_config.key_store_key_name`
      - `+ jobs.kafka_security_config.key_store_password`
      - `+ jobs.kafka_security_config.set_private_key_password`
      - `+ jobs.kafka_security_config.key_password`
      - `+ jobs.kafka_security_config.type: enum value [SASL_PLAINTEXT,SSL]`
  - **ShowJobList**
    - changes of response param
      - `+ jobs.children.job_direction: enum value [no-dbs]`
      - `- jobs.children.job_direction: enum value [non-dbs]`
  - **BatchUpdateJob**
    - changes of request param
      - `+ jobs.source_endpoint.kafka_security_config`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.source_endpoint.kafka_security_config`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.is_writable`
      - `+ jobs.compare_result.content_diff_detail_info`
      - `+ jobs.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.type: enum value [notify]`
  - **ShowJobDetail**
    - changes of request param
      - `+ type: enum value [is_writable,cloud_connection]`
    - changes of response param
      - `+ job.is_writable`
      - `+ job.compare_result.content_diff_detail_info`
      - `+ job.compare_result.content_compare_overview_infos.status: enum value [WAIT_FOR_COMPARE,CANCELED]`
  - **UpdateJob**
    - changes of request param
      - `+ job.type: enum value [notify]`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [set_writable,cloud_connection]`
      - `+ job.action_params.replay_config`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [set_writable,cloud_connection]`
      - `+ jobs.action_params.replay_config`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `ChangeVpc`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateFunctionCode**
    - changes of request param
      - `- depend_list`
  - **CreateFunction**
    - changes of request param
      - `+ gpu_type`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following APIs:
    - `ListStarRocksDataReplications`
    - `CreateStarRocksDataReplication`
    - `DeleteStarRocksDataReplication`
    - `CheckDataBaseConfig`
    - `CheckTableConfig`
    - `ListStarRocksDataReplicationConfig`
    - `ListStarRocksDbParameters`
    - `ListStarRocksDataBases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateTranscodingTask**
    - changes of request param
      - `+ video_process.hls_segment_type`

# 3.1.93 2024-04-30

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **EstimateExecutionPlanPrice**
    - changes of response param
      - `- currency: enum value [CNY,USD]`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ShowInstance**
    - changes of response param
      - `+ available_zone_names`
      - `+ enterprise_project_id`
  - **CreateTopicOrBatchDeleteTopic**
    - changes of request param
      - `+ queues`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
      - `- product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs)]`
  - **ListInstances**
    - changes of response param
      - `+ available_zone_names`
      - `+ enterprise_project_id`
      - `+ instances.available_zone_names`
      - `+ instances.enterprise_project_id`

# 3.1.92 2024-04-25

### HuaweiCloud SDK AAD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowUnblockRecord**
    - changes of response param
      - `* unblock_record.block_id: string -> int64`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDeployTaskDetail**
    - changes of response param
      - `+ is_disable`
      - `+ can_disable`
  - **ListDeployTasks**
    - changes of response param
      - `+ is_disable`
      - `+ can_disable`
      - `+ result.can_disable`
      - `+ result.is_disable`
  - **ListAllApp**
    - changes of response param
      - `+ result.is_disable`
      - `+ result.can_disable`
  - **ShowAppDetailById**
    - changes of response param
      - `+ result.is_disable`
      - `+ result.can_disable`
      - `+ result.arrange_infos.can_disable`
      - `+ result.arrange_infos.is_disable`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateMigrationTask**
    - changes of request param
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`
  - **ShowMigrationTask**
    - changes of response param
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`
  - **StopMigrationTask**
    - changes of response param
      - `+ source_instance.task_status`
      - `+ source_instance.id`
      - `+ source_instance.ip`
      - `+ source_instance.port`
      - `+ source_instance.name`
      - `+ source_instance.proxy_multi_db`
      - `+ source_instance.db`
      - `+ target_instance.ip`
      - `+ target_instance.port`
      - `+ target_instance.addrs`
      - `+ target_instance.proxy_multi_db`
      - `+ target_instance.db`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.availability_zone`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListDeviceProxies`
    - `CreateDeviceProxy`
    - `ShowDeviceProxy`
    - `UpdateDeviceProxy`
    - `DeleteDeviceProxy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateVideoModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateAudioStreamModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateDocumentModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateVideoStreamModerationJob**
    - changes of request param
      - `+ seed`
  - **RunCreateAudioModerationJob**
    - changes of request param
      - `+ seed`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeBankReceipt`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeBusinessLicense**
    - changes of response param
      - `+ result.organization_form`
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ formula`
    - changes of response param
      - `+ result.formula_result`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **ShowFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **UpdateFirewallRules**
    - changes of request param
      - `+ firewall.ingress_rules.enabled`
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **AddFirewallRules**
    - changes of request param
      - `+ firewall.ingress_rules.enabled`
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **RemoveFirewallRules**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **AssociateSubnetFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`
  - **DisassociateSubnetFirewall**
    - changes of response param
      - `+ firewall.ingress_rules.enabled`

# 3.1.91 2024-04-18

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **CountEvents**
    - changes of response param
      - `+ summary`
  - **UpdateAlarmRule**
    - changes of request param
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`
  - **AddAlarmRule**
    - changes of request param
      - `+ period: enum value [3600000]`
      - `- period: enum value [36000000]`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMigrationTask**
    - changes of response param
      - `+ migration_tasks.description`
      - `+ migration_tasks.source_instance_status`
      - `+ migration_tasks.target_instance_status`
      - `+ migration_tasks.source_instance_subnet_id`
      - `+ migration_tasks.target_instance_subnet_id`
      - `+ migration_tasks.source_instance_spec_code`
      - `+ migration_tasks.target_instance_spec_code`
      - `+ migration_tasks.error_message`
      - `+ migration_tasks.released_at`
      - `+ migration_tasks.version`
      - `+ migration_tasks.resume_mode`
      - `+ migration_tasks.supported_features`
  - **ShowMigrationTask**
    - changes of response param
      - `+ task_status`
      - `+ tenant_security_group_id`
      - `+ tenant_vpc_id`
      - `+ released_at`
      - `+ version`
      - `+ resume_mode`
      - `+ supported_features`
      - `+ bandwidth_limit_mb`
      - `+ tenant_subnet_id`
  - **StopMigrationTask**
    - changes of response param
      - `+ task_status`
      - `+ tenant_security_group_id`
      - `+ tenant_vpc_id`
      - `+ released_at`
      - `+ version`
      - `+ resume_mode`
      - `+ supported_features`
      - `+ bandwidth_limit_mb`
      - `+ tenant_subnet_id`
  - **ListBackgroundTask**
    - changes of response param
      - `+ tasks.details.old_resource_spec_code`
      - `+ tasks.details.new_resource_spec_code`
      - `+ tasks.details.old_replica_num`
      - `+ tasks.details.new_replica_num`
      - `+ tasks.details.old_cache_type`
      - `+ tasks.details.new_cache_type`
      - `+ tasks.details.replica_ip`
      - `+ tasks.details.replica_az`
      - `+ tasks.details.group_name`
      - `+ tasks.details.old_port`
      - `+ tasks.details.new_port`
      - `+ tasks.details.is_only_adjust_charging`
      - `+ tasks.details.account_name`
      - `+ tasks.details.source_ip`
      - `+ tasks.details.target_ip`
      - `+ tasks.details.node_name`
      - `+ tasks.details.rename_commands`
      - `+ tasks.details.updated_config_length`
  - **ListCenterTask**
    - changes of response param
      - `+ tasks.details.old_resource_spec_code`
      - `+ tasks.details.new_resource_spec_code`
      - `+ tasks.details.old_replica_num`
      - `+ tasks.details.new_replica_num`
      - `+ tasks.details.old_cache_type`
      - `+ tasks.details.new_cache_type`
      - `+ tasks.details.replica_ip`
      - `+ tasks.details.replica_az`
      - `+ tasks.details.group_name`
      - `+ tasks.details.old_port`
      - `+ tasks.details.new_port`
      - `+ tasks.details.is_only_adjust_charging`
      - `+ tasks.details.account_name`
      - `+ tasks.details.source_ip`
      - `+ tasks.details.target_ip`
      - `+ tasks.details.node_name`
      - `+ tasks.details.rename_commands`
      - `+ tasks.details.updated_config_length`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the APIs `ListTopIoTraffics`, `ShowErrorLogSwitchStatus`, `ListInstanceErrorLogs`, `DeleteInstanceTag`
- _Bug Fix_
  - None
- _Change_
  - Remove the API `ShowInstancesStatistics`
  - **UpgradeInstanceVersion**
    - changes of request param
      - `+ upgrade_action`
      - `- upgrde_action`
      - `- is_parallel_upgrade`
  - **ShowBackupPolicy**
    - changes of response param
      - `* backup_policy.differential_period: string -> int32`

### HuaweiCloud SDK TMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeleteResourceTag**
    - changes of request param
      - `+ tags.value`

# 3.1.90 2024-04-11

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowStackSetMetadata**
    - changes of response param
      - `+ managed_operation`
  - **UpdateStackSet**
    - changes of request param
      - `+ managed_operation`
  - **CreateStackSet**
    - changes of request param
      - `+ managed_operation`
  - **CreateStackInstance**
    - changes of request param
      - `+ operation_preferences`
  - **DeleteStackInstanceDeprecated**
    - changes of request param
      - `+ operation_preferences`
  - **UpdateStackInstances**
    - changes of request param
      - `+ operation_preferences`
  - **DeleteStackInstance**
    - changes of request param
      - `+ operation_preferences`
  - **DeployStackSet**
    - changes of request param
      - `+ operation_preferences`
  - **ShowStackSetOperationMetadata**
    - changes of response param
      - `+ operation_preferences`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ShowQuota`
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.sni`
      - `+ configs.request_url_rewrite`
      - `+ configs.browser_cache_rules`

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
    - `ListDataLevelTableCompareJobs`
    - `CreateDataLevelTableCompareJob`
    - `DeleteCompareJob`
    - `StartPromptlyDataLevelTableCompareJob`
    - `ListDataCompareOverview`
    - `ListDataCompareDetail`
    - `ListContentCompareOverview`
    - `ListContentCompareDetail`
    - `ListsAgencyPermissions`
    - `ShowReplayResults`
- _Bug Fix_
  - None
- _Change_
  - **ShowDataFilteringResult**
    - changes of response param
      - `+ db_object_filtering_result.source`
      - `+ db_object_filtering_result.target_result`
      - `+ db_object_filtering_result.source_result`
      - `+ db_object_filtering_result.target_message`
      - `+ db_object_filtering_result.source_message`
  - **ShowDataProgress**
    - changes of response param
      - `+ data_process_info.source`
  - **UpdateDataProgress**
    - changes of request param
      - `+ data_process_info.source`
  - **CheckDataFilter**
    - changes of request param
      - `+ data_process_info.source`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_params.compare_task_param.data_process_info`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_params.compare_task_param.data_process_info`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the following APIs:
    - `ShowInstancesStatistics`
    - `ShowSlowLogDownload`
    - `CreateSlowLogDownload`
    - `UpgradeInstanceVersion`
    - `SearchAutoEnlargePolicy`
    - `ListCnInfosBeforeReduce`
    - `StartInstance`
    - `ShowUpgradeCandidateVersions`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following APIs:
    - `ListRoutingBacklogPolicy`
    - `CreateRoutingBacklogPolicy`
    - `ShowRoutingBacklogPolicy`
    - `UpdateRoutingBacklogPolicy`
    - `DeleteRoutingBacklogPolicy`
    - `ListRoutingFlowControlPolicy`
    - `CreateRoutingFlowControlPolicy`
    - `ShowRoutingFlowControlPolicy`
    - `UpdateRoutingFlowControlPolicy`
    - `DeleteRoutingFlowControlPolicy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `* engine: optional -> required`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the API `BatchListAssociatedIssues`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstancesDetails**
    - changes of request param
      - `* engine: optional -> required`
      - `+ engine: enum value [rabbitmq]`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`
  - **StartResizeFlavorAction**
    - changes of request param
      - `+ resize_flavor.is_delay`
  - **ListPostgresqlDatabases**
    - changes of request param
      - `+ db`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `* engine: optional -> required`
      - `+ engine: enum value [rocketmq]`
      - `+ engine: enum value [reliability]`

### HuaweiCloud SDK SWR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSharedReposDetails**
    - changes of request param
      - `* center: optional -> required`

# 3.1.89 2024-04-03

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of request param
      - `+ src_region_name`
      - `+ dst_region_name`
    - changes of response param
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
  - **ListAccessControlLogs**
    - changes of request param
      - `+ src_region_name`
      - `+ dst_region_name`
  - **ListAddressSets**
    - changes of request param
      - `+ address_set_type`
  - **ListAttackLogs**
    - changes of request param
      - `+ attack_rule_id`
      - `+ src_region_name`
      - `+ dst_region_name`
  - **UpdateAclRuleOrder**
    - changes of request param
      - `+ bottom`
  - **ListServiceSetDetail**
    - changes of request param
      - `+ query_service_set_type`
  - **AddAclRule**
    - changes of request param
      - `+ rules.applications`
      - `+ rules.applicationsJsonString`
      - `+ rules.profile`
      - `+ rules.sequence.bottom`
      - `+ rules.source.address_set_type`
      - `+ rules.source.predefined_group`
      - `- rules.source.address_group`
      - `- rules.source.address_group_names`
      - `* rules.source: object<RuleAddressDto> -> object<RuleAddressDtoForRequest>`
      - `+ rules.service.protocols`
      - `+ rules.service.predefined_group`
      - `+ rules.service.service_set_type`
      - `+ rules.service.service_group_names.protocols`
      - `+ rules.service.service_group_names.service_set_type`
  - **UpdateAclRule**
    - changes of request param
      - `+ applications`
      - `+ applicationsJsonString`
      - `+ profile`
      - `+ sequence.bottom`
      - `+ source.address_set_type`
      - `+ source.predefined_group`
      - `+ source.address_group_names.protocols`
      - `+ source.address_group_names.service_set_type`
      - `+ service.protocols`
      - `+ service.predefined_group`
      - `+ service.service_set_type`
  - **ListAclRules**
    - changes of request param
      - `+ application`
    - changes of response param
      - `+ data.records.sequence.bottom`
      - `+ data.records.source.address_set_type`
      - `+ data.records.source.predefined_group`
      - `+ data.records.source.address_group_names.protocols`
      - `+ data.records.source.address_group_names.service_set_type`
      - `+ data.records.service.protocols`
      - `+ data.records.service.predefined_group`
      - `+ data.records.service.service_set_type`
  - **ListServiceItems**
    - changes of request param
      - `+ query_service_set_type`
  - **ListAddressItems**
    - changes of request param
      - `+ query_address_set_type`
  - **ListServiceSets**
    - changes of request param
      - `+ query_service_set_type`
  - **ListDomainSets**
    - changes of response param
      - `+ data.records.rules`
  - **ListFirewallDetail**
    - changes of request param
      - `+ name`
    - changes of response param
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`
  - **ListFirewallList**
    - changes of response param
      - `+ data.records.tags`
      - `+ data.records.flavor.default_bandwidth`
      - `+ data.records.flavor.default_eip_count`
      - `+ data.records.flavor.default_log_storage`
      - `+ data.records.flavor.default_vpc_count`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `ShowServerAutoRecovery`, `RegisterServerAutoRecovery`
  - **ResizePostPaidServer**
    - changes of request param
      - `+ resize.cpu_options`
  - **ShowServer**
    - changes of response param
      - `+ server.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ListServersDetails**
    - changes of response param
      - `+ servers.cpu_options.hw:cpu_threads: enum value [1,2]`
  - **ChangeServerOsWithCloudInit**
    - changes of request param
      - `+ os-change.isAutoPay`
  - **ChangeServerOsWithoutCloudInit**
    - changes of request param
      - `+ os-change.isAutoPay`
  - **ResizeServer**
    - changes of request param
      - `+ resize.cpu_options`
  - **CreateServers**
    - changes of request param
      - `+ server.cpu_options`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.cpu_options`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTenantVpcIgws**
    - changes of request param
      - `+ offset`
      - `+ marker`
  - **ListProjectGeipBindings**
    - changes of request param
      - `+ offset`
      - `+ marker`
    - changes of response param
      - `+ geip_bindings.instance_type`
      - `+ geip_bindings.instance_id`
      - `- geip_bindings.binding_instance_type`
      - `- geip_bindings.binding_instance_id`
      - `+ geip_bindings.gcbandwidth.id`
      - `+ geip_bindings.gcbandwidth.admin_status`
      - `+ geip_bindings.gcbandwidth.size`
      - `+ geip_bindings.gcbandwidth.short_id`
      - `+ geip_bindings.gcbandwidth.sla_level`
      - `+ geip_bindings.gcbandwidth.dscp`
      - `* geip_bindings.gcbandwidth: object -> object<BackboneBandwidthResp>`
      - `+ geip_bindings.vnic.private_ip_address`
      - `+ geip_bindings.vnic.device_id`
      - `+ geip_bindings.vnic.device_owner`
      - `+ geip_bindings.vnic.vpc_id`
      - `+ geip_bindings.vnic.port_id`
      - `+ geip_bindings.vnic.mac`
      - `+ geip_bindings.vnic.vtep`
      - `+ geip_bindings.vnic.vni`
      - `+ geip_bindings.vnic.instance_id`
      - `+ geip_bindings.vnic.instance_type`
      - `+ geip_bindings.vnic.port_profile`
      - `* geip_bindings.vnic: object -> object<InstanceVnicResp>`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDependencyVersion**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowDependencyVersion**
    - changes of response param
      - `+ is_shared`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencies**
    - changes of response param
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListDependencyVersion**
    - changes of response param
      - `+ dependencies.is_shared`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionCode**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionCode**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ImportFunction**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctions**
    - changes of response param
      - `+ functions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **CreateFunction**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - changes of response param
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ShowFunctionConfig**
    - changes of response param
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionConfig**
    - changes of request param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0,Custom Image]`
    - changes of response param
      - `+ enable_cloud_debug`
      - `+ is_return_stream`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **UpdateFunctionMaxInstanceConfig**
    - changes of response param
      - `+ is_return_stream`
      - `+ enable_cloud_debug`
      - `+ enable_auth_in_header`
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListBridgeFunctions**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListStatistics**
    - changes of response param
      - `+ gpu_gbs`
  - **CreateFunctionVersion**
    - changes of response param
      - `+ runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
      - `+ dependencies.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`
  - **ListFunctionVersions**
    - changes of response param
      - `- versions.enable_cloud_debug`
      - `+ versions.runtime: enum value [Java17,Python3.10,Node.js16.17,Node.js18.15,C#(.NET Core 6.0),Cangjie1.0]`

### HuaweiCloud SDK GEIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CountGlobalEips**
    - changes of response param
      - `+ global_eip`
      - `- global_eips`
      - `- page_info`
  - **BatchCreateGlobalEip**
    - changes of response param
      - `+ global_eips`
      - `- global_eip`
  - **CountGlobalEipSegment**
    - changes of response param
      - `+ global_eip_segment`
      - `- global_eip_segments`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowConnectorTask**
    - changes of response param
      - `+ topics_regex`
  - **CreateConnectorTask**
    - changes of response param
      - `+ topics_regex`
  - **ListConnectorTasks**
    - changes of response param
      - `+ topics_regex`
      - `+ tasks.topics_regex`

### HuaweiCloud SDK KMS

- _Features_
  - Support the APIs `GenerateMac`, `VerifyMac`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `ShowReplayDelayStatus`, `SwitchLogReplay`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateConsumerGroup**
    - changes of request param
      - `- from_beginning`
  - **ListMessageTrace**
    - changes of response param
      - `+ trace.trace_type: enum value [SubBefore,SubAfter]`
      - `- trace.trace_type: enum value [Sub]`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* max: number -> int32`
      - `* remaining: number -> int32`
      - `* next_offset: number -> int32`
      - `* previous_offset: number -> int32`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSubNetworkInterfaces**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`
  - **CreateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **BatchCreateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`
  - **ShowSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **UpdateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interface.security_enabled`
  - **MigrateSubNetworkInterface**
    - changes of response param
      - `+ sub_network_interfaces.security_enabled`

# 3.1.88 2024-04-01

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `- servers.image.name`
      - `- servers.image.__os_type`
      - `- servers.image.links`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `- server.image.name`
      - `- server.image.__os_type`
      - `- server.image.links`

### HuaweiCloud SDK KPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateKeypair**
    - changes of request param
      - `+ keypair.key_protection.encryption.kms_key_id`
  - **ImportPrivateKey**
    - changes of request param
      - `+ keypair.key_protection.encryption.kms_key_id`
    - changes of response param
      - `+ keypair.key_protection.encryption.kms_key_id`

# 3.1.87 2024-03-28

### HuaweiCloud SDK CBR

- _Features_
  - Support the following APIs:
    - `ListOrganizationPolicies`
    - `CreateOrganizationPolicy`
    - `ShowOrganizationPolicy`
    - `UpdateOrganizationPolicy`
    - `DeleteOrganizationPolicy`
    - `ListOrganizationPolicyDetail`
- _Bug Fix_
  - None
- _Change_
  - **ShowBackup**
    - changes of response param
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **UpdateBackup**
    - changes of response param
      - `+ backup.incremental`
      - `- backup.extend_info.incremental`
  - **ListBackups**
    - changes of response param
      - `+ backups.incremental`
      - `- backups.extend_info.incremental`
  - **ListVault**
    - changes of response param
      - `- sys_lock_source_service`
  - **CreateVault**
    - changes of request param
      - `+ vault.sys_lock_source_service`
  - **ListExternalVault**
    - changes of response param
      - `- sys_lock_source_service`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNodePoolConfigurationDetails**
    - changes of response param
      - `- kubelet`
  - **ShowClusterConfigurationDetails**
    - changes of response param
      - `- kube-apiserver`
  - **ShowCluster**
    - changes of response param
      - `- spec.enableAutopilot`
  - **UpdateCluster**
    - changes of response param
      - `- spec.enableAutopilot`
  - **DeleteCluster**
    - changes of request param
      - `+ lts_reclaim_policy`
    - changes of response param
      - `- spec.enableAutopilot`
  - **CreateCluster**
    - changes of request param
      - `- spec.enableAutopilot`
    - changes of response param
      - `- spec.enableAutopilot`
  - **ListClusters**
    - changes of response param
      - `- items.spec.enableAutopilot`

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of response param
      - `* data.records.bytes: int32 -> double`

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateTracker**
    - changes of request param
      - `+ agency_name`
  - **CreateTracker**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **ListTrackers**
    - changes of response param
      - `+ trackers.agency_name`
  - **UpdateNotification**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **CreateNotification**
    - changes of request param
      - `+ agency_name`
    - changes of response param
      - `+ agency_name`
  - **ListNotifications**
    - changes of response param
      - `+ notifications.agency_name`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunImageMediaTagging**
    - changes of request param
      - `- use_default_tags`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the API `UpdateApplication`
- _Bug Fix_
  - None
- _Change_
  - **CreateBatchTask**
    - changes of request param
      - `+ task_mode`
      - `+ task_ext_info`
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
  - **ListBatchTasks**
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtasks.task_mode`
      - `+ batchtasks.task_ext_info`
  - **ShowBatchTask**
    - changes of response param
      - `+ task_ext_info`
      - `+ task_mode`
      - `+ batchtask.task_mode`
      - `+ batchtask.task_ext_info`
  - **CreateOtaPackage**
    - changes of request param
      - `+ file_location.obs_location.sign`
    - changes of response param
      - `+ file_location.obs_location.sign`
  - **ShowOtaPackage**
    - changes of response param
      - `+ file_location.obs_location.sign`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the following APIs:
    - `ShowDiagnosisPreCheck`
    - `ListMessageDiagnosisReports`
    - `CreateMessageDiagnosisTask`
    - `BatchDeleteMessageDiagnosisReports`
    - `ShowMessageDiagnosisReport`
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ ipv6_enable`
  - **ShowInstance**
    - changes of response param
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
  - **ShowConnectorTask**
    - changes of response param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- ipv6_enable`
  - **ListInstances**
    - changes of response param
      - `+ broker_ssl_enable`
      - `+ new_auth_cert`
      - `+ available_zone_names`
      - `+ instances.broker_ssl_enable`
      - `+ instances.available_zone_names`
      - `+ instances.new_auth_cert`
  - **CreateConnectorTask**
    - changes of request param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
    - changes of response param
      - `+ source_task.rename_topic_enabled`
      - `- source_task.rename_topic_enable`
  - **ListConnectorTasks**
    - changes of response param
      - `+ tasks.source_task.rename_topic_enabled`
      - `- tasks.source_task.rename_topic_enable`
  - **CreateReassignmentTask**
    - changes of request param
      - `+ time_estimate`
    - changes of response param
      - `+ reassignment_time`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeMvsInvoice**
    - changes of response param
      - `+ result.reverse_issue`
  - **RecognizeThailandLicensePlate**
    - changes of response param
      - `+ result.province`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `BatchStopInstance`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMessageTrace**
    - changes of response param
      - `* trace.retry_times: string -> int32`
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster.small](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.2u8g.single.x86](tag:hcs),[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.2u8g.single.arm](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster.small,c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - changes of request param
      - `- createdAt`
      - `- permissions`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* groups.createdAt: string -> int64`
  - **BatchUpdateConsumerGroup**
    - changes of request param
      - `- groups.createdAt`
      - `- groups.permissions`
      - `* groups: list<ConsumerGroup> -> list<CreateOrUpdateConsumerGroup>`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [[4.8.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[5.x](tag:hcs)]`
      - `- engine_version: enum value [4.8.0]`
      - `+ product_id: enum value [[c6.4u8g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.4u16g.cluster.x86](tag:hcs),[c6.8u16g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.8u32g.cluster.x86](tag:hcs),[c6.12u24g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.16u64g.cluster.x86](tag:hcs),[c6.16u32g.cluster](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm)[c6.32u128g.cluster.x86](tag:hcs),[c6.4u16g.cluster.arm](tag:hcs),[c6.8u32g.cluster.arm](tag:hcs),[c6.16u64g.cluster.arm](tag:hcs),[c6.32u128g.cluster.arm](tag:hcs)]`
      - `- product_id: enum value [c6.4u8g.cluster,c6.8u16g.cluster,c6.12u24g.cluster,c6.16u32g.cluster]`

# 3.1.86 2024-03-21

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeletePromInstance**
    - changes of request param
      - `+ Enterprise-Project-Id`
  - **ListPromInstance**
    - changes of request param
      - `+ Enterprise-Project-Id`
      - `+ prom_type: enum value [default]`
      - `+ prom_type: enum value [DEFAULT]`
    - changes of response param
      - `+ prometheus.prom_type: enum value [default]`
      - `- prometheus.prom_type: enum value [DEFAULT]`

### HuaweiCloud SDK CCE

- _Features_
  - Support the API `ShowNodePoolConfigurationDetails`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVerifyDomainOwnerInfo**
    - changes of response param
      - `+ file_verify_domains`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateApp**
    - changes of request param
      - `+ group_id`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowPositionResult**
    - changes of response param
      - `+ status`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFunction**
    - changes of request param
      - `+ encrypted_user_data`
      - `+ mount_config`
      - `+ is_stateful_function`
      - `+ enable_dynamic_memory`
  - **UpdateVersionAlias**
    - changes of request param
      - `+ additional_version_strategy`
  - **DeleteFunctionTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`
  - **ShowFunctionTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`
  - **UpdateTrigger**
    - changes of request param
      - `+ trigger_type_code: enum value [IOTDA]`

### HuaweiCloud SDK GEIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSupportMasks**
    - changes of response param
      - `+ support_masks.ip_version: enum value [4,6]`
  - **ListGlobalEips**
    - changes of response param
      - `+ global_eips.ip_version: enum value [4,6]`
  - **DetachInternetBandwidth**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **BatchCreateGlobalEip**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ShowGlobalEip**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **AttachInternetBandwidth**
    - changes of response param
      - `+ global_eip.ip_version: enum value [4,6]`
  - **ListGlobalEipSegments**
    - changes of response param
      - `+ global_eip_segments.ip_version: enum value [4,6]`
  - **ShowGlobalEipSegment**
    - changes of response param
      - `+ global_eip_segment.ip_version: enum value [4,6]`
  - **ListGeipPools**
    - changes of response param
      - `+ geip_pools.ip_version: enum value [4,6]`

### HuaweiCloud SDK Live

- _Features_
  - Support the following APIs:
    - `ListOttChannelInfo`
    - `CreateOttChannelInfo`
    - `DeleteOttChannelInfo`
    - `ModifyOttChannelInfoEndPoints`
    - `ModifyOttChannelInfoInput`
    - `ModifyOttChannelInfoRecordSettings`
    - `ModifyOttChannelInfoGeneral`
    - `ModifyOttChannelInfoStats`
    - `ModifyOttChannelInfoEncoderSettings`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGatewaySnatRules**
    - changes of request param
      - `* floating_ip_address: string -> list<string>`
      - `* floating_ip_id: string -> list<string>`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeHouseholdRegister`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeSmartDocumentRecognizer**
    - changes of request param
      - `+ form`
      - `+ kv_map`
    - changes of response param
      - `+ result.form_result`
      - `+ result.layout_result.layout_block_list.table_id`
      - `+ result.layout_result.layout_block_list.form_id`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAutoEnlargePolicy**
    - changes of response param
      - `+ step_percent`
  - **SetAutoEnlargePolicy**
    - changes of request param
      - `+ step_percent`

# 3.1.85 2024-03-14

### HuaweiCloud SDK DRS

- _Features_
  - Support the API `ListAvailableNodeTypes`
- _Bug Fix_
  - None
- _Change_
  - **BatchSetPolicy**
    - changes of request param
      - `+ jobs.ddl_topic`
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.public_ip_list`
  - **ShowJobList**
    - changes of response param
      - `+ jobs.children.job_direction: enum value [non-dbs]`
      - `- jobs.children.job_direction: enum value [no-dbs]`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.public_ip_list`
      - `+ results.bind_public_ip_state`
      - `+ results.children`
  - **ShowUpdateObjectSavingStatus**
    - changes of response param
      - `+ job_id`
  - **CollectDbObjectsAsync**
    - changes of response param
      - `+ job_id`
  - **ShowDataProcessingRulesResult**
    - changes of response param
      - `+ job_id`
  - **CollectDbObjectsInfo**
    - changes of response param
      - `+ job_id`
  - **CollectPositionAsync**
    - changes of response param
      - `+ job_id`
  - **CollectColumns**
    - changes of response param
      - `+ job_id`
  - **CreateJob**
    - changes of request param
      - `+ job.public_ip_list`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.public_ip_list`
  - **UpdateDataProgress**
    - changes of response param
      - `+ job_id`
  - **CheckDataFilter**
    - changes of response param
      - `+ job_id`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.public_ip_list`
      - `+ jobs.bind_public_ip_state`
      - `+ jobs.children`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.public_ip_list`
      - `+ job.bind_public_ip_state`
      - `+ job.children`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [bind_eip,unbind_eip]`
      - `+ job.action_params.public_ip_config`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [bind_eip,unbind_eip]`
      - `+ jobs.action_params.public_ip_config`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowBinlogClearPolicy**
    - changes of response param
      - `+ binlog_clear_type`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddOrRemoveServicePermissions**
    - changes of response param
      - `- permission_type: enum value [domainId,orgPath]`
  - **ListServiceDescribeDetails**
    - changes of response param
      - `- service_type: enum value [interface]`
      - `* created_at: string -> date-time`
  - **ListServiceDetails**
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `- service_type: enum value [gataway,interface]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **UpdateEndpointService**
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServicePermissionsDetails**
    - changes of response param
      - `- permissions.permission_type: enum value [domainId,orgPath]`
      - `* permissions.created_at: string -> date-time`
  - **ListServicePublicDetails**
    - changes of response param
      - `- endpoint_services.service_type: enum value [interface,gateway]`
      - `* endpoint_services.created_at: string -> date-time`
  - **ListEndpointInfoDetails**
    - changes of response param
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `- enable_status: enum value [enable,disable]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **UpdateEndpointWhite**
    - changes of response param
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
  - **BatchAddOrRemoveResourceInstance**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [create,delete]`
      - `* body: object<BatchAddOrRemoveResourceInstanceBody> -> object<BatchAddOrRemoveResourceInstanceRequestBody>`
  - **ListQueryProjectResourceTags**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
  - **BatchAddEndpointServicePermissions**
    - changes of request param
      - `* body: object<BatchAddPermissionRequest> -> object<BatchAddEndpointServicePermissionsRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **BatchRemoveEndpointServicePermissions**
    - changes of request param
      - `* body: object<BatchRemovePermissionRequest> -> object<BatchRemoveEndpointServicePermissionsRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointServicePermissionDesc**
    - changes of request param
      - `* body: object<UpdatePermissionDescRequest> -> object<UpdateEndpointServicePermissionDescRequestBody>`
    - changes of response param
      - `* permissions.created_at: string -> date-time`
  - **UpdateEndpointPolicy**
    - changes of request param
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
    - changes of response param
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **DeleteEndpointPolicy**
    - changes of response param
      - `- enable_dns`
      - `- dns_names`
      - `- subnet_id`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `+ policy_statement.Effect: enum value [Allow,Refuse]`
  - **CreateEndpointService**
    - changes of request param
      - `+ service_type: enum value [gateway,interface]`
    - changes of response param
      - `- server_type: enum value [VM,VIP,LB]`
      - `- status: enum value [creating,available,failed]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `- tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListEndpointService**
    - changes of response param
      - `- endpoint_services.status: enum value [creating,available,failed]`
      - `- endpoint_services.service_type: enum value [VM,VIP,LB]`
      - `* endpoint_services.created_at: string -> date-time`
      - `* endpoint_services.updated_at: string -> date-time`
      - `- endpoint_services.tcp_proxy: enum value [close,toa_open,proxy_open,open,proxy_vni]`
  - **ListServiceConnections**
    - changes of request param
      - `+ status: enum value [pendingAcceptance,accepted,rejected,failed]`
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **AcceptOrRejectEndpoint**
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
  - **CreateEndpoint**
    - changes of response param
      - `- dns_names`
      - `- service_type: enum value [interface,gateway]`
      - `- status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* created_at: string -> date-time`
      - `* updated_at: string -> date-time`
      - `* policy_statement: list<string> -> list<PolicyStatement>`
  - **ListEndpoints**
    - changes of request param
      - `+ sort_key: enum value [create_at,update_at]`
      - `+ sort_dir: enum value [desc,asc]`
    - changes of response param
      - `- endpoint_pool_id`
      - `- endpoint_service_id`
      - `- vpc_id`
      - `- created_at`
      - `- description`
      - `- error`
      - `- updated_at`
      - `- enable_whitelist`
      - `- project_id`
      - `- marker_id`
      - `- id`
      - `- public_border_group`
      - `- policy_statement`
      - `- routetables`
      - `- endpoint_service_name`
      - `- ip`
      - `- whitelist`
      - `- tags`
      - `- enable_dns`
      - `- service_type`
      - `- active_status`
      - `- dns_names`
      - `- subnet_id`
      - `- status`
      - `- endpoints.service_type: enum value [interface,gateway]`
      - `- endpoints.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`
      - `* endpoints.created_at: string -> date-time`
      - `* endpoints.updated_at: string -> date-time`
      - `+ endpoints.policy_statement.Effect: enum value [Allow,Refuse]`
      - `* endpoints: list<EndpointResp> -> list<EndpointResponseBody>`
  - **ListQuotaDetails**
    - changes of response param
      - `- quotas.resources.type: enum value [endpoint_service,endpoint]`
      - `* quotas: object<ResourcesResp> -> object<ResourcesResponseBody>`
  - **ListVersionDetails**
    - changes of response param
      - `- versions.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- versions.id: enum value [v1]`
      - `* versions.updated: string -> date-time`
  - **ListSpecifiedVersionDetails**
    - changes of response param
      - `- version.status: enum value [CURRENT,SUPPORT,DEPRECATED]`
      - `- version.id: enum value [v1]`
      - `* version.updated: string -> date-time`
  - **ListResourceInstances**
    - changes of request param
      - `+ resource_type: enum value [endpoint_service,endpoint]`
      - `+ action: enum value [filter,count]`
  - **UpdateEndpointConnectionsDesc**
    - changes of request param
      - `* body: object<UpdateEpConnections> -> object<UpdateEndpointConnectionsDescRequestBody>`
    - changes of response param
      - `* connections.created_at: string -> date-time`
      - `* connections.updated_at: string -> date-time`
      - `- connections.status: enum value [pendingAcceptance,creating,accepted,rejected,failed,deleting]`

# 3.1.84 2024-03-07

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBareMetalServers**
    - changes of response param
      - `* servers.OS-SRV-USG:launched_at: date-time -> string`
      - `* servers.OS-SRV-USG:terminated_at: date-time -> string`
  - **ListBareMetalServerDetails**
    - changes of response param
      - `* server.OS-SRV-USG:launched_at: date-time -> string`
      - `* server.OS-SRV-USG:terminated_at: date-time -> string`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateSslSwitch**
    - changes of response param
      - `+ result`
      - `+ instance_id`
  - **ListClients**
    - changes of response param
      - `+ clients.fd`
      - `+ clients.network`
      - `+ clients.peer`
      - `+ clients.user`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the API `UpdateDatabases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddCertificate**
    - changes of response param
      - `+ template_id`
      - `+ provision_enable`
  - **ListCertificates**
    - changes of response param
      - `+ template_id`
      - `+ provision_enable`
      - `+ certificates.provision_enable`
      - `+ certificates.template_id`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following APIs:
    - `CreateDeleteConnectorOrder`
    - `ListSinkTasks`
    - `CreateSinkTask`
    - `ShowSinkTaskDetail`
    - `DeleteSinkTask`
  - **SendKafkaMessage**
    - changes of request param
      - `+ property_list.name`
      - `+ property_list.value`
  - **ShowConnectorTask**
    - changes of response param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ ipv6_enable`
  - **CreateConnectorTask**
    - changes of request param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
    - changes of response param
      - `* source_task.replication_factor: string -> int32`
      - `* source_task.task_num: string -> int32`
      - `* sink_task.target_db: string -> int32`
  - **ListConnectorTasks**
    - changes of response param
      - `* tasks.source_task.replication_factor: string -> int32`
      - `* tasks.source_task.task_num: string -> int32`
      - `* tasks.sink_task.target_db: string -> int32`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeIdCard**
    - changes of request param
      - `+ return_portrait_image`
      - `+ return_adjusted_image`
    - changes of response param
      - `+ result.portrait_image`
      - `+ result.adjusted_image`
      - `+ result.front.portrait_image`
      - `+ result.front.adjusted_image`
      - `+ result.back.adjusted_image`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `ShowStorageUsedSpace`
    - `SwitchSqlLimit`
    - `UpdateSqlLimit`
    - `ListSqlLimit`
    - `CreateSqlLimit`
    - `DeleteSqlLimit`
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `* instances.volume: object<Volume> -> object<VolumeForInstanceResponse>`
  - **CreateRestoreInstance**
    - changes of request param
      - `- replica_of_id`
      - `- unchangeable_param`

# 3.1.83 2024-02-29

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAddressSets**
    - changes of request param
      - `+ query_address_set_type`
    - changes of response param
      - `+ data.records.object_id`
      - `+ data.records.address_set_type`
  - **UpdateAclRuleOrder**
    - changes of response param
      - `+ data.name`
  - **AddBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **UpdateBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **DeleteBlackWhiteList**
    - changes of response param
      - `+ data.name`
  - **ChangeIpsProtectMode**
    - changes of response param
      - `+ data.name`
  - **AddServiceSet**
    - changes of response param
      - `+ data.name`
  - **ListServiceSetDetail**
    - changes of response param
      - `+ data.service_set_type`
  - **UpdateServiceSet**
    - changes of response param
      - `+ data.name`
  - **DeleteServiceSet**
    - changes of response param
      - `+ data.name`
  - **DeleteServiceItem**
    - changes of response param
      - `+ data.name`
  - **CreateFirewall**
    - changes of request param
      - `- flavor.version: enum value [Platinum]`
    - changes of response param
      - `- data.flavor.version: enum value [Platinum]`
  - **ChangeEipStatus**
    - changes of response param
      - `+ data.id`
  - **DeleteAddressItem**
    - changes of response param
      - `+ data.name`
  - **AddAddressSet**
    - changes of response param
      - `+ data.name`
  - **ListAddressSetDetail**
    - changes of request param
      - `+ query_address_set_type`
    - changes of response param
      - `+ data.address_set_type`
  - **UpdateAddressSet**
    - changes of response param
      - `* data: object<IdObject> -> object<UpdateAddressSetResponseData>`
  - **DeleteAddressSet**
    - changes of response param
      - `+ data.name`
  - **CreateEastWestFirewall**
    - changes of response param
      - `+ data.name`
  - **ListEastWestFirewall**
    - changes of response param
      - `+ data.protect_infos.status`
  - **AddAclRule**
    - changes of response param
      - `+ data.rules.name`
  - **DeleteAclRule**
    - changes of response param
      - `+ data.name`
  - **UpdateAclRule**
    - changes of response param
      - `+ data.name`
  - **ListAclRules**
    - changes of response param
      - `+ data.records.created_date`
      - `+ data.records.last_open_time`
  - **AddServiceItems**
    - changes of response param
      - `+ data.items.name`
  - **AddAddressItem**
    - changes of response param
      - `+ data.items.name`
  - **ListServiceSets**
    - changes of response param
      - `+ data.records.service_set_type`
      - `+ data.records.project_id`
      - `+ data.records.protocols`
  - **ListProtectedVpcs**
    - changes of response param
      - `+ data.total_assets`
  - **ListFirewallDetail**
    - changes of response param
      - `+ data.records.is_available_obs`
      - `+ data.records.is_support_threat_tags`
  - **ListFirewallList**
    - changes of response param
      - `+ is_support_postpaid`
      - `+ is_support_buy_professional`
      - `+ has_ndr`
      - `+ is_support_basic_version`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateFunctionTrigger**
    - changes of response param
      - `+ event_data.triggerid`
      - `+ event_data.api_id`
      - `+ event_data.api_name`
      - `+ event_data.invoke_url`
      - `+ event_data.roma_app_id`
      - `+ event_data.db_user`
      - `+ event_data.instance_addrs`
      - `+ event_data.mode`
      - `* event_data: object<TriggerEventDataRequestBody> -> object<TriggerEventDataResponseBody>`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowRule**
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **UpdateRule**
    - changes of request param
      - `+ actions.smn_forwarding.message_template_name`
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **CreateRule**
    - changes of request param
      - `+ actions.smn_forwarding.message_template_name`
    - changes of response param
      - `+ actions.smn_forwarding.message_template_name`
  - **ListRules**
    - changes of response param
      - `+ rules.actions.smn_forwarding.message_template_name`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the following APIs:
    - `ListConnectorTasks`
    - `CreateConnectorTask`
    - `ShowConnectorTask`
    - `DeleteConnectorTask`
    - `PauseConnectorTask`
    - `ResumeConnectorTask`
    - `RestartConnectorTask`
- _Bug Fix_
  - None
- _Change_
  - **ShowInstance**
    - changes of response param
      - `+ connector_node_num`
  - **CreateSinkTask**
    - changes of request param
      - `+ obs_destination_descriptor.partition_format: enum value [yyyy,yyyy/MM,yyyy/MM/dd,yyyy/MM/dd/HH,yyyy/MM/dd/HH/mm]`
  - **ListInstances**
    - changes of response param
      - `+ connector_node_num`
      - `+ instances.connector_node_num`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStream**
    - changes of request param
      - `+ log_stream_name_alias`
      - `+ enterprise_project_name`

# 3.1.82 2024-02-22

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateDashboardWidgets**
    - changes of request param
      - `* body: list<BaseWidgetInfo> -> list<object>`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ModifyGaussMySqlProxyRouteMode**
    - changes of request param
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListRecycleInstances**
    - changes of response param
      - `+ instances.engine_name`
      - `+ instances.volume_size`
      - `+ instances.enterprise_project_name`
      - `+ instances.backup_level`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of response param
      - `+ images.__image_displayname`
  - **UpdateImage**
    - changes of response param
      - `+ __image_displayname`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeTrainTicket**
    - changes of response param
      - `+ result.invoice_style`
      - `+ result.issue_date`
      - `+ result.discount_mark`
      - `+ result.serial_number`
      - `+ result.tax_amount`
      - `+ result.tax_rate`
      - `+ result.air_conditioning`
      - `+ result.original_invoice_number`
      - `+ result.unified_social_credit_code`
      - `+ result.buyer_name`
      - `+ result.total_amount_excluding_tax`
      - `+ result.invoice_number`
      - `+ result.seal_mark`
      - `+ result.title`
      - `+ result.area`
      - `+ result.receipt_number`
      - `+ result.amount_in_figures`
      - `+ result.amount_in_words`

# 3.1.81 2024-02-20

### HuaweiCloud SDK DCS

- _Features_
  - Support the APIs `ListClients`, `ScanClients`, `HangUpClients`, `HangUpKillAllClients`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.80 2024-02-07

### HuaweiCloud SDK GEIP

- _Features_
  - Support `GEIP`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EIP

- _Features_
  - Support the following APIs:
    - `ListTenantVpcIgws`
    - `CreateTenantVpcIgw`
    - `ShowInternalVpcIgw`
    - `UpdateTenantVpcIgw`
    - `DeleteTenantVpcIgw`
    - `ListProjectGeipBindings`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the API `UpdateNewNodeAutoAddSwitch`
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlProxy**
    - changes of request param
      - `+ new_node_auto_add_status`
      - `+ new_node_weight`
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.new_node_auto_add_status`
      - `+ proxy_list.proxy.new_node_weight`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the API `StopBackup`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `UpdateDatabaseOwner`
    - `ExecutePrivilegeDatabaseUserRole`
    - `ExecuteRevokeDatabaseUserRole`
    - `ListDatabaseUserRole`
    - `UpdatePostgresqlExtension`
- _Bug Fix_
  - None
- _Change_
  - **ListPostgresqlExtension**
    - changes of response param
      - `+ extensions.version_update`

# 3.1.79 2024-02-01

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEvents**
    - changes of response param
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **PushEvents**
    - changes of request param
      - `* events.annotations: map<string, string> -> map<string, object>`
      - `* events.attach_rule: map<string, string> -> map<string, object>`
  - **CreatePromInstance**
    - changes of request param
      - `+ region`

### HuaweiCloud SDK AOS

- _Features_
  - Support the APIs `CreatePrivateProvider`, `CreatePrivateProviderVersion`
- _Bug Fix_
  - None
- _Change_
  - **GetExecutionPlan**
    - changes of response param
      - `+ execution_plan_items.imported`
  - **GetExecutionPlanMetadata**
    - changes of response param
      - `+ summary.resource_import`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ShowLogs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlInstance**
    - changes of request param
      - `+ tde_info`
  - **ShowGaussMySqlInstanceInfoUnifyStatus**
    - changes of response param
      - `+ instance.tde_info`
  - **ListGaussMySqlInstanceDetailInfoUnifyStatus**
    - changes of response param
      - `+ instances.tde_info`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `CreateShrinkageJob`, `ShowShrinkCheckResult`, `UpdateSinkTaskQuota`
  - **CreateInstanceTopic**
    - changes of response param
      - `- id`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGatewayDnatRules**
    - changes of request param
      - `+ marker`
  - **ListNatGatewaySnatRules**
    - changes of request param
      - `+ marker`
  - **ListNatGateways**
    - changes of request param
      - `+ marker`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `StartInstanceReduceVolumeAction`
    - `UpdateHostPrivilege`
    - `ShowIncreBackupPolicy1`
    - `UpdateIncreBackupPolicy1`
    - `ListRdSforMySqlProxy`
    - `DeleteRdSforMySqlProxy`
    - `ModifyRdSforMySqlProxyRouteMode`
    - `RestartRdSforMysqlProxy`
    - `ListRdSforMysqlProxyFlavors`
    - `CreateRdSforMySqlProxy`
- _Bug Fix_
  - None
- _Change_
  - **SetAuditlogPolicy**
    - changes of request param
      - `+ audit_types`
  - **CreateDbUser**
    - changes of request param
      - `+ is_privilege`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowGroup**
    - changes of response param
      - `* retry_max_time: number -> int32`
  - **UpdateConsumerGroup**
    - changes of request param
      - `* retry_max_time: number -> int32`
  - **ResetConsumeOffset**
    - changes of request param
      - `* timestamp: number -> string`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - changes of request param
      - `+ createdAt`
      - `+ permissions`
      - `+ consume_orderly`
      - `- from_beginning`
      - `* retry_max_time: number -> int32`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`
  - **BatchUpdateConsumerGroup**
    - changes of request param
      - `+ groups.createdAt`
      - `+ groups.permissions`
      - `+ groups.consume_orderly`
      - `- groups.from_beginning`
      - `* groups.retry_max_time: number -> int32`

# 3.1.78 2024-01-25

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeleteserviceDiscoveryRules**
    - changes of response param
      - `+ id`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlReadonlyNode**
    - changes of request param
      - `+ availability_zones`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeAutoClassification**
    - changes of request param
      - `+ detect_seal`
    - changes of response param
      - `+ result.seal_mark`
  - **RecognizeVatInvoice**
    - changes of response param
      - `+ result.province`
      - `+ result.city`
      - `+ result.belong_buyer_name`
      - `+ result.belong_seller_name`
      - `+ result.belong_vat_code`
      - `+ result.belong_number`
      - `+ result.belong_pages`
      - `+ result.belong_current_page`
      - `+ result.belong_remarks`
      - `+ result.belong_issue_date`
      - `+ result.sales_mark`
      - `+ result.belong_sum_amount`
      - `+ result.belong_sum_tax`
      - `+ result.belong_subtotal_amount`
      - `+ result.belong_subtotal_tax`
      - `+ result.belong_discount_amount`
      - `+ result.belong_discount_tax`
      - `+ result.belong_item_list`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of request param
      - `+ is_serverless`
  - **ListInstances**
    - changes of response param
      - `+ instances.serverless_info`
  - **CreateInstance**
    - changes of request param
      - `+ serverless_info`
  - **CreateRestoreInstance**
    - changes of request param
      - `+ serverless_info`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAssetByFileUpload**
    - changes of request param
      - `* category_id: string -> int32`
  - **CreateAssetProcessTask**
    - changes of request param
      - `+ hls_storage_type`
  - **ListTopStatistics**
    - changes of response param
      - `- top_urls.duration_ms`
  - **ListAssetList**
    - changes of response param
      - `- assets.duration_ms`
  - **ShowTakeOverAssetDetails**
    - changes of response param
      - `- base_info.meta_data.duration_ms`
  - **PublishAssets**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - changes of response param
      - `- asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - changes of response param
      - `- base_info.meta_data.duration_ms`
  - **ShowTakeOverTaskDetails**
    - changes of response param
      - `- assets.base_info.meta_data.duration_ms`

# 3.1.77 2024-01-18

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPromInstance**
    - changes of request param
      - `+ prom_status: enum value [DELETED,NORMAL,ALL]`
      - `+ prom_status: enum value [true,false]`
    - changes of response param
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.application`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
  - **CreatePromInstance**
    - changes of request param
      - `- prom_id`
      - `- cce_spec`
      - `- prom_config`
      - `- prom_create_timestamp`
      - `- prom_update_timestamp`
      - `- prom_status`
      - `- is_deleted_tag`
      - `- deleted_time`
      - `- prom_spec_config`
      - `- cce_spec_config`
      - `- application`
      - `- prom_type: enum value [DEFAULT]`
      - `* body: object<PromInstanceEpsModel> -> object<PromInstanceRequestModel>`
    - changes of response param
      - `- prometheus.cce_spec`
      - `- prometheus.prom_config`
      - `- prometheus.is_deleted_tag`
      - `- prometheus.application`
      - `- prometheus.prom_type: enum value [DEFAULT]`
      - `+ prometheus.prom_status: enum value [DELETED,NORMAL,ALL]`
      - `* prometheus: list<PromInstanceEpsModel> -> list<PromInstanceEpsCreateModel>`
  - **AddOrUpdateServiceDiscoveryRules**
    - changes of response param
      - `+ id`
      - `+ results`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **DeleteCluster**
    - changes of response param
      - `+ spec.enableAutopilot`
  - **CreateCluster**
    - changes of request param
      - `+ spec.enableAutopilot`
    - changes of response param
      - `+ spec.enableAutopilot`
  - **ListClusters**
    - changes of response param
      - `+ items.spec.enableAutopilot`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowTopUrl**
    - changes of request param
      - `+ service_area: enum value [global]`

### HuaweiCloud SDK CDN

- _Features_
  - Support the API `ListCdnDomainTopRefers`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `ChangeMasterStandbyAsync`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
  - **ListLoadbalancers**
    - changes of response param
      - `+ loadbalancers.billing_info`
      - `+ loadbalancers.protection_status`
      - `+ loadbalancers.protection_reason`
  - **CreateLoadbalancer**
    - changes of response param
      - `+ loadbalancer_id`
      - `+ order_id`
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ShowLoadbalancer**
    - changes of response param
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **UpdateLoadbalancer**
    - changes of response param
      - `+ loadbalancer.billing_info`
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizeSeal`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeFlightItinerary**
    - changes of response param
      - `+ result.tax`
      - `+ result.tax_rate`
      - `+ result.buyer_name`
      - `+ result.buyer_id`
      - `+ result.number`
      - `+ result.international_flag`
      - `+ result.issue_status`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAuditlogPolicy**
    - changes of response param
      - `+ all_audit_log_action`
      - `+ audit_types`
  - **ListRecycleInstances**
    - changes of response param
      - `+ instances.is_serverless`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ValidateConsumedMessage**
    - changes of request param
      - `+ topic`

# 3.1.76 2024-01-11

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateNodePool**
    - changes of response param
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<UpdateNodePoolStatus>`
  - **CreateNodePool**
    - changes of response param
      - `- status.jobId`
      - `* status: object<NodePoolStatus> -> object<CreateNodePoolStatus>`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchValidateConnections**
    - changes of request param
      - `+ jobs.customized_dns`

### HuaweiCloud SDK DRS

- _Features_
  - Support the following APIs:
    - `BatchCreateTags`
    - `BatchDeleteTags`
    - `ListInstanceByTags`
    - `CountInstanceByTags`
    - `ListInstanceTags`
    - `ListTags`
    - `UpdateJobConfigurations`
    - `ListJobParameters`
    - `ListJobHistoryParameters`
- _Bug Fix_
  - None
- _Change_
  - **ListLinks**
    - changes of response param
      - `+ job_links.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **ListJobs**
    - changes of request param
      - `+ engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
    - changes of response param
      - `+ jobs.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.children.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
  - **CreateJob**
    - changes of request param
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.source_endpoint.customized_dns`
      - `+ jobs.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.source_endpoint.config.node_num`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ jobs.params.source_endpoint.customized_dns`
      - `+ jobs.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.params.source_endpoint.config.node_num`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.source_endpoint.customized_dns`
      - `+ job.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.source_endpoint.config.node_num`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.base_info.engine_type: enum value [redis-to-gaussredis,rediscluster-to-gaussredis]`
      - `+ job.params.source_endpoint.customized_dns`
      - `+ job.params.source_endpoint.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.params.source_endpoint.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.params.source_endpoint.config.node_num`
  - **ExecuteJobAction**
    - changes of request param
      - `+ job.action_name: enum value [column_limit,reload_parameters]`
      - `+ job.action_params.endpoints.customized_dns`
      - `+ job.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ job.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ job.action_params.endpoints.config.node_num`
  - **BatchExecuteJobActions**
    - changes of request param
      - `+ jobs.action_name: enum value [column_limit,reload_parameters]`
      - `+ jobs.action_params.endpoints.customized_dns`
      - `+ jobs.action_params.endpoints.db_type: enum value [redis,rediscluster,gaussredis]`
      - `+ jobs.action_params.endpoints.endpoint.endpoint_name: enum value [redis,ecs_redis,rediscluster,ecs_rediscluster,cloud_gaussdb_redis]`
      - `+ jobs.action_params.endpoints.config.node_num`

### HuaweiCloud SDK ECS

- _Features_
  - Support the API `NovaShowServerInterface`
- _Bug Fix_
  - None
- _Change_
  - **UpdateServer**
    - changes of response param
      - `+ server.OS-EXT-SRV-ATTR:user_data`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCertificate**
    - changes of response param
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **UpdateCertificate**
    - changes of response param
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **CreateCertificate**
    - changes of response param
      - `+ tenant_id`
      - `+ create_time`
      - `+ certificate`
      - `+ description`
      - `+ expire_time`
      - `+ private_key`
      - `+ type`
      - `+ update_time`
      - `+ admin_state_up`
      - `+ domain`
      - `+ name`
      - `+ id`
  - **ListHealthmonitors**
    - changes of response param
      - `+ healthmonitors`
  - **CreateHealthmonitor**
    - changes of response param
      - `+ healthmonitor`
  - **ShowHealthmonitors**
    - changes of response param
      - `+ healthmonitor`
  - **UpdateHealthmonitor**
    - changes of response param
      - `+ healthmonitor`
  - **ListMembers**
    - changes of response param
      - `+ members`
  - **CreateMember**
    - changes of response param
      - `+ member`
  - **ShowMember**
    - changes of response param
      - `+ member`
  - **UpdateMember**
    - changes of response param
      - `+ member`
  - **ShowLoadbalancer**
    - changes of response param
      - `+ loadbalancer`
  - **UpdateLoadbalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer`
  - **ListL7rules**
    - changes of response param
      - `+ rules`
  - **CreateL7rule**
    - changes of response param
      - `+ rule`
  - **ShowL7rule**
    - changes of response param
      - `+ rule`
  - **UpdateL7rule**
    - changes of response param
      - `+ rule`
  - **ListPools**
    - changes of response param
      - `+ pools`
  - **CreatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool`
  - **ShowPool**
    - changes of response param
      - `+ pool`
  - **UpdatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool`
  - **ListListeners**
    - changes of response param
      - `+ listeners`
  - **CreateListener**
    - changes of response param
      - `+ listener`
  - **ShowListener**
    - changes of response param
      - `+ listener`
  - **UpdateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
    - changes of response param
      - `+ listener`
  - **CreateLoadbalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer`
  - **ListLoadbalancers**
    - changes of response param
      - `+ loadbalancers.publicips`
      - `+ loadbalancers.charge_mode`
      - `+ loadbalancers.frozen_scene`
  - **ListL7policies**
    - changes of response param
      - `+ l7policies`
  - **CreateL7policy**
    - changes of response param
      - `+ l7policy`
  - **UpdateL7policies**
    - changes of response param
      - `+ l7policy`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPools**
    - changes of request param
      - `+ connection_drain`
    - changes of response param
      - `+ pools.connection_drain`
  - **CreatePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ShowPool**
    - changes of response param
      - `+ pool.connection_drain`
  - **UpdatePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ListMasterSlavePools**
    - changes of request param
      - `+ connection_drain`
    - changes of response param
      - `+ pools.connection_drain`
  - **CreateMasterSlavePool**
    - changes of request param
      - `+ pool.connection_drain`
    - changes of response param
      - `+ pool.connection_drain`
  - **ShowMasterSlavePool**
    - changes of response param
      - `+ pool.connection_drain`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateReassignmentTask**
    - changes of request param
      - `+ is_schedule`
      - `+ execute_at`

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTranscodingTask**
    - changes of response param
      - `+ task_array.progress`
  - **ListTranscodeDetail**
    - changes of response param
      - `+ task_array.progress`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeIdCard**
    - changes of request param
      - `+ detect_tampering`
      - `+ detect_border_integrity`
      - `+ detect_blocking_within_border`
      - `+ detect_blur`
      - `+ detect_interim`
      - `+ detect_glare`
    - changes of response param
      - `+ result.detect_tampering_result`
      - `+ result.detect_border_integrity_result`
      - `+ result.detect_blocking_within_border_result`
      - `+ result.detect_blur_result`
      - `+ result.detect_interim_result`
      - `+ result.detect_glare_result`
      - `+ result.score_info`
      - `+ result.front`
      - `+ result.back`
      - `+ result.verification_result.valid_validity_period`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ eps_id`
  - **BatchRestoreDatabase**
    - changes of request param
      - `+ instances.is_fast_restore`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddressGroup**
    - changes of response param
      - `+ address_group.ip_extra_set`
  - **UpdateAddressGroup**
    - changes of request param
      - `+ address_group.ip_extra_set`
    - changes of response param
      - `+ address_group.ip_extra_set`
  - **ListAddressGroup**
    - changes of response param
      - `+ address_groups.ip_extra_set`
  - **CreateAddressGroup**
    - changes of request param
      - `+ address_group.ip_extra_set`
    - changes of response param
      - `+ address_group.ip_extra_set`

# 3.1.75 2024-01-04

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNotifiedHistories**
    - changes of response param
      - `+ notified_histories`
      - `- event_sn`
      - `- notifications`
  - **ListEvent2alarmRule**
    - changes of response param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* : list<event2alarmRuleBody> -> list<Event2alarmRuleBody>`
  - **UpdateEventRule**
    - changes of request param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **AddEvent2alarmRule**
    - changes of request param
      - `+ event_names`
      - `+ migrated`
      - `+ topics`
      - `+ trigger_policies.trigger_type: enum value [immediately]`
      - `- trigger_policies.trigger_type: enum value [notification]`
      - `+ alarm_type: enum value [notification,denoising]`
      - `* body: object<event2alarmRuleBody> -> object<Event2alarmRuleBody>`
  - **ListMuteRule**
    - changes of response param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **UpdateMuteRule**
    - changes of request param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **AddMuteRules**
    - changes of request param
      - `* mute_config.scope: list<string> -> list<integer>`
  - **ShowActionRule**
    - changes of response param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListEvents**
    - changes of response param
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **PushEvents**
    - changes of request param
      - `* events.metadata: object -> map<string, string>`
      - `* events.annotations: object -> map<string, string>`
      - `* events.attach_rule: object -> map<string, string>`
  - **UpdateActionRule**
    - changes of request param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **AddActionRule**
    - changes of request param
      - `+ type: enum value [1,2]`
      - `- type: enum value ["1","2"]`
  - **ListActionRule**
    - changes of response param
      - `+ action_rules.type: enum value [1,2]`
      - `- action_rules.type: enum value ["1","2"]`
  - **ListMetricItems**
    - changes of response param
      - `+ metaData.offset`
      - `+ metaData.nextToken`
      - `- metaData.start`
      - `* metaData: object<metaData> -> object<MetaDataSeries>`
  - **UpdateAlarmRule**
    - changes of request param
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **AddAlarmRule**
    - changes of request param
      - `+ is_turn_on`
      - `- id_turn_on`
      - `+ comparison_operator: enum value [<,>,<=,>=]`
      - `+ period: enum value [60000,300000,900000,36000000]`
  - **ListServiceDiscoveryRules**
    - changes of response param
      - `+ id`
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`
  - **AddOrUpdateServiceDiscoveryRules**
    - changes of request param
      - `+ appRules.desc`
      - `+ appRules.spec.dataSource`
      - `+ appRules.spec.editable`
      - `+ appRules.spec.aom_metric_relabel_configs`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAccessCode**
    - changes of request param
      - `+ force_disconnect`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the API `ResetMessageOffsetWithEngine`
- _Bug Fix_
  - None
- _Change_
  - **ShowGroups**
    - changes of response param
      - `* group.group_message_offsets.message_current_offset: int32 -> int64`
      - `* group.group_message_offsets.message_log_end_offset: int32 -> int64`
  - **ResetMessageOffset**
    - changes of request param
      - `* message_offset: int32 -> int64`
      - `* timestamp: int32 -> int64`
  - **ShowMessages**
    - changes of response param
      - `* messages.message_offset: int32 -> int64`
  - **ShowInstanceMessages**
    - changes of response param
      - `* messages.message_offset: int32 -> int64`

### HuaweiCloud SDK MPC

- _Features_
  - Support the APIs `ShowTenantAccessInfo`, `UpdateTenantAccessInfo`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `- action: enum value [restart]`
  - **ListInstancesDetails**
    - changes of request param
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **SetOffSiteBackupPolicy**
    - changes of request param
      - `* policy_para: list<OffSiteBackupPolicy> -> object<OffSiteBackupPolicy>`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResizeInstance**
    - changes of request param
      - `+ publicip_id`

### HuaweiCloud SDK SMN

- _Features_
  - Support the following APIs:
    - `PublishHttpDetect`
    - `ShowHttpDetectResult`
    - `BatchUpdateSubscriptionsFilterPolices`
    - `BatchCreateSubscriptionsFilterPolices`
    - `BatchDeleteSubscriptionsFilterPolices`
    - `AddSubscriptionFromSubscriptionUser`
- _Bug Fix_
  - None
- _Change_
  - Deprecate the following APIs:
    - `ListApplicationAttributes`
    - `UpdateApplication`
    - `DeleteApplication`
    - `ListApplicationEndpointAttributes`
    - `UpdateApplicationEndpoint`
    - `DeleteApplicationEndpoint`
    - `PublishAppMessage`
    - `CreateApplication`
    - `ListApplications`
    - `CreateApplicationEndpoint`
    - `ListApplicationEndpoints`
  - **PublishMessage**
    - changes of request param
      - `+ message_attributes`
  - **ListTopics**
    - changes of request param
      - `+ fuzzy_display_name`
  - **ListSubscriptions**
    - changes of request param
      - `+ fuzzy_remark`
    - changes of response param
      - `+ subscriptions.filter_polices`
  - **ListSubscriptionsByTopic**
    - changes of request param
      - `+ fuzzy_remark`
    - changes of response param
      - `+ subscriptions.filter_polices`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPorts**
    - changes of response param
      - `+ ports.ipv6_bandwidth_id`
  - **CreatePort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`
  - **ShowPort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`
  - **UpdatePort**
    - changes of response param
      - `+ port.ipv6_bandwidth_id`

# 3.1.74 2023-12-27

### HuaweiCloud SDK AAD

- _Features_
  - Support the following APIs:
    - `CreateAadDomain`
    - `CreateCertificate`
    - `ModifyDomainWebSwitch`
    - `ListSourceIps`
    - `AddBlackWhiteIpList`
    - `DeleteBlackWhiteIpList`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CSMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListResourceInstances**
    - changes of response param
      - `+ resources.sys_tags`

### HuaweiCloud SDK DCS

- _Features_
  - Support the APIs `ShowInstanceSslDetail`, `UpdateSslSwitch`, `DownloadSslCert`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DDS

- _Features_
  - Support the API `ShowClientNetwork`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the API `ListJobs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - Support the APIs `CreateShrinkageJob`, `ShowShrinkCheckResult`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `SetInstancesNewDbShrink`, `StopBackup`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.73 2023-12-22

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowGroups**
    - changes of response param
      - `* group.group_message_offsets.lag: int32 -> int64`
  - **ShowInstanceTopicDetail**
    - changes of response param
      - `* partitions.replicas.lag: int32 -> int64`

# 3.1.72 2023-12-21

### HuaweiCloud SDK Core

- _Features_
  - None
- _Bug Fix_
  - Solve the issue of inconsistent English letter case conversion rules in different cultures.
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingConfig**
    - changes of request param
      - `+ instance_config.disk.iops`
      - `+ instance_config.disk.throughput`
      - `+ instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`
  - **ListScalingConfigs**
    - changes of response param
      - `+ scaling_configurations.instance_config.disk.iops`
      - `+ scaling_configurations.instance_config.disk.throughput`
      - `+ scaling_configurations.instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`
  - **ShowScalingConfig**
    - changes of response param
      - `+ scaling_configuration.instance_config.disk.iops`
      - `+ scaling_configuration.instance_config.disk.throughput`
      - `+ scaling_configuration.instance_config.disk.volume_type: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `ValidateDeletableReplica`
- _Bug Fix_
  - None
- _Change_
  - **ShowExpireKeyScanInfo**
    - changes of request param
      - `+ offset`
      - `+ limit`
      - `+ status`

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobs**
    - changes of request param
      - `+ jobs.engine_type: enum value [mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
      - `+ jobs.source_endpoint.db_type: enum value [taurus]`
  - **BatchValidateConnections**
    - changes of request param
      - `+ jobs.db_type: enum value [taurus]`
  - **ShowJobList**
    - changes of request param
      - `+ engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
  - **BatchUpdateJob**
    - changes of request param
      - `+ jobs.engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
      - `+ jobs.source_endpoint.db_type: enum value [taurus]`
  - **BatchListJobDetails**
    - changes of response param
      - `+ results.source_endpoint.db_type: enum value [taurus]`
      - `+ results.inst_info.engine_type: enum value [gaussdbv5,postgresql,mysql-to-kafka,taurus-to-kafka,gaussdbv5ha-to-kafka]`
  - **ShowJobDetail**
    - changes of request param
      - `+ type: enum value [compare]`
      - `+ type: enum value [comapre]`
      - `+ query_type: enum value [diff]`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateServerTags**
    - changes of request param
      - `* tags: list<ServerTag> -> list<BatchAddServerTag>`
  - **UpdateServer**
    - changes of request param
      - `+ server.user_data`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the APIs `UpdateDisassociatePublicip`, `UpdateAssociatePublicip`

### HuaweiCloud SDK IVS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DetectStandardByNameAndId**
    - changes of request param
      - `+ data.req_data.detail`
      - `+ data.req_data.crop`
  - **DetectStandardByIdCardImage**
    - changes of request param
      - `+ data.req_data.detail`
      - `+ data.req_data.crop`
  - **DetectStandardByVideoAndIdCardImage**
    - changes of request param
      - `+ data.req_data.detail`
  - **DetectStandardByVideoAndNameAndId**
    - changes of request param
      - `+ data.req_data.detail`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the API `SendKafkaMessage`
- _Bug Fix_
  - None
- _Change_
  - Remove the API `CreatePartition`
  - **UpdateInstanceTopic**
    - changes of request param
      - `+ topics.new_partition_brokers`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* groups.lag: int32 -> int64`
  - **ListInstances**
    - changes of request param
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateTranscodingTask**
    - changes of request param
      - `+ video_process.hls_storage_type`

### HuaweiCloud SDK VOD

- _Features_
  - Support the APIs `ListAssetDailySummaryLog`, `UpdateStorageMode`, `ShowVodRetrieval`
- _Bug Fix_
  - None
- _Change_
  - **ShowTakeOverAssetDetails**
    - changes of response param
      - `+ transcode_info.output.group_id`
      - `+ transcode_info.output.group_name`
  - **PublishAssets**
    - changes of response param
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **UnpublishAssets**
    - changes of response param
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **ShowAssetMeta**
    - changes of response param
      - `+ asset_info_array.is_multi_transcode`
      - `+ asset_info_array.play_info_array.group_id`
      - `+ asset_info_array.play_info_array.group_name`
  - **ShowAssetDetail**
    - changes of response param
      - `+ transcode_info.output.group_id`
      - `+ transcode_info.output.group_name`
  - **ShowTakeOverTaskDetails**
    - changes of response param
      - `+ assets.transcode_info.output.group_id`
      - `+ assets.transcode_info.output.group_name`

# 3.1.71 2023-12-14

### HuaweiCloud SDK BMS

- _Features_
  - Support the API `DeleteBaremetalServer`
- _Bug Fix_
  - None
- _Change_
  - **CreateBareMetalServers**
    - changes of request param
      - `+ server.root_volume.volumetype: enum value [GPSSD]`
      - `+ server.data_volumes.volumetype: enum value [GPSSD]`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAlarmTemplates**
    - changes of request param
      - `+ template_type: enum value [system_event,custom_event,system_custom_event]`
  - **CreateAlarmTemplate**
    - changes of request param
      - `+ template_type`
      - `+ policies.period: enum value [0]`
  - **UpdateAlarmTemplate**
    - changes of request param
      - `+ policies.period: enum value [0]`

### HuaweiCloud SDK CFW

- _Features_
  - Support the APIs `CreateFirewall`, `ListJob`, `DeleteFirewall`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowResInstanceInfo**
    - changes of response param
      - `+ resources.resource_detail.detailId`
      - `- resources.resource_detail.resource_id`
      - `- resources.resource_detail.func_urn`
      - `- resources.resource_detail.func_name`
      - `- resources.resource_detail.domain_id`
      - `- resources.resource_detail.namespace`
      - `- resources.resource_detail.project_name`
      - `- resources.resource_detail.package`
      - `- resources.resource_detail.runtime`
      - `- resources.resource_detail.timeout`
      - `- resources.resource_detail.handler`
      - `- resources.resource_detail.memory_size`
      - `- resources.resource_detail.gpu_memory`
      - `- resources.resource_detail.cpu`
      - `- resources.resource_detail.code_type`
      - `- resources.resource_detail.code_url`
      - `- resources.resource_detail.code_filename`
      - `- resources.resource_detail.code_size`
      - `- resources.resource_detail.user_data`
      - `- resources.resource_detail.encrypted_user_data`
      - `- resources.resource_detail.digest`
      - `- resources.resource_detail.version`
      - `- resources.resource_detail.image_name`
      - `- resources.resource_detail.xrole`
      - `- resources.resource_detail.app_xrole`
      - `- resources.resource_detail.description`
      - `- resources.resource_detail.last_modified`
      - `- resources.resource_detail.func_vpc_id`
      - `- resources.resource_detail.strategy_config`
      - `- resources.resource_detail.extend_config`
      - `- resources.resource_detail.initializer_handler`
      - `- resources.resource_detail.initializer_timeout`
      - `- resources.resource_detail.pre_stop_handler`
      - `- resources.resource_detail.pre_stop_timeout`
      - `- resources.resource_detail.enterprise_project_id`
      - `- resources.resource_detail.long_time`
      - `- resources.resource_detail.log_group_id`
      - `- resources.resource_detail.log_stream_id`
      - `- resources.resource_detail.type`
      - `- resources.resource_detail.fail_count`
      - `- resources.resource_detail.is_bridge_function`
      - `- resources.resource_detail.bind_bridge_funcUrns`
      - `* resources.resource_detail: object<ListFunctionResult> -> object<ListEnterpriseResourceDetail>`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAsyncCommand**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ShowAsyncDeviceCommand**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **BroadcastMessage**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **CreateCommand**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ListProperties**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
    - changes of response param
      - `+ request_id`
  - **UpdateProperties**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
    - changes of response param
      - `+ request_id`
  - **CloseDeviceTunnel**
    - changes of request param
      - `+ Sp-Auth-Token`
  - **DeleteDeviceTunnel**
    - changes of request param
      - `+ Sp-Auth-Token`
  - **ShowDeviceTunnel**
    - changes of request param
      - `+ Sp-Auth-Token`
  - **AddTunnel**
    - changes of request param
      - `+ Sp-Auth-Token`
  - **ListDeviceTunnels**
    - changes of request param
      - `+ Sp-Auth-Token`
  - **ShowDeviceMessage**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **CreateMessage**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`
  - **ListDeviceMessages**
    - changes of request param
      - `+ Stage-Auth-Token`
      - `+ Sp-Auth-Token`

### HuaweiCloud SDK Live

- _Features_
  - Support the following APIs:
    - `ListDelayConfig`
    - `UpdateDelayConfig`
    - `ShowPullSourcesConfig`
    - `UpdatePullSourcesConfig`
    - `ListGeoBlockingConfig`
    - `UpdateGeoBlockingConfig`
    - `CreateUrlAuthchain`
    - `ListIpAuthList`
    - `UpdateIpAuthList`
    - `ListPublishTemplate`
    - `UpdatePublishTemplate`
    - `DeletePublishTemplate`
- _Bug Fix_
  - None
- _Change_
  - **ListRecordContents**
    - changes of request param
      - `+ record_type: enum value [PLAN_RECORD,ON_DEMAND_RECORD]`
    - changes of response param
      - `- record_contents.record_type: enum value [PLAN_RECORD,ON_DEMAND_RECORD]`

### HuaweiCloud SDK LTS

- _Features_
  - Support the API `CreateAgencyAccess`
- _Bug Fix_
  - None
- _Change_
  - **ListSqlAlarmRules**
    - changes of response param
      - `+ sql_alarm_rules.is_css_sql`
      - `+ sql_alarm_rules.notification_frequency`
      - `+ sql_alarm_rules.alarm_action_rule_name`
      - `+ sql_alarm_rules.status: enum value [RUNNING 启用,STOPPING 停止]`
      - `- sql_alarm_rules.status: enum value [RUNNING,STOPPING]`
      - `* sql_alarm_rules.frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **UpdateSqlAlarmRule**
    - changes of request param
      - `+ is_css_sql`
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `* frequency: object<Frequency> -> object<CreateSqlAlarmRuleFrequency>`
    - changes of response param
      - `+ is_css_sql`
      - `+ alarm_action_rule_name`
      - `+ notification_frequency`
      - `+ language: enum value [zh-cn,en-us]`
      - `* frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **CreateSqlAlarmRule**
    - changes of request param
      - `+ is_css_sql`
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `* frequency: object<Frequency> -> object<CreateSqlAlarmRuleFrequency>`
  - **ListKeywordsAlarmRules**
    - changes of response param
      - `+ keywords_alarm_rules.notification_frequency`
      - `+ keywords_alarm_rules.alarm_action_rule_name`
      - `+ keywords_alarm_rules.status: enum value [RUNNING  启用,STOPPING  停止]`
      - `- keywords_alarm_rules.status: enum value [RUNNING,STOPPING]`
  - **UpdateKeywordsAlarmRule**
    - changes of request param
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
    - changes of response param
      - `+ alarm_action_rule_name`
      - `+ notification_frequency`
      - `+ language: enum value [zh-cn,en-us]`
      - `- keywords_requests.search_time_range_unit: enum value [minute]`
      - `* keywords_requests: list<KeywordsRequest> -> list<KeywordsResBody>`
      - `* frequency: object<Frequency> -> object<FrequencyRespBody>`
  - **CreateKeywordsAlarmRule**
    - changes of request param
      - `+ notification_frequency`
      - `+ alarm_action_rule_name`
      - `+ keywords_alarm_level: enum value [Critical]`
      - `- keywords_alarm_level: enum value [CRITICAL]`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateNatGatewayTag**
    - changes of request param
      - `+ tag.key`
      - `+ tag.value`
      - `* tag: object -> object<TagBody>`

### HuaweiCloud SDK RDS

- _Features_
  - Support the APIs `ListLogLtsConfigs`, `SetLogLtsConfigs`, `DeleteLogLtsConfigs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateRocketMqMigrationTask**
    - changes of request param
      - `+ topicConfigTable`
      - `+ subscriptionGroupTable`
      - `+ vhosts`
      - `+ queues`
      - `+ exchanges`
      - `+ bindings`
      - `* body: map<string, object> -> object<CreateRocketMqMigrationTaskReq>`

# 3.1.70 2023-12-07

### HuaweiCloud SDK AOS

- _Features_
  - Support the API `DeleteStackInstance`
- _Bug Fix_
  - None
- _Change_
  - **ListStackSetOperations**
    - changes of response param
      - `+ stack_set_operations.action: enum value [UPDATE_STACK_INSTANCES]`
  - **ShowStackSetOperationMetadata**
    - changes of response param
      - `+ action: enum value [UPDATE_STACK_INSTANCES]`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following APIs:
    - `ShowDependcy`
    - `UpdateDependcy`
    - `DeleteDependency`
    - `AsyncInvokeReservedFunction`
    - `CreateDependency`
  - **ShowFuncReservedInstanceMetrics**
    - changes of request param
      - `+ marker`
      - `+ limit`
  - **ListFunctionApplications**
    - changes of request param
      - `+ limit`
      - `+ marker`
  - **ListStatistics**
    - changes of request param
      - `+ limit`
      - `+ marker`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the APIs `ListGaussMySqlInstancesUnifyStatus`, `ShowGaussMySqlInstanceInfoUnifyStatus`, `ListGaussMySqlInstanceDetailInfoUnifyStatus`, `SwitchGaussMySqlProxySsl`
- _Bug Fix_
  - None
- _Change_
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.ssl_option`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the API `OfflineNodes`
- _Bug Fix_
  - None
- _Change_
  - **ListLtsConfigs**
    - changes of response param
      - `* instance_lts_configs.instance.supported_log_types: string -> list<string>`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResetDeviceSecret**
    - changes of request param
      - `+ secret_type`
    - changes of response param
      - `+ secret_type`
  - **ResetFingerprint**
    - changes of request param
      - `+ fingerprint_type`
    - changes of response param
      - `+ fingerprint_type`
  - **ShowDevice**
    - changes of response param
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`
  - **UpdateDevice**
    - changes of response param
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`
  - **AddDevice**
    - changes of response param
      - `+ auth_info.secondary_secret`
      - `+ auth_info.secondary_fingerprint`
      - `* auth_info: object<AuthInfo> -> object<AuthInfoRes>`

### HuaweiCloud SDK NAT

- _Features_
  - Support the following APIs:
    - `ListNatGatewayByTag`
    - `BatchCreateDeleteNatGatewayTag`
    - `ShowNatGatewayTag`
    - `CreateNatGatewayTag`
    - `DeleteNatGatewayTag`
    - `ListNatGatewayTag`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the APIs `ShowRocketMqConfigs`, `UpdateRocketMqConfigs`
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ status: enum value [UPGRADING,UPGRADINGFAILED]`

# 3.1.69 2023-11-30

### HuaweiCloud SDK AOM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPermissions**
    - changes of response param
      - `* : map<string, AuthModel> -> string`
  - **ListAccessCode**
    - changes of response param
      - `- access_codes.status: enum value [enable,unenable]`

### HuaweiCloud SDK CCE

- _Features_
  - Support the following APIs:
    - `ShowClusterConfig`
    - `UpdateClusterLogConfig`
    - `ListPartitions`
    - `CreatePartition`
    - `ShowPartition`
    - `UpdatePartition`
    - `ShowNodePoolConfigurations`
    - `UpdateNodePoolConfiguration`
    - `ShowClusterConfigurationDetails`
    - `ListCharts`
    - `UploadChart`
    - `ShowChart`
    - `UpdateChart`
    - `DeleteChart`
    - `DownloadChart`
    - `ShowChartValues`
    - `ShowUserChartsQuotas`
    - `ListReleases`
    - `CreateRelease`
    - `ShowRelease`
    - `UpdateRelease`
    - `DeleteRelease`
    - `ShowReleaseHistory`
- _Bug Fix_
  - None
- _Change_
  - **ResizeCluster**
    - changes of request param
      - `* extendParam: object<ResizeClusterRequestExtendParam> -> object`
  - **UpdateClusterEip**
    - changes of request param
      - `* spec: object -> object<MasterEIPRequestSpec>`
    - changes of response param
      - `* spec: object -> object<MasterEIPResponseSpec>`
  - **ShowClusterEndpoints**
    - changes of response param
      - `* spec: object -> object<OpenAPISpec>`
  - **ShowAddonInstance**
    - changes of response param
      - `- status.status: enum value [unknown]`
  - **UpdateAddonInstance**
    - changes of response param
      - `- status.status: enum value [unknown]`
  - **RollbackAddonInstance**
    - changes of response param
      - `- status.status: enum value [unknown]`
  - **ShowCluster**
    - changes of response param
      - `+ spec.enableMasterVolumeEncryption`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.enableMasterVolumeEncryption`
  - **DeleteCluster**
    - changes of request param
      - `+ ondemand_node_policy`
      - `+ periodic_node_policy`
    - changes of response param
      - `+ spec.enableMasterVolumeEncryption`
  - **CreateAddonInstance**
    - changes of response param
      - `- status.status: enum value [unknown]`
  - **ListAddonInstances**
    - changes of response param
      - `- items.status.status: enum value [unknown]`
  - **CreateCluster**
    - changes of request param
      - `+ spec.enableMasterVolumeEncryption`
    - changes of response param
      - `+ spec.enableMasterVolumeEncryption`
  - **ListClusters**
    - changes of request param
      - `+ status: enum value [Hibernating,Hibernation,Awaking]`
    - changes of response param
      - `+ items.spec.enableMasterVolumeEncryption`
  - **ShowNode**
    - changes of response param
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **UpdateNode**
    - changes of response param
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **DeleteNode**
    - changes of response param
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **CreateNode**
    - changes of request param
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
    - changes of response param
      - `+ spec.hostnameConfig`
      - `+ spec.extendParam.kubeReservedMem`
      - `+ spec.extendParam.systemReservedMem`
      - `+ spec.extendParam.init-node-password`
      - `- spec.extendParam.kube-reserved-mem`
      - `- spec.extendParam.system-reserved-mem`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.hostnameConfig`
      - `+ items.spec.extendParam.kubeReservedMem`
      - `+ items.spec.extendParam.systemReservedMem`
      - `+ items.spec.extendParam.init-node-password`
      - `- items.spec.extendParam.kube-reserved-mem`
      - `- items.spec.extendParam.system-reserved-mem`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **UpdateNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **AddNode**
    - changes of request param
      - `+ nodeList.spec.hostnameConfig`
  - **ResetNode**
    - changes of request param
      - `+ nodeList.spec.hostnameConfig`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
    - changes of response param
      - `+ spec.nodeTemplate.hostnameConfig`
      - `+ spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ spec.nodeTemplate.extendParam.init-node-password`
      - `- spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- spec.nodeTemplate.extendParam.system-reserved-mem`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.hostnameConfig`
      - `+ items.spec.nodeTemplate.extendParam.kubeReservedMem`
      - `+ items.spec.nodeTemplate.extendParam.systemReservedMem`
      - `+ items.spec.nodeTemplate.extendParam.init-node-password`
      - `- items.spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `- items.spec.nodeTemplate.extendParam.system-reserved-mem`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSlowlog**
    - changes of response param
      - `+ total_num`

### HuaweiCloud SDK EIP

- _Features_
  - Support the APIs `BatchModifyBandwidth`, `ListEipBandwidths`, `ListBandwidthsLimit`, `UpdatePublicip`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the API `ListInfluxdbSlowLogs`
- _Bug Fix_
  - None
- _Change_
  - **ListLtsConfigs**
    - changes of response param
      - `+ instance_lts_configs.instance.supported_log_types`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunQueryDocumentModerationJob**
    - changes of response param
      - `+ result.details.start_position`
      - `+ result.details.end_position`
      - `+ result.details.image_url`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `SetInstancesDbShrink`
- _Bug Fix_
  - None
- _Change_
  - **UpgradeDbMajorVersion**
    - changes of response param
      - `+ job_id`
  - **ShowUpgradeDbMajorVersionStatus**
    - changes of response param
      - `+ check_expiration_time`
      - `- report_expiration_time`
  - **StartResizeFlavorAction**
    - changes of response param
      - `+ order_id`
  - **StartInstanceEnlargeVolumeAction**
    - changes of response param
      - `+ order_id`
  - **StartInstanceSingleToHaAction**
    - changes of response param
      - `+ order_id`
  - **ListHistoryDatabase**
    - changes of request param
      - `+ engine`
      - `- database_name`

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the APIs `ShowEngineInstanceExtendProductInfo`, `ResizeInstance`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeFlashAsr**
    - changes of request param
      - `* obs_bucket_name: optional -> required`
      - `* obs_object_key: optional -> required`

# 3.1.68 2023-11-23

### HuaweiCloud SDK CFW

- _Features_
  - Support the APIs `ListLogConfig`, `UpdateLogConfig`, `AddLogConfig`, `CreateEastWestFirewall`
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of response param
      - `* data.records.start_time: int32 -> int64`
      - `* data.records.end_time: int32 -> int64`
      - `* data.records.src_port: string -> int32`
      - `* data.records.dst_port: string -> int32`
  - **ListAccessControlLogs**
    - changes of response param
      - `* data.records.hit_time: int32 -> int64`
      - `* data.records.src_port: string -> int32`
      - `* data.records.dst_port: string -> int32`
  - **ChangeIpsSwitchStatus**
    - changes of request param
      - `+ X-Language`
  - **ListAttackLogs**
    - changes of response param
      - `* data.records.event_time: string -> int64`
      - `* data.records.attack_rule_id: int32 -> string`
      - `* data.records.packet: object<Packet> -> string`

# 3.1.67 2023-11-23

### HuaweiCloud SDK AOM

- _Features_
  - Support the following APIs:
    - `ListPromInstance`
    - `CreatePromInstance`
    - `DeletePromInstance`
    - `CreateRecordingRule`
    - `ListPermissions`
    - `ListAccessCode`
    - `ListAgents`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the API `LogoffWebCli`
- _Bug Fix_
  - None
- _Change_
  - **ListSlowlog**
    - changes of response param
      - `+ slowlogs.database_id`
      - `+ slowlogs.username`

### HuaweiCloud SDK DDS

- _Features_
  - Support the following APIs:
    - `ListLtsConfigs`
    - `UpdateLtsConfig`
    - `DeleteLtsConfig`
    - `ListLtsErrorLogs`
    - `ShowKillOpRuleRuleList`
    - `UpdateKillOpRule`
    - `CreateKillOpRule`
    - `DeleteKillOpRuleList`
    - `SwitchInstancePrimary`
    - `DeleteReadonlyNode`
    - `StopBackup`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchDeleteJobs**
    - changes of request param
      - `+ jobs.is_show_breakpoint_position`
  - **BatchSetPolicy**
    - changes of request param
      - `+ jobs.file_and_position`
      - `+ jobs.gtid_set`
  - **BatchListProgresses**
    - changes of response param
      - `+ results.incre_trans_delay_millis`
  - **ShowJobList**
    - changes of request param
      - `+ instance_ids`
      - `+ instance_ip`

### HuaweiCloud SDK DRS

- _Features_
  - Support the APIs `UploadJdbcDriver`, `ListJdbcDrivers`, `DeleteJdbcDriver`, `SyncJdbcDriver`
- _Bug Fix_
  - None
- _Change_
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.policy_config.dml_types`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.connection_management`
      - `+ jobs.policy_config.dml_types`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.params.policy_config.dml_types`
  - **ShowJobDetail**
    - changes of response param
      - `+ job.connection_management`
      - `+ job.policy_config.dml_types`
  - **UpdateJob**
    - changes of request param
      - `+ job.params.policy_config.dml_types`

### HuaweiCloud SDK ELB

- _Features_
  - Support the following APIs:
    - `BatchAddAvailableZones`
    - `BatchRemoveAvailableZones`
    - `ListMasterSlavePools`
    - `CreateMasterSlavePool`
    - `ShowMasterSlavePool`
    - `DeleteMasterSlavePool`
- _Bug Fix_
  - None
- _Change_
  - **ShowLoadBalancer**
    - changes of response param
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`
  - **UpdateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.ipv6_vip_address`
    - changes of response param
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`
  - **ListListeners**
    - changes of response param
      - `+ listeners.ssl_early_data_enable`
  - **CreateListener**
    - changes of request param
      - `+ listener.ssl_early_data_enable`
    - changes of response param
      - `+ listener.ssl_early_data_enable`
  - **ShowListener**
    - changes of response param
      - `+ listener.ssl_early_data_enable`
  - **UpdateListener**
    - changes of request param
      - `+ listener.ssl_early_data_enable`
    - changes of response param
      - `+ listener.ssl_early_data_enable`
  - **ListLoadBalancers**
    - changes of request param
      - `+ log_topic_id`
      - `+ log_group_id`
    - changes of response param
      - `+ loadbalancers.charge_mode`
      - `+ loadbalancers.log_group_id`
      - `+ loadbalancers.log_topic_id`
  - **CreateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.ipv6_vip_address`
    - changes of response param
      - `+ loadbalancer.charge_mode`
      - `+ loadbalancer.log_group_id`
      - `+ loadbalancer.log_topic_id`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the following APIs:
    - `ListAppTemplates`
    - `ShowAppTemplate`
    - `ListFunctionApplications`
    - `CreateFunctionApp`
    - `ShowFunctionApp`
    - `DeleteFunctionApp`
    - `CreateCallbackWorkflow`
- _Bug Fix_
  - None
- _Change_
  - **ImportFunction**
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListFunctions**
    - changes of response param
      - `+ functions.pre_stop_handler`
      - `+ functions.pre_stop_timeout`
  - **CreateFunction**
    - changes of request param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ShowFunctionConfig**
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **UpdateFunctionConfig**
    - changes of request param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **UpdateFunctionMaxInstanceConfig**
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListBridgeFunctions**
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ShowResInstanceInfo**
    - changes of response param
      - `+ resources.resource_detail.pre_stop_handler`
      - `+ resources.resource_detail.pre_stop_timeout`
  - **CreateFunctionVersion**
    - changes of response param
      - `+ pre_stop_handler`
      - `+ pre_stop_timeout`
  - **ListFunctionVersions**
    - changes of response param
      - `+ versions.pre_stop_handler`
      - `+ versions.pre_stop_timeout`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the API `ShowRestoreTables`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the following APIs:
    - `ShowElbIpGroup`
    - `SwitchIpGroup`
    - `ListInstancesSession`
    - `DeleteInstancesSession`
    - `ListInstancesSessionStatistics`
    - `ResetParamGroupTemplate`
    - `ListRedisSlowLogs`
    - `ListCassandraSlowLogs`
    - `ListMongodbSlowLogs`
    - `ListLtsConfigs`
    - `SaveLtsConfigs`
    - `DeleteLtsConfigs`
    - `ListRestoreDatabases`
    - `ListRestoreTables`
    - `ListMongodbErrorLogs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - Support the APIs `ShowKafkaUserClientQuota`, `UpdateKafkaUserClientQuotaTask`, `CreateKafkaUserClientQuotaTask`, `DeleteKafkaUserClientQuotaTask`
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ status: enum value [DELETING,ERROR,CREATEFAILED,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [FAULTY,RESIZING,RESIZING FAILED]`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeIdCard**
    - changes of request param
      - `+ return_portrait_location`
    - changes of response param
      - `+ result.portrait_location`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstancesDetails**
    - changes of request param
      - `+ status: enum value [DELETING,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [STARTING,CLOSING]`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following APIs:
    - `UpgradeDbMajorVersion`
    - `ShowAvailableVersion`
    - `UpgradeDbMajorVersionPreCheck`
    - `ListInspectionHistories`
    - `ListUpgradeHistories`
    - `ShowUpgradeDbMajorVersionStatus`
    - `UpdateTdeStatus`
    - `ShowTdeStatus`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ status: enum value [DELETING,ERROR,CREATEFAILED,FREEZING,EXTENDING,SHRINKING,EXTENDEDFAILED,CONFIGURING,UPGRADING,UPGRADINGFAILED,ROLLBACK,ROLLBACKFAILED,VOLUMETYPECHANGING]`
      - `+ status: enum value [FAULTY,RESIZING,RESIZING FAILED]`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAssetByFileUpload**
    - changes of request param
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **PublishAssetFromObs**
    - changes of request param
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **CreateAssetProcessTask**
    - changes of request param
      - `+ thumbnail.quantity`
      - `+ thumbnail.quantity_time`
      - `+ thumbnail.type: enum value [quantity]`
  - **ListTopStatistics**
    - changes of response param
      - `+ top_urls.duration_ms`
  - **UploadMetaDataByUrl**
    - changes of request param
      - `+ upload_metadatas.thumbnail.quantity`
      - `+ upload_metadatas.thumbnail.quantity_time`
      - `+ upload_metadatas.thumbnail.type: enum value [quantity]`
  - **ListAssetList**
    - changes of response param
      - `+ assets.duration_ms`
  - **ShowTakeOverAssetDetails**
    - changes of response param
      - `+ base_info.meta_data.duration_ms`
  - **PublishAssets**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **UnpublishAssets**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetMeta**
    - changes of response param
      - `+ asset_info_array.base_info.meta_data.duration_ms`
  - **ShowAssetDetail**
    - changes of response param
      - `+ base_info.meta_data.duration_ms`
      - `+ thumbnail_info.quantity`
  - **ShowTakeOverTaskDetails**
    - changes of response param
      - `+ assets.base_info.meta_data.duration_ms`

# 3.1.66 2023-11-16

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.remark`
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.url_auth.key`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.expire_time`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.weight`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.sources.weight`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`

### HuaweiCloud SDK CodeArtsBuild

- _Features_
  - Support the following APIs:
    - `DownloadBuildLog`
    - `DownloadTaskLog`
    - `ShowFlowGraph`
    - `ShowRecordDetail`
    - `ShowOutputInfo`
    - `StopJob`
    - `CreateBuildJob`
    - `UpdateBuildJob`
    - `ListTemplates`
    - `CreateTemplates`
    - `DeleteTemplates`
    - `ListNotice`
    - `UpdateNotice`
    - `DisableNotice`
    - `ListJobConfig`
- _Bug Fix_
  - None
- _Change_
  - **ShowRecordInfo**
    - changes of response param
      - `+ result.duration`

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreatePrivateZone**
    - changes of request param
      - `+ router.status`
  - **AssociateRouter**
    - changes of request param
      - `+ router.status`
  - **DisassociateRouter**
    - changes of request param
      - `+ router.status`
  - **ShowPrivateZone**
    - changes of response param
      - `+ routers.status`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the following APIs:
    - `ListFunctionTags`
    - `ListBridgeFunctions`
    - `ListBridgeVersions`
    - `UpdateFunctionCollectState`
    - `ListFunctionTemplate`
    - `ShowFunctionTemplate`
    - `ShowFuncReservedInstanceMetrics`
    - `ShowFunctionMetrics`
    - `EnableAsyncStatusLog`
    - `ShowProjectAsyncStatusLogInfo`
- _Bug Fix_
  - None
- _Change_
  - **ListFunctions**
    - changes of response param
      - `+ functions.resource_id`
  - **ShowFunctionConfig**
    - changes of response param
      - `+ func_id`
      - `+ resource_id`
  - **UpdateFunctionConfig**
    - changes of response param
      - `+ func_id`
      - `+ resource_id`
  - **ShowResInstanceInfo**
    - changes of response param
      - `+ resources.resource_detail.resource_id`

### HuaweiCloud SDK GaussDB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlInstance**
    - changes of response param
      - `* instance.volume.size: string -> int32`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowRuleAction**
    - changes of response param
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **UpdateRuleAction**
    - changes of request param
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
    - changes of response param
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **CreateRuleAction**
    - changes of request param
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
    - changes of response param
      - `+ channel_detail.dms_kafka_forwarding.security_protocol`
  - **ListRuleActions**
    - changes of response param
      - `+ actions.channel_detail.dms_kafka_forwarding.security_protocol`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `* groups.createdAt: int32 -> int64`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListTopnTrafficStatistics**
    - changes of response param
      - `+ results.cold_storage`

### HuaweiCloud SDK OCR

- _Features_
  - Support the API `RecognizePeruIdCard`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the API `ShowRabbitMqProductCores`

### HuaweiCloud SDK RDS

- _Features_
  - Support the API `RevokePostgresqlDbPrivilege`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.65 2023-11-13

### HuaweiCloud SDK DCS

- _Features_
  - Support the interfaces `ShowNodesInformation`, `DeleteCenterTask`, `DeleteDiagnosisTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstanceTopics**
    - changes of request param
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **Createfavorite**
    - changes of request param
      - `+ is_global`
    - changes of response param
      - `+ is_global`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - Support the interfaces `ShowRabbitMqProductCores`, `ShowCesHierarchy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support the interfaces `ListPostgresqlListHistoryTables`, `ListHistoryDatabase`, `BatchRestorePostgreSqlTables`, `BatchRestoreDatabase`
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `ListInstancesResourceMetrics`, `ListInstancesRecommendation`

# 3.1.64 2023-11-09

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddonInstance**
    - changes of response param
      - `+ status.status: enum value [unknown]`
  - **UpdateAddonInstance**
    - changes of response param
      - `+ status.status: enum value [unknown]`
  - **RollbackAddonInstance**
    - changes of response param
      - `+ status.status: enum value [unknown]`
  - **ShowCluster**
    - changes of response param
      - `+ spec.serviceNetwork`
  - **UpdateCluster**
    - changes of response param
      - `+ spec.serviceNetwork`
  - **DeleteCluster**
    - changes of response param
      - `+ spec.serviceNetwork`
  - **CreateAddonInstance**
    - changes of response param
      - `+ status.status: enum value [unknown]`
  - **ListAddonInstances**
    - changes of response param
      - `+ items.status.status: enum value [unknown]`
  - **CreateCluster**
    - changes of request param
      - `+ spec.serviceNetwork`
    - changes of response param
      - `+ spec.serviceNetwork`
  - **ListClusters**
    - changes of response param
      - `+ items.spec.serviceNetwork`
  - **ShowNode**
    - changes of response param
      - `- status.phase: enum value [Installed,ShutDown]`
  - **UpdateNode**
    - changes of response param
      - `- status.phase: enum value [Installed,ShutDown]`
  - **DeleteNode**
    - changes of response param
      - `- status.phase: enum value [Installed,ShutDown]`
  - **CreateNode**
    - changes of response param
      - `- status.phase: enum value [Installed,ShutDown]`
  - **ListNodes**
    - changes of response param
      - `- items.status.phase: enum value [Installed,ShutDown]`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interface `CheckMigrationConnectivity`
  - **ListBackupRecords**
    - changes of response param
      - `+ backup_record_response.backup_format`
      - `+ backup_record_response.execution_at`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interfaces `ShowInstanceConfigs`, `ModifyInstanceConfigs`
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `+ all_failure`
      - `- allFailure`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `+ all_failure`
      - `- allFailure`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchDeleteInstances**
    - changes of request param
      - `+ all_failure`
      - `- allFailure`
  - **DeleteRocketMqMigrationTask**
    - changes of request param
      - `+ task_ids`
      - `- taskIds`

# 3.1.63 2023-11-02

### HuaweiCloud SDK DCS

- _Features_
  - Support the following interfaces：
    - `ShowConfigHistoryDetail`
    - `UpdateClientIpTransparentTransmission`
    - `UpdateInstanceConfig`
    - `ListInstanceOperations`
    - `ExportInstancesTask`
    - `ExportExcelJob`
    - `CreateResizeOrder`
    - `ShowExpireAutoScanConfig`
    - `UpdateExpireAutoScanConfig`
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `ShowNodesInformation`, `ShowBackUpInfo`, `CreateOrUpdateBackUpInfo`, `CreateConnectivityTest`

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowPrivateZone**
    - changes of response param
      - `+ enterprise_project_id`
      - `+ proxy_pattern`

### HuaweiCloud SDK DRS

- _Features_
  - Support the interfaces `CollectPositionAsync`, `ShowPositionResult`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListListeners**
    - changes of request param
      - `+ proxy_protocol_enable`
    - changes of response param
      - `+ listeners.proxy_protocol_enable`
      - `+ listeners.insert_headers.X-Forwarded-Proto`
      - `+ listeners.insert_headers.X-Real-IP`
      - `+ listeners.insert_headers.X-Forwarded-ELB-ID`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listeners.insert_headers.X-Forwarded-TLS-Cipher`
  - **CreateListener**
    - changes of request param
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
    - changes of response param
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **ShowListener**
    - changes of response param
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **UpdateListener**
    - changes of request param
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
    - changes of response param
      - `+ listener.proxy_protocol_enable`
      - `+ listener.insert_headers.X-Forwarded-Proto`
      - `+ listener.insert_headers.X-Real-IP`
      - `+ listener.insert_headers.X-Forwarded-ELB-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Certificate-ID`
      - `+ listener.insert_headers.X-Forwarded-TLS-Protocol`
      - `+ listener.insert_headers.X-Forwarded-TLS-Cipher`
  - **CreatePool**
    - changes of request param
      - `+ pool.ip_version`
  - **UpdatePool**
    - changes of request param
      - `+ pool.any_port_enable`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following interfaces：
    - `ShowIntelligentDiagnosisAbnormalCountOfInstances`
    - `ShowIntelligentDiagnosisInstanceInfosPerMetric`
    - `ShrinkGaussMySqlProxy`
    - `ShowInstanceDatabaseVersion`
    - `CopyInstanceConfigurations`
    - `ShowAutoScalingPolicy`
    - `UpdateAutoScalingPolicy`
    - `CheckResource`
    - `UpdateInstanceConfigurations`
- _Bug Fix_
  - None
- _Change_
  - **DeleteGaussMySqlBackup**
    - changes of response param
      - `+ backup_id`
      - `+ backup_name`
      - `- job_id`
  - **CreateGaussMySqlProxy**
    - changes of request param
      - `+ subnet_id`
  - **ShowGaussMySqlBackupList**
    - changes of request param
      - `+ name`
      - `+ instance_name`
    - changes of response param
      - `+ backups.instance_name`
      - `- backups.status: enum value [BUILDING,COMPLETED,FAILED,AVAILABLE]`
      - `- backups.type: enum value [auto,manual]`
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.subnet_id`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the interface `DeleteDatabase`
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of request param
      - `+ charge_mode`
  - **ListInstancesDetails**
    - changes of request param
      - `+ charge_mode`

### HuaweiCloud SDK KPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ImportPrivateKey**
    - changes of response param
      - `+ keypair.user_id`
      - `+ keypair.key_protection`
      - `* keypair: object<KeypairBean> -> object<ImportPrivateKeyAction>`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGatewayDnatRules**
    - changes of response param
      - `+ dnat_rules.global_eip_id`
      - `+ dnat_rules.global_eip_address`
  - **CreateNatGatewayDnatRule**
    - changes of request param
      - `+ dnat_rule.global_eip_id`
    - changes of response param
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **ShowNatGatewayDnatRule**
    - changes of response param
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **UpdateNatGatewayDnatRule**
    - changes of request param
      - `+ dnat_rule.global_eip_id`
    - changes of response param
      - `+ dnat_rule.global_eip_id`
      - `+ dnat_rule.global_eip_address`
  - **BatchCreateNatGatewayDnatRules**
    - changes of request param
      - `+ dnat_rules.global_eip_id`
    - changes of response param
      - `+ dnat_rules.global_eip_id`
      - `+ dnat_rules.global_eip_address`
  - **ListNatGatewaySnatRules**
    - changes of response param
      - `+ snat_rules.global_eip_id`
      - `+ snat_rules.global_eip_address`
  - **CreateNatGatewaySnatRule**
    - changes of request param
      - `+ snat_rule.global_eip_id`
    - changes of response param
      - `+ snat_rule.global_eip_id`
      - `+ snat_rule.global_eip_address`
  - **ShowNatGatewaySnatRule**
    - changes of response param
      - `+ snat_rule.global_eip_id`
      - `+ snat_rule.global_eip_address`
  - **UpdateNatGatewaySnatRule**
    - changes of request param
      - `+ snat_rule.global_eip_id`
    - changes of response param
      - `+ snat_rule.global_eip_address`
      - `+ snat_rule.global_eip_id`
  - **ListNatGateways**
    - changes of response param
      - `+ nat_gateways.ngport_ip_address`
      - `+ nat_gateways.billing_info`
      - `+ nat_gateways.dnat_rules_limit`
      - `+ nat_gateways.snat_rule_public_ip_limit`
  - **CreateNatGateway**
    - changes of request param
      - `+ nat_gateway.ngport_ip_address`
    - changes of response param
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`
  - **ShowNatGateway**
    - changes of response param
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`
  - **UpdateNatGateway**
    - changes of response param
      - `+ nat_gateway.ngport_ip_address`
      - `+ nat_gateway.billing_info`
      - `+ nat_gateway.dnat_rules_limit`
      - `+ nat_gateway.snat_rule_public_ip_limit`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateRocketMqMigrationTask**
    - changes of request param
      - `* body: string -> map<string, object>`

# 3.1.62 2023-10-26

### HuaweiCloud SDK AOS

- _Features_
  - Support the interfaces `ShowStackInstance`, `UpdateStackInstances`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateBareMetalServers**
    - changes of request param
      - `+ server.extendparam.chargingMode: enum value [postPaid]`

### HuaweiCloud SDK CDN

- _Features_
  - Support the following interfaces：
    - `CreateRefreshTasks`
    - `CreatePreheatingTasks`
    - `ShowHistoryTasks`
    - `ShowHistoryTaskDetails`
    - `ShowUrlTaskInfo`
- _Bug Fix_
  - None
- _Change_
  - **CreateRefreshTasks**
    - changes of request param
      - `+ refresh_task.zh_url_encode`
  - **CreatePreheatingTasks**
    - changes of request param
      - `+ preheating_task.zh_url_encode`

### HuaweiCloud SDK DCS

- _Features_
  - Support the following interfaces：
    - `ShowBackgroundTaskProgress`
    - `ListCenterTask`
    - `StartInstanceResizeCheckJob`
    - `ShowBackUpInfo`
    - `CreateOrUpdateBackUpInfo`
    - `ShowExpireKeyScanInfo`
    - `ScanExpireKey`
    - `ListMigrationTaskLogs`
    - `CheckMigrationConnectivity`
    - `ExchangeInstanceIp`
    - `ExecuteCommandMobilization`
    - `LoginWebCli`
    - `UpdateMigrationTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListProducts**
    - changes of request param
      - `+ product_name`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ResizeInstance**
    - changes of request param
      - `+ tenant_ips`
      - `+ second_tenant_subnet_id`
  - **ResizeEngineInstance**
    - changes of request param
      - `+ tenant_ips`
      - `+ second_tenant_subnet_id`

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interfaces `RunCreateAudioStreamModerationJob`, `RunCloseAudioStreamModerationJob`, `RunCreateVideoStreamModerationJob`, `RunCloseVideoStreamModerationJob`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeGeneralTable**
    - changes of request param
      - `+ with_borders`

### HuaweiCloud SDK RDS

- _Features_
  - Support the interfaces `ListInstanceDiagnosis`, `ListInstancesInfoDiagnosis`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowGroup**
    - changes of response param
      - `+ group_desc`
  - **CreateConsumerGroupOrBatchDeleteConsumerGroup**
    - changes of request param
      - `+ group_desc`
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `+ groups.group_desc`
  - **BatchUpdateConsumerGroup**
    - changes of request param
      - `+ groups.group_desc`

# 3.1.61 2023-10-19

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAgent**
    - changes of request param
      - `* agent_id: string -> list<string>`
  - **ListVault**
    - changes of request param
      - `* id: string -> list<string>`

### HuaweiCloud SDK CFW

- _Features_
  - Support the following interfaces：
    - `ListDomainSets`
    - `AddDomainSet`
    - `UpdateDomainSet`
    - `DeleteDomainSet`
    - `ListFirewallList`
    - `BatchUpdateAclRuleActions`
    - `ListRuleAclTags`
    - `AddDomains`
    - `DeleteDomains`
    - `ListDomains`
    - `BatchDeleteAclRules`
    - `BatchDeleteServiceItems`
    - `BatchDeleteAddressItems`
- _Bug Fix_
  - None
- _Change_
  - **ListFlowLogs**
    - changes of request param
      - `+ dst_host`
    - changes of response param
      - `+ data.records.dst_host`
  - **ListAccessControlLogs**
    - changes of request param
      - `+ dst_host`
      - `+ rule_name`
      - `+ action`
    - changes of response param
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
      - `+ data.records.dst_host`
  - **ListBlackWhiteLists**
    - changes of response param
      - `+ data.records.description`
  - **ListDomainParseDetail**
    - changes of request param
      - `+ address_type`
  - **UpdateDnsServers**
    - changes of request param
      - `+ health_check_domain_name`
  - **ListDnsServers**
    - changes of response param
      - `+ data.health_check_domain_name`
  - **ListAttackLogs**
    - changes of request param
      - `+ dst_host`
      - `+ log_type`
    - changes of response param
      - `+ data.records.dst_host`
      - `+ data.records.src_region_id`
      - `+ data.records.src_region_name`
      - `+ data.records.dst_region_id`
      - `+ data.records.dst_region_name`
  - **UpdateAclRule**
    - changes of request param
      - `+ tag`
      - `+ source.region_list_json`
      - `+ source.region_list`
      - `+ source.domain_set_id`
      - `+ source.domain_set_name`
      - `+ source.ip_address`
      - `+ source.address_group`
      - `+ source.address_group_names`
      - `+ service.custom_service`
      - `+ service.service_group`
      - `+ service.service_group_names`
  - **ListAclRules**
    - changes of request param
      - `+ tags_id`
      - `+ source`
      - `+ destination`
      - `+ service`
    - changes of response param
      - `+ data.records.tag`
      - `+ data.records.source.region_list_json`
      - `+ data.records.source.region_list`
      - `+ data.records.source.domain_set_id`
      - `+ data.records.source.domain_set_name`
      - `+ data.records.source.ip_address`
      - `+ data.records.source.address_group`
      - `+ data.records.source.address_group_names`
      - `+ data.records.service.custom_service`
      - `+ data.records.service.service_group`
      - `+ data.records.service.service_group_names`
  - **AddBlackWhiteList**
    - changes of request param
      - `+ description`
  - **UpdateBlackWhiteList**
    - changes of request param
      - `+ description`
  - **ListEipCount**
    - changes of response param
      - `+ data.eip_protected_self`
  - **ChangeEipStatus**
    - changes of response param
      - `+ data.object_id`
      - `+ data.fail_eip_id_list`
      - `- data.id`
      - `* data: object<IdObject> -> object<EIPSwitchStatusVO>`
  - **ListEastWestFirewall**
    - changes of response param
      - `+ data.mode`
      - `+ data.ew_vpc_route_limit`
      - `+ data.er_associated_subnet.ipv6_enable`
      - `+ data.protect_infos.protected_resource_mode`
  - **AddAclRule**
    - changes of request param
      - `+ rules.tag`
      - `+ rules.source.region_list_json`
      - `+ rules.source.region_list`
      - `+ rules.source.domain_set_id`
      - `+ rules.source.domain_set_name`
      - `+ rules.source.ip_address`
      - `+ rules.source.address_group`
      - `+ rules.source.address_group_names`
      - `+ rules.service.custom_service`
      - `+ rules.service.service_group`
      - `+ rules.service.service_group_names`
  - **ListEips**
    - changes of request param
      - `+ tags`
    - changes of response param
      - `+ data.records.object_id`
      - `+ data.records.tags`
      - `+ data.records.domain_id`
      - `+ data.records.owner`
      - `+ data.records.fw_domain_id`
  - **AddAddressItem**
    - changes of response param
      - `+ data.covered_ip`
  - **ListFirewallDetail**
    - changes of response param
      - `+ data.records.resource_id`
      - `+ data.records.support_url_filtering`
      - `+ data.records.flavor.session_concurrent`
      - `+ data.records.flavor.session_create`
      - `+ data.records.flavor.total_rule_count`
      - `+ data.records.flavor.used_rule_count`
      - `+ data.records.flavor.vpc_bandwith`

### HuaweiCloud SDK CodeArtsBuild

- _Features_
  - Support the following interfaces：
    - `DownloadLogByRecordId`
    - `ShowRecordInfo`
    - `StopBuildJob`
    - `DeleteBuildJob`
    - `DisableBuildJob`
    - `ResumeBuildJob`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the following interfaces：
    - `CreateConnectivityTest`
    - `ShowReplicationStates`
    - `ListAclAccounts`
    - `CreateAclAccount`
    - `UpdateAclAccountPassWord`
    - `ResetAclAccountPassWord`
    - `UpdateAclAccountRole`
    - `UpdateAclAccountRemark`
    - `DeleteAclAccount`
    - `ShowConfigTemplate`
    - `UpdateConfigTemplate`
    - `DeleteConfigTemplate`
- _Bug Fix_
  - None
- _Change_
  - **ListConfigTemplates**
    - changes of response param
      - `+ templates`
      - `- config_templates`
  - **CreateRedislog**
    - changes of request param
      - `+ query_time: enum value [0,1,3,7]`
  - **ListInstances**
    - changes of response param
      - `+ instances.features.support_audit_log`
  - **ShowInstance**
    - changes of response param
      - `+ features.support_audit_log`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ReinstallServerWithCloudInit**
    - changes of request param
      - `+ os-reinstall.metadata.BYOL`
  - **ChangeServerOsWithCloudInit**
    - changes of request param
      - `+ os-change.metadata.BYOL`
  - **ChangeServerOsWithoutCloudInit**
    - changes of request param
      - `+ os-change.metadata.BYOL`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the following interfaces：
    - `UpdateProxyNewConfigurations`
    - `CopyConfigurations`
    - `ListConfigurationsDifferences`
    - `ListConfigurationsInstances`
    - `ListModifyHistory`
    - `ListEnterpriseProjects`
    - `SwitchAccessControl`
    - `CreateAccessControl`
    - `DeleteScheduleTasK`
    - `ListInstanceConfigurations`
    - `ShowGaussMySqlIncrementalBackupList`
    - `UpdateBackupOffsitePolicy`
    - `CreateRestoreTables`
- _Bug Fix_
  - None
- _Change_
  - **ListGaussMySqlDatabase**
    - changes of request param
      - `+ name`
      - `+ charset`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListStructuredLogsWithTimeRange**
    - changes of response param
      - `+ result`
      - `- context`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListEngineProducts**
    - changes of response param
      - `+ products.properties.product_alias`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `RunAudioAssessment`, `RunMultiModalAssessment`

### HuaweiCloud SDK VPC

- _Features_
  - Support the interface `BatchCreateSecurityGroupRules`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.60 2023-10-12

### HuaweiCloud SDK AOS

- _Features_
  - Support the following interfaces：
    - `ListStackSets`
    - `CreateStackSet`
    - `ShowStackSetTemplate`
    - `ListStackSetOperations`
    - `ShowStackSetMetadata`
    - `ListStackInstances`
    - `CreateStackInstance`
    - `DeleteStackInstance`
    - `DeployStackSet`
    - `DeleteStackSet`
    - `UpdateStackSet`
    - `ShowStackSetOperationMetadata`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingConfig**
    - changes of request param
      - `+ source_scaling_configuration_id`

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateBareMetalServers**
    - changes of request param
      - `* server.server_tags: map<string, list<SystemTags>> -> list<SystemTags>`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowHistoryTasks**
    - changes of request param
      - `+ task_type`
  - **ShowUrlTaskInfo**
    - changes of response param
      - `+ result.mode`

### HuaweiCloud SDK CES

- _Features_
  - Support the following interfaces：
    - `BatchUpdateNotificationMasks`
    - `BatchUpdateNotificationMaskTime`
    - `UpdateNotificationMasks`
    - `BatchDeleteNotificationMasks`
    - `ListNotificationMasks`
    - `ListNotificationMaskResources`
    - `ListOneClickAlarms`
    - `CreateOneClickAlarm`
    - `ListOneClickAlarmRules`
    - `BatchUpdateOneClickAlarmsEnabledState`
    - `BatchDeleteOneClickAlarms`
    - `UpdateOneClickAlarmNotifications`
    - `BatchUpdateOneClickAlarmPoliciesEnabledState`
    - `UpdateAlarmNotifications`
    - `ListCesTargetProjectTags`
- _Bug Fix_
  - None
- _Change_
  - **ListAlarmHistories**
    - changes of response param
      - `+ alarm_histories.condition.suppress_duration: enum value [86400]`
  - **ListAgentInvocations**
    - changes of request param
      - `- instance_name`
      - `+ invocation_type: enum value [RETRY]`
    - changes of response param
      - `+ invocations.invocation_type: enum value [RETRY]`
  - **ListAgentStatus**
    - changes of response param
      - `+ agent_status.extensions.version`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - Support the interface `ShowExecutionParams`
- _Bug Fix_
  - None
- _Change_
  - **ListAllApp**
    - changes of request param
      - `+ states`
      - `+ group_id`

### HuaweiCloud SDK CTS

- _Features_
  - Support the following interfaces：
    - `ListOperations`
    - `BatchCreateResourceTags`
    - `BatchDeleteResourceTags`
    - `ListUserResources`
    - `CheckObsBuckets`
    - `ListTraceResources`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ReinstallServerWithoutCloudInit**
    - changes of request param
      - `+ os-reinstall.metadata.BYOL`
  - **ListFlavors**
    - changes of response param
      - `+ flavors.os_extra_specs.quota:vif_max_num`
      - `+ flavors.os_extra_specs.quota:sub_network_interface_max_num`
  - **ListResizeFlavors**
    - changes of response param
      - `+ flavors.extra_specs.quota:vif_max_num`
      - `+ flavors.extra_specs.quota:sub_network_interface_max_num`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `ShowFunctionUrl`, `UpdateFunctionUrl`, `CreateFunctionUrl`, `DeleteFunctionUrl`
  - **ListAsyncInvocations**
    - changes of response param
      - `+ next_marker`
      - `+ count`
  - **ListActiveAsyncInvocations**
    - changes of response param
      - `+ next_marker`
      - `+ count`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.datastore.complete_version`
      - `+ instances.datastore.hotfix_versions`
  - **ListInstancesDetails**
    - changes of response param
      - `+ instances.datastore.complete_version`
      - `+ instances.datastore.hotfix_versions`

### HuaweiCloud SDK ImageSearch

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunAddData**
    - changes of request param
      - `* optional_params.category: int -> int32`
    - changes of response param
      - `* data.image_info.objects.category: number -> integer`
  - **RunDeleteData**
    - changes of response param
      - `* data.delete_info.total_num: int -> int32`
      - `* data.delete_info.delete_num: int -> int32`
  - **RunSearch**
    - changes of request param
      - `* optional_params.category: int -> int32`
    - changes of response param
      - `* data.image_info.category: number -> integer`
      - `* data.image_info.objects.category: number -> integer`
      - `* data.search_info.total_num: int -> int32`
      - `* data.search_info.return_num: int -> int32`
      - `* data.search_info.search_time: long -> int32`
  - **RunCheckData**
    - changes of response param
      - `* data.check_info.total_num: int -> int32`
      - `* data.check_info.return_num: int -> int32`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowJob**
    - changes of response param
      - `+ entities.addition_error_code`
      - `+ entities.addition_error_msg`
      - `+ entities.error_code`
      - `+ entities.error`
      - `+ entities.alarm_code`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeColombiaIdCard`
- _Bug Fix_
  - None
- _Change_
  - **RecognizeVehicleLicense**
    - changes of response param
      - `+ result.energy_type`
      - `+ result.front`
      - `+ result.back`
  - **RecognizeWebImage**
    - changes of request param
      - `+ detect_text_direction`

### HuaweiCloud SDK RDS

- _Features_
  - Support the following interfaces：
    - `ListPostgresqlHbaInfo`
    - `ModifyPostgresqlHbaConf`
    - `AddPostgresqlHbaConf`
    - `DeletePostgresqlHbaConf`
    - `ListPostgresqlHbaInfoHistory`
- _Bug Fix_
  - None
- _Change_
  - **UpgradeDbVersionNew**
    - changes of request param
      - `+ is_delayed`
      - `- delay`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following interfaces：
    - `ListTrafficMirrorSessions`
    - `CreateTrafficMirrorSession`
    - `ShowTrafficMirrorSession`
    - `UpdateTrafficMirrorSession`
    - `DeleteTrafficMirrorSession`
    - `RemoveSourcesFromTrafficMirrorSession`
    - `AddSourcesToTrafficMirrorSession`
    - `ListTrafficMirrorFilters`
    - `CreateTrafficMirrorFilter`
    - `ShowTrafficMirrorFilter`
    - `UpdateTrafficMirrorFilter`
    - `DeleteTrafficMirrorFilter`
    - `ListTrafficMirrorFilterRules`
    - `CreateTrafficMirrorFilterRule`
    - `ShowTrafficMirrorFilterRule`
    - `UpdateTrafficMirrorFilterRule`
    - `DeleteTrafficMirrorFilterRule`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.59 2023-09-19

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateBareMetalServers**
    - changes of request param
      - `* server.server_tags: list<SystemTags> -> map<string, list<SystemTags>>`

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateTracker**
    - changes of request param
      - `+ is_organization_tracker`
      - `+ management_event_selector`
  - **CreateTracker**
    - changes of request param
      - `+ is_organization_tracker`
      - `+ management_event_selector`
    - changes of response param
      - `+ is_organization_tracker`
      - `+ management_event_selector`
  - **ListTrackers**
    - changes of response param
      - `+ trackers.is_organization_tracker`
      - `+ trackers.management_event_selector`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interface `ListActiveAsyncInvocations`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstance**
    - changes of request param
      - `+ availability_zone_detail`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstanceTopics**
    - changes of response param
      - `+ topic_max_partitions`

### HuaweiCloud SDK Live

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateTranscodingsTemplate**
    - changes of request param
      - `+ quality_info.bitrate_adaptive`
      - `+ quality_info.i_frame_policy`
  - **CreateTranscodingsTemplate**
    - changes of request param
      - `+ quality_info.bitrate_adaptive`
      - `+ quality_info.i_frame_policy`
  - **ShowTranscodingsTemplate**
    - changes of response param
      - `+ templates.quality_info.bitrate_adaptive`
      - `+ templates.quality_info.i_frame_policy`

### HuaweiCloud SDK LTS

- _Features_
  - Support the following interfaces：
    - `ShowLogConvergeConfig`
    - `ShowAdminConfig`
    - `UpdateSwitch`
    - `ShowMemberGroupAndStream`
    - `UpdateLogConvergeConfig`
- _Bug Fix_
  - None
- _Change_
  - **ListCharts**
    - changes of response param
      - `+ config.can_sort`
      - `+ config.can_search`
      - `+ config.page_size`
      - `* config: object -> object<ChartConfig>`
  - **ShowNotificationTemplate**
    - changes of response param
      - `+ create_time`
      - `+ project_id`
      - `+ templates`
      - `+ modify_time`
      - `+ name`
      - `+ source`
      - `+ type`
      - `+ locale`
      - `+ desc`
      - `- body`
  - **DeleteTransfer**
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **ListTransfers**
    - changes of response param
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfers.log_transfer_info.log_transfer_detail.tags`
      - `* log_transfers.log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **UpdateTransfer**
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **CreateTransfer**
    - changes of response param
      - `+ log_transfer_info.log_transfer_detail.obs_period`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `+ log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `+ log_transfer_info.log_transfer_detail.obs_period_unit`
      - `+ log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `+ log_transfer_info.log_transfer_detail.obs_eps_id`
      - `+ log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `+ log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `+ log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `+ log_transfer_info.log_transfer_detail.dis_id`
      - `+ log_transfer_info.log_transfer_detail.dis_name`
      - `+ log_transfer_info.log_transfer_detail.kafka_id`
      - `+ log_transfer_info.log_transfer_detail.kafka_topic`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone`
      - `+ log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `+ log_transfer_info.log_transfer_detail.tags`
      - `* log_transfer_info.log_transfer_detail: object -> object<TransferDetail>`
  - **ListNotificationTemplates**
    - changes of response param
      - `+ create_time`
      - `+ project_id`
      - `+ templates`
      - `+ modify_time`
      - `+ name`
      - `+ source`
      - `+ type`
      - `+ locale`
      - `+ desc`
      - `- body`
  - **UpdateSqlAlarmRule**
    - changes of request param
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
    - changes of response param
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
  - **CreateSqlAlarmRule**
    - changes of request param
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **ListSqlAlarmRules**
    - changes of response param
      - `+ sql_alarm_rules.frequency.type`
      - `+ sql_alarm_rules.frequency.cron_expr`
      - `+ sql_alarm_rules.frequency.hour_of_day`
      - `+ sql_alarm_rules.frequency.day_of_week`
      - `+ sql_alarm_rules.frequency.fixed_rate`
      - `+ sql_alarm_rules.frequency.fixed_rate_unit`
      - `* sql_alarm_rules.frequency: object -> object<Frequency>`
  - **UpdateKeywordsAlarmRule**
    - changes of request param
      - `+ frequency.type`
      - `+ frequency.cron_expr`
      - `+ frequency.hour_of_day`
      - `+ frequency.day_of_week`
      - `+ frequency.fixed_rate`
      - `+ frequency.fixed_rate_unit`
      - `* frequency: object -> object<Frequency>`
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **CreateKeywordsAlarmRule**
    - changes of request param
      - `+ notification_save_rule.language`
      - `+ notification_save_rule.timezone`
      - `+ notification_save_rule.user_name`
      - `+ notification_save_rule.topics`
      - `+ notification_save_rule.template_name`
      - `* notification_save_rule: object -> object<SqlNotificationSaveRule>`
  - **ListKeywordsAlarmRules**
    - changes of response param
      - `+ keywords_alarm_rules.frequency.type`
      - `+ keywords_alarm_rules.frequency.cron_expr`
      - `+ keywords_alarm_rules.frequency.hour_of_day`
      - `+ keywords_alarm_rules.frequency.day_of_week`
      - `+ keywords_alarm_rules.frequency.fixed_rate`
      - `+ keywords_alarm_rules.frequency.fixed_rate_unit`
      - `* keywords_alarm_rules.frequency: object -> object<Frequency>`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interfaces `RecognizeVehicleCertificate`, `RecognizeAcceptanceBill`, `RecognizeRealEstateCertificate`, `RecognizeVietnamIdCard`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateConsumerGroup**
    - changes of request param
      - `* body: object<ConsumerGroup> -> object<UpdateConsumerGroup>`
  - **CreateRocketMqMigrationTask**
    - changes of response param
      - `+ task_id`

# 3.1.58 2023-09-14

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateBareMetalServers**
    - changes of request param
      - `+ server.nics.allowed_address_pairs`

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateVault**
    - changes of request param
      - `- vault.billing.promotion_info`
      - `- vault.billing.purchase_mode`
      - `- vault.billing.order_id`
  - **CreatePostPaidVault**
    - changes of request param
      - `- vault.billing.promotion_info`
      - `- vault.billing.purchase_mode`
      - `- vault.billing.order_id`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateEvents**
    - changes of request param
      - `- detail.dimensions`
  - **ListEventDetail**
    - changes of response param
      - `* event_info.detail.dimensions: object<MetricsDimension> -> list<MetricsDimension>`
      - `* event_info.detail: object<EventItemDetail> -> object<ShowEventItemDetail>`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAppDetailById**
    - changes of response param
      - `* result.arrange_infos: object -> list<TaskV2Info>`
  - **ListNewHosts**
    - changes of response param
      - `+ result.permission.can_copy`
      - `- result.permission.can_connection_test`
      - `* result.permission: object<PermissionHostDetail> -> object<PermissionHostDetailNew>`
  - **ShowHostDetail**
    - changes of response param
      - `* result.proxy_host: string -> object<HostInfoDetail>`
      - `+ result.permission.can_copy`
      - `- result.permission.can_connection_test`
      - `* result.permission: object<PermissionHostDetail> -> object<PermissionHostDetailNew>`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListFlavors**
    - changes of response param
      - `+ flavors.replica_count`

### HuaweiCloud SDK EVS

- _Features_
  - Support the interface `ModifyVolumeQoS`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interfaces `ShowFunctionUrl`, `UpdateFunctionUrl`, `CreateFunctionUrl`, `DeleteFunctionUrl`
- _Bug Fix_
  - None
- _Change_
  - **UpdateFuncSnapshot**
    - changes of request param
      - `+ action: enum value [enable,disable]`
  - **CreateFunction**
    - changes of request param
      - `+ custom_image`
      - `+ code_type: enum value [Custom-Image-Swr]`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the interface `ListAuditLogDownloadLink`
- _Bug Fix_
  - None
- _Change_
  - **CreateGaussMySqlInstance**
    - changes of response param
      - `+ instance.volume`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `RunImageDescription`
    - `RunImageSuperResolution`
    - `CreateVideoTaggingMediaTask`
    - `ShowVideoTaggingMediaTask`
    - `CreateImageHighresolutionMattingTask`
    - `ShowImageHighresolutionMattingTask`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interfaces `UpdateInstanceConsumerGroup`, `UpdateInstanceUser`
- _Bug Fix_
  - None
- _Change_
  - **CreateKafkaConsumerGroup**
    - changes of request param
      - `+ group_desc`
  - **CreateInstanceUser**
    - changes of request param
      - `+ user_desc`
  - **ShowInstanceUsers**
    - changes of response param
      - `+ users.user_desc`
  - **ShowInstanceMessages**
    - changes of request param
      - `+ keyword`

### HuaweiCloud SDK KPS

- _Features_
  - Support the interfaces `ImportPrivateKey`, `ExportPrivateKey`, `BatchAssociateKeypair`, `ClearPrivateKey`
- _Bug Fix_
  - None
- _Change_
  - **ListKeypairDetail**
    - changes of response param
      - `+ keypair.key_id`
      - `+ keypair.algorithm`
  - **ListFailedTask**
    - changes of request param
      - `* limit: string -> int32`
      - `* offset: string -> int32`
  - **AssociateKeypair**
    - changes of request param
      - `+ server.port`
    - changes of response param
      - `+ error_msg`
      - `+ error_code`
      - `+ server_id`
      - `+ status`
  - **DisassociateKeypair**
    - changes of response param
      - `+ error_msg`
      - `+ error_code`
      - `+ server_id`
      - `+ status`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListCharts**
    - changes of response param
      - `- config.can_sort`
      - `- config.can_search`
      - `- config.page_size`
  - **ShowNotificationTemplate**
    - changes of response param
      - `+ body`
      - `- create_time`
      - `- project_id`
      - `- templates`
      - `- modify_time`
      - `- name`
      - `- source`
      - `- type`
      - `- locale`
      - `- desc`
  - **ListLogStream**
    - changes of request param
      - `- tag`
    - changes of response param
      - `* log_streams: list<LogStream> -> list<LogStreamResBody>`
  - **ListStructuredLogsWithTimeRange**
    - changes of response param
      - `+ context`
      - `- body`
  - **DeleteTransfer**
    - changes of response param
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **ListTransfers**
    - changes of response param
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfers.log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfers.log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfers.log_transfer_info.log_transfer_detail.tags`
  - **UpdateTransfer**
    - changes of response param
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **CreateTransfer**
    - changes of response param
      - `- log_transfer_info.log_transfer_detail.obs_period`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_id`
      - `- log_transfer_info.log_transfer_detail.obs_prefix_name`
      - `- log_transfer_info.log_transfer_detail.obs_period_unit`
      - `- log_transfer_info.log_transfer_detail.obs_transfer_path`
      - `- log_transfer_info.log_transfer_detail.obs_eps_id`
      - `- log_transfer_info.log_transfer_detail.obs_bucket_name`
      - `- log_transfer_info.log_transfer_detail.obs_encrypted_enable`
      - `- log_transfer_info.log_transfer_detail.obs_dir_pre_fix_name`
      - `- log_transfer_info.log_transfer_detail.dis_id`
      - `- log_transfer_info.log_transfer_detail.dis_name`
      - `- log_transfer_info.log_transfer_detail.kafka_id`
      - `- log_transfer_info.log_transfer_detail.kafka_topic`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone`
      - `- log_transfer_info.log_transfer_detail.obs_time_zone_id`
      - `- log_transfer_info.log_transfer_detail.tags`
  - **ListNotificationTemplates**
    - changes of response param
      - `+ body`
      - `- create_time`
      - `- project_id`
      - `- templates`
      - `- modify_time`
      - `- name`
      - `- source`
      - `- type`
      - `- locale`
      - `- desc`
  - **UpdateSqlAlarmRule**
    - changes of request param
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
    - changes of response param
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
  - **CreateSqlAlarmRule**
    - changes of request param
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **ListSqlAlarmRules**
    - changes of response param
      - `- sql_alarm_rules.frequency.type`
      - `- sql_alarm_rules.frequency.cron_expr`
      - `- sql_alarm_rules.frequency.hour_of_day`
      - `- sql_alarm_rules.frequency.day_of_week`
      - `- sql_alarm_rules.frequency.fixed_rate`
      - `- sql_alarm_rules.frequency.fixed_rate_unit`
  - **UpdateKeywordsAlarmRule**
    - changes of request param
      - `- frequency.type`
      - `- frequency.cron_expr`
      - `- frequency.hour_of_day`
      - `- frequency.day_of_week`
      - `- frequency.fixed_rate`
      - `- frequency.fixed_rate_unit`
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **CreateKeywordsAlarmRule**
    - changes of request param
      - `- notification_save_rule.language`
      - `- notification_save_rule.timezone`
      - `- notification_save_rule.user_name`
      - `- notification_save_rule.topics`
      - `- notification_save_rule.template_name`
  - **ListKeywordsAlarmRules**
    - changes of response param
      - `- keywords_alarm_rules.frequency.type`
      - `- keywords_alarm_rules.frequency.cron_expr`
      - `- keywords_alarm_rules.frequency.hour_of_day`
      - `- keywords_alarm_rules.frequency.day_of_week`
      - `- keywords_alarm_rules.frequency.fixed_rate`
      - `- keywords_alarm_rules.frequency.fixed_rate_unit`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateVideoModerationJob**
    - changes of request param
      - `+ biz_type`
  - **RunCreateAudioModerationJob**
    - changes of request param
      - `+ biz_type`
  - **RunTextModeration**
    - changes of request param
      - `+ biz_type`
  - **CheckImageModeration**
    - changes of request param
      - `+ biz_type`

### HuaweiCloud SDK RDS

- _Features_
  - Support the interfaces `RestoreTablesNew`, `UpgradeDbVersionNew`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.57 2023-09-07

### HuaweiCloud SDK AOS

- _Features_
  - Support the interface `DeleteStackEnhanced`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListScalingActivityLogs**
    - changes of response param
      - `* scaling_activity_log.scaling_value: string -> int32`
  - **CreateScalingPolicy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **UpdateScalingPolicy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ShowScalingPolicy**
    - changes of response param
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingPolicies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
  - **ListScalingActivityV2Logs**
    - changes of response param
      - `* scaling_activity_log.scaling_value: string -> int32`
  - **CreateScalingGroup**
    - changes of request param
      - `+ lbaas_listeners.protocol_version`
  - **ListScalingGroups**
    - changes of response param
      - `+ scaling_groups.lbaas_listeners.protocol_version`
  - **UpdateScalingGroup**
    - changes of request param
      - `+ lbaas_listeners.protocol_version`
  - **ShowScalingGroup**
    - changes of response param
      - `+ scaling_group.lbaas_listeners.protocol_version`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateEvents**
    - changes of request param
      - `+ detail.dimensions`
  - **ListEventDetail**
    - changes of response param
      - `- dimensions`
      - `+ event_info.detail.dimensions`

### HuaweiCloud SDK DRS

- _Features_
  - Support the following interfaces：
    - `StopJobAction`
    - `ShowDataProgress`
    - `UpdateDataProgress`
    - `ShowDataProcessingRulesResult`
    - `CheckDataFilter`
    - `ShowDataFilteringResult`
    - `CollectColumns`
    - `ShowColumnInfoResult`
    - `BatchStopJobsAction`
    - `ExportOperationInfo`
    - `BatchTagAction`
    - `ListProjectTags`
    - `ShowInstanceTags`
    - `UpdateStartPosition`
    - `ShowMonitorData`
    - `ShowSupportObjectType`
    - `ShowIncrementComponentsDetail`
    - `CollectDbObjectsInfo`
    - `ShowDbObjectsList`
- _Bug Fix_
  - None
- _Change_
  - **ShowDbObjectTemplateResult**
    - changes of request param
      - `+ type: enum value [change]`
  - **ShowUpdateObjectSavingStatus**
    - changes of request param
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **ShowObjectMapping**
    - changes of request param
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **ListJobs**
    - changes of request param
      - `+ instance_ids`
      - `+ instance_ip`
  - **ShowDbObjectCollectionStatus**
    - changes of request param
      - `+ X-Language: enum value [en-us,zh-cn]`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.type: enum value [re_create,expired_days]`
  - **UpdateJob**
    - changes of request param
      - `+ job.type: enum value [re_create,expired_days]`

### HuaweiCloud SDK RDS

- _Features_
  - Support the interfaces `ListInstancesResourceMetrics`, `ListInstancesRecommendation`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.56 2023-08-31

### HuaweiCloud SDK CCE

- _Features_
  - Support the interfaces `RollbackAddonInstance`, `ResizeCluster`, `BatchCreateClusterTags`, `BatchDeleteClusterTags`
- _Bug Fix_
  - None
- _Change_
  - **ShowAddonInstance**
    - changes of response param
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **UpdateAddonInstance**
    - changes of response param
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **CreateAddonInstance**
    - changes of response param
      - `+ status.isRollbackable`
      - `+ status.previousVersion`
      - `+ status.status: enum value [rollbackFailed]`
  - **ListAddonInstances**
    - changes of response param
      - `+ items.status.isRollbackable`
      - `+ items.status.previousVersion`
      - `+ items.status.status: enum value [rollbackFailed]`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowResourceGroup**
    - changes of response param
      - `+ resources.event_type`
  - **ListResourceGroup**
    - changes of response param
      - `+ resource_groups.type`
      - `+ resource_groups.relation_ids`
      - `+ resource_groups.resources`
  - **ListEventDetail**
    - changes of response param
      - `+ dimensions`

### HuaweiCloud SDK CES

- _Features_
  - Support the following interfaces：
    - `ListDashboardInfos`
    - `CreateOneDashboard`
    - `UpdateDashboard`
    - `DeleteDashboards`
    - `ListDashboardWidgets`
    - `CreateDashboardWidgets`
    - `ShowWidget`
    - `DeleteOneWidget`
    - `BatchUpdateWidgets`
- _Bug Fix_
  - None
- _Change_
  - **ListAlarmRulePolicies**
    - changes of response param
      - `+ policies.extra_info`
      - `+ policies.type`
      - `* policies: list<Policy> -> list<ListPolicy>`
  - **UpdateAlarmRulePolicies**
    - changes of request param
      - `+ policies.type`
      - `* policies: list<Policy> -> list<UpdatePolicy>`
    - changes of response param
      - `+ policies.type`
      - `* policies: list<Policy> -> list<UpdatePolicy>`
  - **ListAlarmTemplates**
    - changes of response param
      - `- alarm_templates.association_alarm_total`
      - `- alarm_templates.policy_total`
      - `- alarm_templates.policy_statistics`
      - `- alarm_templates.association_resource_groups`
  - **ShowAlarmTemplate**
    - changes of response param
      - `- association_alarm_total`

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - Support the following interfaces：
    - `ListHostClusters`
    - `CreateHostCluster`
    - `ShowHostClusterDetail`
    - `ListNewHosts`
    - `CreateHost`
    - `ShowHostDetail`
    - `ListEnvironments`
    - `CreateEnvironment`
    - `ShowEnvironmentDetail`
    - `DeleteEnvironment`
    - `ImportHostToEnvironment`
    - `DeleteHostFromEnvironment`
    - `ListAllApp`
    - `CreateApp`
    - `ShowAppDetailById`
    - `DeleteApplication`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowInstance**
    - changes of response param
      - `+ available_zones`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowJob**
    - changes of response param
      - `+ entities.server_id`
      - `+ entities.nic_id`
  - **CreateServers**
    - changes of request param
      - `+ server.extendparam.CB_CSBS_BACKUP`

### HuaweiCloud SDK FRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DetectFaceByFile**
    - changes of response param
      - `+ faces.attributes.gender`
  - **DetectFaceByFileIntl**
    - changes of response param
      - `+ faces.attributes.gender`
  - **DetectFaceByUrl**
    - changes of response param
      - `+ faces.attributes.gender`
  - **DetectFaceByUrlIntl**
    - changes of response param
      - `+ faces.attributes.gender`
  - **DetectFaceByBase64**
    - changes of response param
      - `+ faces.attributes.gender`
  - **DetectFaceByBase64Intl**
    - changes of response param
      - `+ faces.attributes.gender`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `- engine_version: enum value [1.1.0,2.7]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [1.1.0,2.7]`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeSmartDocumentRecognizer`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.public_dns_names`

# 3.1.55 2023-08-24

HuaweiCloud SDK APIG

- Features
  - Support the following interfaces：
    - ListEndpointConnections
    - AcceptOrRejectEndpointConnections
    - ListEndpointPermissions
    - AddEndpointPermissions
    - DeleteEndpointPermissions
- Bug Fix
  - None
- Change
  - AssociateSignatureKeyV2
    - changes of response param
      - + bindings.req_method
  - ListSignatureKeysBindedToApiV2
    - changes of response param
      - + bindings.req_method
  - ListApisNotBoundWithSignatureKeyV2
    - changes of response param
      - + apis.req_method
  - ListApisBindedToSignatureKeyV2
    - changes of response param
      - + bindings.req_method
  - ListApisBindedToRequestThrottlingPolicyV2
    - changes of response param
      - + apis.req_method
  - ListApisUnbindedToRequestThrottlingPolicyV2
    - changes of response param
      - + apis.req_method
  - ListApiRuntimeDefinitionV2
    - changes of response param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApisBindedToAclPolicyV2
    - changes of response param
      - + apis.req_method
  - ListApisUnbindedToAclPolicyV2
    - changes of response param
      - + apis.req_method
  - ShowDetailsOfCustomAuthorizersV2
    - changes of response param
      - + network_type
  - UpdateCustomAuthorizerV2
    - changes of request param
      - + network_type
    - changes of response param
      - + network_type
  - ListInstancesV2
    - changes of response param
      - + instances.cbc_operation_locks
      - + instances.status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instances.instance_status: enum value [42,43,44]
      - + instances.spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - CreateInstanceV2
    - changes of request param
      - + spec_id: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - ShowDetailsOfInstanceV2
    - changes of response param
      - + cbc_operation_locks
      - + status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instance_status: enum value [42,43,44]
      - + spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - UpdateInstanceV2
    - changes of response param
      - + cbc_operation_locks
      - + status: enum value [Resizing,ResizeFailed,ResizeTimeout]
      - + instance_status: enum value [42,43,44]
      - + spec: enum value [PLATINUM_X2,PLATINUM_X3,PLATINUM_X4,PLATINUM_X5,PLATINUM_X6,PLATINUM_X7,PLATINUM_X8]
  - ShowDetailsOfApiV2
    - changes of response param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - UpdateApiV2
    - changes of request param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
    - changes of response param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApiVersionDetailV2
    - changes of response param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - CreateCustomAuthorizerV2
    - changes of request param
      - + network_type
    - changes of response param
      - + network_type
  - ListCustomAuthorizersV2
    - changes of response param
      - + network_type
      - + authorizer_list.network_type
  - CreateApiV2
    - changes of request param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
    - changes of response param
      - + content_type: enum value [multipart/form-data]
      - - content_type: enum value [multipart/form-date]
  - ListApisV2
    - changes of response param
      - + apis.content_type: enum value [multipart/form-data]
      - - apis.content_type: enum value [multipart/form-date]

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListJarPackageHostInfo**
    - changes of response param
      - `* data_list.record_time: int32 -> int64`

### HuaweiCloud SDK IMS

- _Features_
  - Support the following interfaces：
    - `ListAimMsgTemplate`
    - `CreateAimMsgTemplate`
    - `ShowAimMsgTemplateVariable`
    - `SendAimBatchMessages`
    - `SendAimBatchDifferentMessages`
    - `DeleteAimMsgSignature`
    - `ShowAimMsgTemplateDetail`
    - `UpdateAimMsgTemplate`
    - `DeleteAimMsgTemplate`
    - `ListAimMsgSignature`
    - `AddAimMsgSignature`
    - `ListAimMsgApp`
    - `CreateSmsApp`
    - `ListAimMsgAppDetail`
    - `UpdateAimMsgApp`
    - `ShowAimMsgSignatureFileInfo`
    - `UploadAimMsgSignatureFile`
    - `ListAimMsgSignatureDetail`
    - `UpdateAimMsgSignature`
- _Bug Fix_
  - None
- _Change_
  - **ListAimResolveDetails**
    - changes of request param
      - `+ task_name`
    - changes of response param
      - `+ resolve_details.task_name`
  - **ListResolveTasks**
    - changes of request param
      - `+ task_name`
    - changes of response param
      - `+ resolve_tasks.task_name`

### HuaweiCloud SDK LTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateLogStream**
    - changes of request param
      - `* tags: object<tagsBody> -> list<tagsBody>`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListNatGateways**
    - changes of response param
      - `+ nat_gateways.session_conf`
  - **CreateNatGateway**
    - changes of request param
      - `+ nat_gateway.session_conf`
    - changes of response param
      - `+ nat_gateway.session_conf`
  - **ShowNatGateway**
    - changes of response param
      - `+ nat_gateway.session_conf`
  - **UpdateNatGateway**
    - changes of request param
      - `+ nat_gateway.session_conf`
    - changes of response param
      - `+ nat_gateway.session_conf`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `ShowLoginType`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunTts**
    - changes of request param
      - `+ config.property: enum value [chinese_huaxiaoman_common,chinese_huaxiaofang_common,chinese_huaxiaojun_common]`

### HuaweiCloud SDK VPC

# 3.1.54 2023-08-21

### HuaweiCloud SDK LTS

- _Features_
  - Support the interface `DeleteDashboard`
- _Bug Fix_
  - None
- _Change_
  - **CreateDashBoard**
    - changes of response param
      - `* last_update_time: string -> int64`
      - `* useSystemTemplate: string -> boolean`
  - **CreateLogStream**
    - changes of request param
      - `- enterprise_project_name`
      - `- log_stream_name: enum value [lts-stream-13ci]`
      - `* ttl_in_days: string -> int32`
      - `* tags: list<tagsBody> -> object<tagsBody>`
  - **ListAccessConfig**
    - changes of response param
      - `+ cluster_id`
      - `+ result.cluster_id`
  - **UpdateAccessConfig**
    - changes of request param
      - `+ cluster_id`
    - changes of response param
      - `+ cluster_id`
  - **CreateAccessConfig**
    - changes of request param
      - `+ cluster_id`
    - changes of response param
      - `+ cluster_id`
  - **DeleteAccessConfig**
    - changes of response param
      - `+ cluster_id`
      - `+ result.cluster_id`

# 3.1.53 2023-08-17

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateStack**
    - changes of request param
      - `+ agencies.agency_urn`
  - **GetStackMetadata**
    - changes of response param
      - `+ agencies.agency_urn`
  - **CreateStack**
    - changes of request param
      - `+ agencies.agency_urn`

### HuaweiCloud SDK CloudRTC

- _Features_
  - Support the interfaces `ListRtcAbnormalEvent`, `ListRtcEvent`, `ListObsBuckets`, `ListObsBucketObjects`, `UpdateObsBucketAuthority`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the interface `ShowNodesInformation`
- _Bug Fix_
  - None
- _Change_
  - **ShowInstance**
    - changes of response param
      - `+ cloud_service_type_code`
      - `+ inquery_spec_code`
      - `+ cloud_resource_type_code`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateServers**
    - changes of request param
      - `+ server.root_volume.iops`
      - `+ server.root_volume.throughput`
      - `+ server.root_volume.volumetype: enum value [GPSSD2,ESSD2]`
      - `+ server.data_volumes.iops`
      - `+ server.data_volumes.throughput`
      - `+ server.data_volumes.volumetype: enum value [GPSSD2,ESSD2]`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.data_volumes.iops`
      - `+ server.data_volumes.throughput`
      - `+ server.data_volumes.volumetype: enum value [GPSSD2,ESSD2]`
      - `+ server.root_volume.iops`
      - `+ server.root_volume.throughput`
      - `+ server.root_volume.volumetype: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the interfaces `ModifyGaussMysqlDns`, `CreateGaussMysqlDns`
- _Bug Fix_
  - None
- _Change_
  - **ShowGaussMySqlInstanceInfo**
    - changes of response param
      - `+ instance.private_dns_names`
  - **ListGaussMySqlInstanceDetailInfo**
    - changes of response param
      - `+ instances.private_dns_names`

### HuaweiCloud SDK ImageSearch

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `RunCreateInstance`
    - `RunModifyPicture`
    - `RunAddPicture`
    - `RunDeletePicture`
    - `RunSearchPicture`
    - `RunCheckPicture`
    - `RunQueryInstance`
    - `RunDeleteInstance`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `+ allFailure`
      - `- all_failure`
  - **CreateInstanceByEngine**
    - changes of request param
      - `- engine_version: enum value [2.3.0]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [2.3.0]`

### HuaweiCloud SDK Live

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSnapshotConfigs**
    - changes of response param
      - `* body: object<LiveSnapshotConfig> -> list<LiveSnapshotConfig>`

### HuaweiCloud SDK MPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateThumbnailsTask**
    - changes of request param
      - `+ thumbnail_para.dots_ms`
      - `+ thumbnail_para.type: enum value [DOTS_MS]`
  - **CreateTranscodingTask**
    - changes of request param
      - `+ thumbnail.params.dots_ms`
      - `+ thumbnail.params.type: enum value [DOTS_MS]`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchRestartOrDeleteInstances**
    - changes of request param
      - `+ allFailure`
      - `- all_failure`
  - **CreatePostPaidInstanceByEngine**
    - changes of request param
      - `- engine_version: enum value [3.7.17]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [3.7.17]`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BatchDeleteInstances**
    - changes of request param
      - `+ allFailure`
      - `- all_failure`
  - **CreatePostPaidInstance**
    - changes of request param
      - `- engine_version: enum value [5.x]`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateSecurityGroupRule**
    - changes of request param
      - `+ security_group_rule.remote_address_group_id`
  - **NeutronCreateSecurityGroupRule**
    - changes of request param
      - `+ security_group_rule.remote_address_group_id`

# 3.1.52 2023-08-10

### HuaweiCloud SDK CodeArtsBuild

- _Features_
  - Support `CodeArtsBuild`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPrivateZones**
    - changes of request param
      - `* type: optional -> required`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the interfaces `UpdateProxyPort`, `DescribeBackupEncryptStatus`, `ModifyBackupEncryptStatus`
- _Bug Fix_
  - None
- _Change_
  - **UpdateProxySessionConsistence**
    - changes of request param
      - `+ consistence_mode`
  - **CreateGaussMySqlInstance**
    - changes of request param
      - `* datastore: object<MysqlDatastore> -> object<MysqlDatastoreInReq>`
    - changes of response param
      - `* instance.datastore: object<MysqlDatastore> -> object<MysqlDatastoreInRes>`
  - **ShowGaussMySqlBackupList**
    - changes of response param
      - `- backups.datastore.kernel_version`
      - `* backups.datastore: object<MysqlDatastore> -> object<MysqlDatastoreInBackup>`
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.consistence_mode`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstanceConsumerGroups**
    - changes of response param
      - `+ groups.createdAt`
      - `+ groups.group_desc`
      - `+ groups.lag`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeMyanmarIdcard**
    - changes of request param
      - `+ return_translation`
    - changes of response param
      - `+ result.translation_info`

### HuaweiCloud SDK RDS

- _Features_
  - Support the interfaces `ListXellogFiles`, `CreateXelLogDownload`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowOneTopic**
    - changes of response param
      - `+ message_type`
  - **ShowTopicStatus**
    - changes of response param
      - `+ max_offset`
      - `+ min_offset`
  - **ShowInstance**
    - changes of response param
      - `+ grpc_address`
      - `+ public_grpc_address`
  - **CreateTopicOrBatchDeleteTopic**
    - changes of request param
      - `+ message_type`
  - **ListRocketInstanceTopics**
    - changes of response param
      - `+ message_type`
      - `+ topics.message_type`
  - **ListMessages**
    - changes of response param
      - `* messages.reconsume_times: string -> int32`
      - `* messages.queue_id: string -> int32`
      - `* messages.queue_offset: string -> int32`
  - **ExportDlqMessage**
    - changes of response param
      - `* reconsume_times: string -> int32`
      - `* queue_id: string -> int32`
      - `* queue_offset: string -> int32`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [5.x]`
  - **ListInstances**
    - changes of response param
      - `+ grpc_address`
      - `+ public_grpc_address`
      - `+ instances.grpc_address`
      - `+ instances.public_grpc_address`
  - **ShowConsumerListOrDetails**
    - changes of response param
      - `+ lag`
      - `+ max_offset`
      - `+ consumer_offset`

# 3.1.51 2023-08-03

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `- spec.extendParam.enterprise_project_id`
  - **UpdateNode**
    - changes of response param
      - `- spec.extendParam.enterprise_project_id`
  - **DeleteNode**
    - changes of response param
      - `- spec.extendParam.enterprise_project_id`
  - **CreateNode**
    - changes of request param
      - `- spec.extendParam.enterprise_project_id`
    - changes of response param
      - `- spec.extendParam.enterprise_project_id`
  - **ListNodes**
    - changes of response param
      - `- items.spec.extendParam.enterprise_project_id`
  - **ShowNodePool**
    - changes of response param
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **UpdateNodePool**
    - changes of response param
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **DeleteNodePool**
    - changes of response param
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **CreateNodePool**
    - changes of request param
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
    - changes of response param
      - `- spec.nodeTemplate.extendParam.enterprise_project_id`
  - **ListNodePools**
    - changes of response param
      - `- items.spec.nodeTemplate.extendParam.enterprise_project_id`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainDetailByName**
    - changes of response param
      - `- domain.sources.weight`
      - `* domain.sources: list<SourcesConfig> -> list<SourcesDomainConfig>`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.remark`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.request_limit_rules.priority`
      - `+ configs.request_limit_rules.match_type`
      - `+ configs.request_limit_rules.match_value`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.remark`
      - `+ configs.ip_frequency_limit`
      - `+ configs.hsts`
      - `+ configs.quic`
      - `+ configs.url_auth.inherit_config`
      - `+ configs.sources.bucket_access_key`
      - `+ configs.sources.bucket_secret_key`
      - `+ configs.sources.bucket_region`
      - `+ configs.sources.bucket_name`
      - `+ configs.request_limit_rules.priority`
      - `+ configs.request_limit_rules.match_type`
      - `+ configs.request_limit_rules.match_value`

### HuaweiCloud SDK CTS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **DeleteTracker**
    - changes of request param
      - `+ tracker_type: enum value [system]`

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the interface `ModifyGaussMySqlProxyRouteMode`
- _Bug Fix_
  - None
- _Change_
  - **ShowGaussMySqlEngineVersion**
    - changes of response param
      - `+ datastores.version`
      - `+ datastores.kernel_version`
  - **CreateGaussMySqlProxy**
    - changes of request param
      - `+ route_mode`
  - **CreateGaussMySqlInstance**
    - changes of request param
      - `+ datastore.kernel_version`
    - changes of response param
      - `+ instance.datastore.kernel_version`
  - **ShowGaussMySqlBackupList**
    - changes of response param
      - `+ backups.datastore.kernel_version`
  - **ShowGaussMySqlProxyList**
    - changes of response param
      - `+ proxy_list.proxy.route_mode`
      - `+ proxy_list.proxy.balance_route_mode_enabled`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstances**
    - changes of response param
      - `+ instances.backup_used_space`
  - **ListComponentInfos**
    - changes of request param
      - `+ component_type`
      - `+ availability_zone_id`
    - changes of response param
      - `+ nodes.name`
      - `+ nodes.availability_zone_id`
      - `+ nodes.description`
      - `+ nodes.status`
      - `+ nodes.components.distributed_id`
  - **ListInstancesDetails**
    - changes of response param
      - `+ instances.backup_used_space`

### HuaweiCloud SDK ProjectMan

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowIssueV4**
    - changes of response param
      - `+ find_release_dev`
      - `+ release_dev`
      - `+ env`

### HuaweiCloud SDK RDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListDatastores**
    - changes of request param
      - `+ database_name: enum value [MariaDB]`
  - **ListConfigurations**
    - changes of response param
      - `+ configurations.datastore_name: enum value [mariadb]`
  - **CreateConfiguration**
    - changes of request param
      - `+ datastore.type: enum value [MariaDB]`
    - changes of response param
      - `+ configuration.datastore_name: enum value [mariadb]`
  - **ShowConfiguration**
    - changes of response param
      - `+ datastore_name: enum value [mariadb]`
  - **ShowInstanceConfiguration**
    - changes of response param
      - `+ datastore_name: enum value [mariadb]`
  - **ListFlavors**
    - changes of request param
      - `+ database_name: enum value [MariaDB]`
  - **ListStorageTypes**
    - changes of request param
      - `+ database_name: enum value [MariaDB]`
  - **ListInstances**
    - changes of request param
      - `+ datastore_type: enum value [MariaDB]`
    - changes of response param
      - `+ instances.datastore.type: enum value [MariaDB]`
  - **CreateInstance**
    - changes of request param
      - `+ datastore.type: enum value [MariaDB]`
    - changes of response param
      - `+ instance.datastore.type: enum value [MariaDB]`
  - **CreateRestoreInstance**
    - changes of request param
      - `+ datastore.type: enum value [MariaDB]`
    - changes of response param
      - `+ instance.datastore.type: enum value [MariaDB]`
  - **ListBackups**
    - changes of response param
      - `+ backups.datastore.type: enum value [MariaDB]`
  - **ListOffSiteBackups**
    - changes of response param
      - `+ backups.datastore.type: enum value [MariaDB]`
  - **ListOffSiteInstances**
    - changes of response param
      - `+ offsite_backup_instances.datastore.type: enum value [MariaDB]`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMessageTrace**
    - changes of request param
      - `* msg_id: optional -> required`
  - **ListMessages**
    - changes of request param
      - `+ key`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPorts**
    - changes of request param
      - `+ enable_efi`
    - changes of response param
      - `+ ports.enable_efi`
  - **CreatePort**
    - changes of response param
      - `+ port.enable_efi`
  - **ShowPort**
    - changes of response param
      - `+ port.enable_efi`
  - **UpdatePort**
    - changes of response param
      - `+ port.enable_efi`

# 3.1.50 2023-07-31

### HuaweiCloud SDK ProjectMan

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpdateIssueV4**
    - changes of response param
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
  - **ListIssuesV4**
    - changes of response param
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
      - `+ issues.order`
      - `+ issues.release_dev`
      - `+ issues.find_release_dev`
      - `+ issues.env`
  - **ListChildIssuesV4**
    - changes of response param
      - `+ find_release_dev`
      - `+ order`
      - `+ release_dev`
      - `+ env`
      - `+ issues.order`
      - `+ issues.release_dev`
      - `+ issues.find_release_dev`
      - `+ issues.env`

# 3.1.49 2023-07-27

### HuaweiCloud SDK DRS

- _Features_
  - Support the following interfaces：
    - `DownloadBatchCreateTemplate`
    - `ImportBatchCreateJobs`
    - `CopyJob`
    - `ShowMetering`
    - `ShowDirtyData`
    - `ShowComparePolicy`
    - `ShowHealthCompareJobList`
    - `ShowProgressData`
    - `ShowObjectMapping`
    - `ShowActions`
    - `ValidateJobName`
    - `ShowEnterpriseProject`
- _Bug Fix_
  - None
- _Change_
  - **DownloadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level`
  - **UploadDbObjectTemplate**
    - changes of request param
      - `+ file_import_db_level`
  - **ListAsyncJobs**
    - changes of response param
      - `+ jobs.status: enum value [AUTO_PARAM_VALIDATE_SUCCESS,COMMIT_SUCCESS]`
      - `- jobs.status: enum value [ASYNC_JOB_CREATING,ASYNC_JOB_CREATE_FAILED,ASYNC_JOB_COMPLETED]`
  - **CreateJob**
    - changes of request param
      - `+ job.node_info.base_info`
    - changes of response param
      - `+ is_clone_job`
      - `+ create_time`
      - `+ name`
      - `+ id`
      - `+ status`
      - `+ job.is_clone_job`
  - **BatchCreateJobsAsync**
    - changes of request param
      - `+ jobs.node_info.base_info`
  - **ListAsyncJobDetail**
    - changes of response param
      - `+ jobs.support_import_file_resp`
      - `+ jobs.instance_features`
      - `+ jobs.task_version`
      - `+ jobs.node_info.base_info`
  - **UpdateBatchAsyncJobs**
    - changes of request param
      - `+ jobs.type: enum value [policy]`
      - `- jobs.type: enum value [policy_config]`
      - `+ jobs.params.node_info.base_info`
  - **ShowJobDetail**
    - changes of request param
      - `+ type: enum value [file]`
    - changes of response param
      - `+ job.support_import_file_resp`
      - `+ job.instance_features`
      - `+ job.task_version`
      - `+ job.node_info.base_info`
  - **UpdateJob**
    - changes of request param
      - `+ job.type: enum value [policy]`
      - `- job.type: enum value [policy_config]`
      - `+ job.params.node_info.base_info`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AttachShareBandwidth**
    - changes of response param
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **DetachShareBandwidth**
    - changes of response param
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **EnableNat64**
    - changes of response param
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **DisableNat64**
    - changes of response param
      - `+ publicip.vnic.vtep`
      - `+ publicip.vnic.vni`
      - `+ publicip.vnic.port_profile`
  - **AttachBatchPublicIp**
    - changes of response param
      - `+ publicips.publicip.vnic.vtep`
      - `+ publicips.publicip.vnic.vni`
      - `+ publicips.publicip.vnic.port_profile`
  - **DetachBatchPublicIp**
    - changes of response param
      - `+ publicips.publicip.vnic.vtep`
      - `+ publicips.publicip.vnic.vni`
      - `+ publicips.publicip.vnic.port_profile`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateTags**
    - changes of request param
      - `+ tags.key`
      - `+ tags.value`
      - `* tags: list<Kv> -> list<KvItem>`
  - **DeleteTags**
    - changes of request param
      - `+ tags.key`
      - `+ tags.value`
      - `* tags: list<Kv> -> list<KvItem>`
  - **ShowResInstanceInfo**
    - changes of request param
      - `+ matches.key`
      - `+ matches.value`
      - `* matches: list<Kv> -> list<KvItem>`
    - changes of response param
      - `+ resources.tags.key`
      - `+ resources.tags.value`
      - `* resources.tags: list<Kv> -> list<KvItem>`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the interface `ShowInstanceBiactiveRegions`
- _Bug Fix_
  - None
- _Change_
  - **ListConfigurations**
    - changes of response param
      - `+ quota`
      - `+ configurations.mode`
  - **ListConfigurationTemplates**
    - changes of response param
      - `+ quota`
      - `+ configurations.mode`
  - **ShowInstanceConfiguration**
    - changes of response param
      - `+ mode`
      - `+ id`
  - **ListConfigurationDatastores**
    - changes of response param
      - `+ datastores.mode`
  - **ShowQuotas**
    - changes of request param
      - `+ datastore_type`
      - `+ mode`
  - **ListInstances**
    - changes of response param
      - `+ instances.datastore.whole_version`

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support the interface `DownloadBackup`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the following interfaces：
    - `ListDeviceTunnels`
    - `AddTunnel`
    - `ShowDeviceTunnel`
    - `CloseDeviceTunnel`
    - `DeleteDeviceTunnel`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ disk_encrypted_enable`
      - `+ disk_encrypted_key`

### HuaweiCloud SDK LTS

- _Features_
  - Support the interface `UpdateLogStream`
- _Bug Fix_
  - None
- _Change_
  - **UpdateLogGroup**
    - changes of request param
      - `+ tags`
  - **CreateLogGroup**
    - changes of request param
      - `+ tags`
  - **CreateLogStream**
    - changes of request param
      - `+ enterprise_project_name`
      - `+ ttl_in_days`
      - `+ tags`
      - `+ log_stream_name: enum value [lts-stream-13ci]`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowInstanceExtendProductInfo**
    - changes of response param
      - `+ monthly`
      - `+ hourly`
      - `- engine`
      - `- versions`
      - `- products`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ValidateConsumedMessage**
    - changes of request param
      - `+ engine: enum value [reliability]`
  - **ListInstances**
    - changes of request param
      - `+ engine: enum value [reliability]`

# 3.1.48 2023-07-20

### HuaweiCloud SDK LTS

- _Features_
  - Support `LTS`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforopenGauss

- _Features_
  - Support `GaussDBforopenGauss`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDB

- _Features_
  - Support `GaussDB`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RDS

- _Features_
  - Support `RDS`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CloudRTC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateIndividualStreamJob**
    - changes of request param
      - `- publish_param`
  - **UpdateIndividualStreamJob**
    - changes of request param
      - `- publish_param`
  - **CreateMixJob**
    - changes of request param
      - `- publish_param`

### HuaweiCloud SDK EIP

- _Features_
  - Support the following interfaces：
    - `AttachShareBandwidth`
    - `AttachBatchPublicIp`
    - `DetachShareBandwidth`
    - `DetachBatchPublicIp`
    - `EnableNat64`
    - `DisableNat64`
    - `ListBandwidth`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interface `DeleteBatchTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interfaces `ListTopicPartitions`, `ListTopicProducers`
- _Bug Fix_
  - None
- _Change_
  - **ListProducts**
    - changes of request param
      - `+ engine: enum value [kafka]`
  - **UpdateInstanceTopic**
    - changes of request param
      - `+ topics.topic_other_configs`
      - `+ topics.topic_desc`
  - **CreateInstanceTopic**
    - changes of request param
      - `+ topic_other_configs`
      - `+ topic_desc`
    - changes of response param
      - `+ id`
  - **ListInstanceTopics**
    - changes of request param
      - `- offset`
      - `- limit`
    - changes of response param
      - `+ topics.topic_other_configs`
      - `+ topics.topic_desc`
      - `+ topics.created_at`
  - **ListInstances**
    - changes of request param
      - `+ engine: enum value [kafka]`
  - **ResizeEngineInstance**
    - changes of request param
      - `+ engine: enum value [kafka]`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowInstanceExtendProductInfo**
    - changes of request param
      - `+ engine: enum value [rabbitmq]`
    - changes of response param
      - `+ engine`
      - `+ versions`
      - `+ products`
      - `- monthly`
      - `- hourly`
  - **ListProducts**
    - changes of request param
      - `+ engine: enum value [rabbitmq]`
  - **ResizeEngineInstance**
    - changes of request param
      - `+ engine: enum value [rabbitmq]`
  - **ShowEngineInstanceExtendProductInfo**
    - changes of request param
      - `+ engine: enum value [rabbitmq]`

# 3.1.47 2023-07-13

### HuaweiCloud SDK CodeArtsDeploy

- _Features_
  - Support `CodeArtsDeploy`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK AS

- _Features_
  - Support the interfaces `ListGroupScheduledTasks`, `CreateGroupScheduledTask`, `UpdateGroupScheduledTask`, `DeleteGroupScheduledTask`
- _Bug Fix_
  - None
- _Change_
  - **CreateScalingPolicy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **UpdateScalingPolicy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ShowScalingPolicy**
    - changes of response param
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListScalingPolicies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **CreateScalingV2Policy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListAllScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **UpdateScalingV2Policy**
    - changes of request param
      - `+ scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ShowScalingV2Policy**
    - changes of response param
      - `+ scaling_policy.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policy.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`
  - **ListScalingV2Policies**
    - changes of response param
      - `+ scaling_policies.scheduled_policy.recurrence_type: enum value [DAILY,WEEKLY,MONTHLY]`
      - `- scaling_policies.scheduled_policy.recurrence_type: enum value [Daily,Weekly,Monthly]`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **PushTranscriberJobs**
    - changes of request param
      - `+ Enterprise-Project-Id`

### HuaweiCloud SDK VPC

- _Features_
  - Support the following interfaces：
    - `ListApiVersion`
    - `NeutronListPorts`
    - `NeutronCreatePort`
    - `NeutronShowPort`
    - `NeutronUpdatePort`
    - `NeutronDeletePort`
    - `NeutronListNetworks`
    - `NeutronCreateNetwork`
    - `NeutronShowNetwork`
    - `NeutronUpdateNetwork`
    - `NeutronDeleteNetwork`
    - `NeutronListSubnets`
    - `NeutronCreateSubnet`
    - `NeutronShowSubnet`
    - `NeutronUpdateSubnet`
    - `NeutronDeleteSubnet`
    - `NeutronListRouters`
    - `NeutronCreateRouter`
    - `NeutronShowRouter`
    - `NeutronUpdateRouter`
    - `NeutronDeleteRouter`
    - `NeutronAddRouterInterface`
    - `NeutronRemoveRouterInterface`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.46 2023-07-06

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **UpgradeCluster**
    - changes of response param
      - `+ metadata`
      - `+ spec`
      - `- uid`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainDetailByName**
    - changes of response param
      - `+ domain.sources.weight`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.sources.weight`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.business_type`
      - `+ configs.service_area`
      - `+ configs.sources.weight`

### HuaweiCloud SDK EVS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateVolume**
    - changes of request param
      - `+ volume.iops`
      - `+ volume.throughput`
      - `+ volume.volume_type: enum value [GPSSD2,ESSD2]`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RunCreateVideoModerationJob**
    - changes of request param
      - `+ data.language`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListSecurityGroupRules**
    - changes of request param
      - `+ remote_ip_prefix`

# 3.1.45 2023-06-29

### HuaweiCloud SDK AOS

- _Features_
  - Support the interface `ListTemplateVersions`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - Support the interfaces `ExecuteClusterSwitchover`, `ShowJobInfo`
- _Bug Fix_
  - None
- _Change_
  - **ListConfigTemplates**
    - changes of response param
      - `+ config_templates.created_at`
  - **CreateInstance**
    - changes of request param
      - `+ template_id`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateCommand**
    - changes of response param
      - `+ error_msg`
      - `+ error_code`
  - **ListProperties**
    - changes of response param
      - `+ error_msg`
      - `+ error_code`
  - **UpdateProperties**
    - changes of response param
      - `+ error_msg`
      - `+ error_code`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddressGroup**
    - changes of response param
      - `+ address_group.tags`
  - **UpdateAddressGroup**
    - changes of response param
      - `+ address_group.tags`
  - **ListAddressGroup**
    - changes of response param
      - `+ address_groups.tags`
  - **CreateAddressGroup**
    - changes of response param
      - `+ address_group.tags`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **AddOrRemoveServicePermissions**
    - changes of request param
      - `+ permission_type`
    - changes of response param
      - `+ permission_type`
  - **UpdateEndpointService**
    - changes of response param
      - `- cidr_type`
  - **ListServicePermissionsDetails**
    - changes of response param
      - `+ permissions.permission_type`
  - **BatchAddEndpointServicePermissions**
    - changes of request param
      - `+ permission_type`
    - changes of response param
      - `+ permissions.permission_type`
  - **BatchRemoveEndpointServicePermissions**
    - changes of response param
      - `+ permissions.permission_type`
  - **UpdateEndpointServicePermissionDesc**
    - changes of response param
      - `+ permissions.permission_type`
  - **CreateEndpointService**
    - changes of response param
      - `- cidr_type`

# 3.1.44 2023-06-21

### HuaweiCloud SDK CloudRTC

- _Features_
  - Support the service `CloudRTC`.
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Classroom

- _Features_
  - Support the following interfaces：
    - `ListPackages`
    - `ShowPackageDetail`
    - `ListExercises`
    - `ShowExerciseDetail`
    - `ExecuteExercise`
    - `ListAllDifficults`
    - `ListMyKnowledgePoints`
- _Bug Fix_
  - None
- _Change_
  - **ApplyJudgement**
    - changes of request param
      - `+ runtime_type: enum value [javaScript]`

### HuaweiCloud SDK DNS

- _Features_
  - Support the interface `ShowDomainQuota`
- _Bug Fix_
  - None
- _Change_
  - **ShowRecordSetWithLine**
    - changes of response param
      - `+ bundle`
  - **SetRecordSetsStatus**
    - changes of response param
      - `+ bundle`
  - **BatchUpdateRecordSetWithLine**
    - changes of response param
      - `+ bundle`
      - `+ recordsets.bundle`
  - **BatchDeleteRecordSetWithLine**
    - changes of response param
      - `+ bundle`
      - `+ recordsets.bundle`
  - **CreateRecordSetWithBatchLines**
    - changes of response param
      - `+ bundle`
      - `+ recordsets.bundle`

# 3.1.43 2023-06-15

### HuaweiCloud SDK CBR

- _Features_
    - Support Cloud Backup and Recovery service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK Live

- _Features_
    - Support Live service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateBatchTask**
    - changes of response param
      - `- task_progress.device_in_progress`
      - `- task_progress.rejected`
  - **ListBatchTasks**
    - changes of response param
      - `- batchtasks.task_progress.device_in_progress`
      - `- batchtasks.task_progress.rejected`
  - **ShowBatchTask**
    - changes of response param
      - `- batchtask.task_progress.device_in_progress`
      - `- batchtask.task_progress.rejected`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeGeneralText**
    - changes of request param
      - `+ single_orientation_mode`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **SendDlqMessage**
    - changes of request param
      - `+ engine: enum value [reliability]`
  - **CreateRocketMqMigrationTask**
    - changes of request param
      - `+ type: enum value [kafka]`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVocabularies**
    - changes of request param
      - `+ offset`
      - `+ limit`

# 3.1.42 2023-06-08

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **UpdateNode**
    - changes of response param
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **DeleteNode**
    - changes of response param
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **CreateNode**
    - changes of request param
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
    - changes of response param
      - `+ spec.extendParam.kube-reserved-mem`
      - `+ spec.extendParam.system-reserved-mem`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.extendParam.kube-reserved-mem`
      - `+ items.spec.extendParam.system-reserved-mem`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **UpdateNodePool**
    - changes of response param
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
    - changes of response param
      - `+ spec.type: enum value [pm]`
      - `+ spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ spec.nodeTemplate.extendParam.system-reserved-mem`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.type: enum value [pm]`
      - `+ items.spec.nodeTemplate.extendParam.kube-reserved-mem`
      - `+ items.spec.nodeTemplate.extendParam.system-reserved-mem`

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListRecordSetsByZone**
    - changes of request param
      - `+ search_mode`
  - **CreateRecordSet**
    - changes of request param
      - `* body: object<CreateRecordSetReq> -> object<CreateRecordSetRequestBody>`
  - **CreateRecordSetWithLine**
    - changes of request param
      - `* body: object<CreateRecordSetWithLineReq> -> object<CreateRecordSetWithLineRequestBody>`
  - **ListPublicZones**
    - changes of request param
      - `+ search_mode`
  - **ListPrivateZones**
    - changes of request param
      - `+ search_mode`
  - **ListRecordSets**
    - changes of request param
      - `+ search_mode`

### HuaweiCloud SDK ECS

- _Features_
  - Support the interface `ChangeServerChargeMode`
- _Bug Fix_
  - None
- _Change_
  - **CreateServers**
    - changes of request param
      - `+ server.nics.allowed_address_pairs`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.nics.allowed_address_pairs`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListListeners**
    - changes of response param
      - `+ listeners.port_ranges`
  - **CreateListener**
    - changes of request param
      - `+ listener.port_ranges`
    - changes of response param
      - `+ listener.port_ranges`
  - **ShowListener**
    - changes of response param
      - `+ listener.port_ranges`
  - **UpdateListener**
    - changes of response param
      - `+ listener.port_ranges`
  - **ListPools**
    - changes of response param
      - `+ pools.any_port_enable`
  - **CreatePool**
    - changes of request param
      - `+ pool.any_port_enable`
    - changes of response param
      - `+ pool.any_port_enable`
  - **ShowPool**
    - changes of response param
      - `+ pool.any_port_enable`
  - **UpdatePool**
    - changes of response param
      - `+ pool.any_port_enable`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the following interfaces：
    - `UpdateFuncSnapshot`
    - `ShowFuncSnapshotState`
    - `ShowResInstanceInfo`
    - `ShowProjectTagsList`
    - `CreateTags`
    - `DeleteTags`
    - `CreateVpcEndpoint`
    - `DeleteVpcEndpoint`
- _Bug Fix_
  - None
- _Change_
  - **ListStatistics**
    - changes of response param
      - `* count.value: int32 -> number`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interfaces `RetryBatchTask`, `StopBatchTask`
- _Bug Fix_
  - None
- _Change_
  - **CreateBatchTask**
    - changes of response param
      - `+ task_progress.removed`
      - `+ task_progress.device_in_progress`
      - `+ task_progress.rejected`
  - **ListBatchTasks**
    - changes of response param
      - `+ batchtasks.task_progress.removed`
      - `+ batchtasks.task_progress.device_in_progress`
      - `+ batchtasks.task_progress.rejected`
  - **ShowBatchTask**
    - changes of request param
      - `+ task_detail_status`
      - `+ target`
    - changes of response param
      - `+ batchtask.task_progress.removed`
      - `+ batchtask.task_progress.device_in_progress`
      - `+ batchtask.task_progress.rejected`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `AddIssueWorkHours`, `ListProjectWorkHoursType`
- _Bug Fix_
  - None
- _Change_
  - **ShowProjectWorkHours**
    - changes of response param
      - `+ work_hours.work_hours_created_time`
      - `+ work_hours.work_hours_updated_time`
  - **ListProjectWorkHours**
    - changes of response param
      - `+ work_hours.work_hours_created_time`
      - `+ work_hours.work_hours_updated_time`
  - **ListIssueCustomFields**
    - changes of request param
      - `+ included_not_in_use`
    - changes of response param
      - `+ datas.create_time`
  - **ListIssuesV4**
    - changes of request param
      - `+ created_time_interval`
      - `+ closed_time_interval`

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the interfaces `SendDlqMessage`, `ValidateConsumedMessage`
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `SendRocketMqDlqMessage`, `ValidateRocketMqConsumedMessage`
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ product_id: enum value [c6.4u8g.cluster.small]`

### HuaweiCloud SDK TMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListResource**
    - changes of response param
      - `+ resources.tags`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddressGroup**
    - changes of response param
      - `+ address_group.enterprise_project_id`
  - **UpdateAddressGroup**
    - changes of response param
      - `+ address_group.enterprise_project_id`
  - **ListAddressGroup**
    - changes of request param
      - `+ enterprise_project_id`
    - changes of response param
      - `+ address_groups.enterprise_project_id`
  - **CreateAddressGroup**
    - changes of request param
      - `+ address_group.enterprise_project_id`
    - changes of response param
      - `+ address_group.enterprise_project_id`

# 3.1.41 2023-06-01

### HuaweiCloud SDK CBR

- _Features_
  - Support the interface `ShowSummary`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowAddonInstance**
    - changes of response param
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **UpdateAddonInstance**
    - changes of request param
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
    - changes of response param
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **CreateAddonInstance**
    - changes of request param
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
    - changes of response param
      - `+ metadata.alias`
      - `* metadata: object<Metadata> -> object<AddonMetadata>`
  - **ListAddonInstances**
    - changes of response param
      - `+ items.metadata.alias`
      - `* items.metadata: object<Metadata> -> object<AddonMetadata>`
  - **ListAddonTemplates**
    - changes of response param
      - `+ items.metadata.alias`
      - `* items.metadata: object<Metadata> -> object<AddonMetadata>`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowLogs**
    - changes of request param
      - `+ start_time`
      - `+ end_time`
      - `- query_date`
  - **ShowDomainFullConfig**
    - changes of request param
      - `+ show_special_configs`
    - changes of response param
      - `- configs.error_code_cache.code: enum value [400,403,404,405,414,500,501,502,503,504]`
      - `+ configs.flexible_origin.back_sources.http_port`
      - `+ configs.flexible_origin.back_sources.https_port`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `- configs.error_code_cache.code: enum value [400,403,404,405,414,500,501,502,503,504]`
      - `+ configs.flexible_origin.back_sources.http_port`
      - `+ configs.flexible_origin.back_sources.https_port`

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RestorePtrRecord**
    - changes of request param
      - `* ptrdname: string -> object`
  - **ShowRecordSet**
    - changes of response param
      - `+ bundle`
  - **CreateEipRecordSet**
    - changes of response param
      - `+ enterprise_project_id`
  - **ShowPtrRecordSet**
    - changes of response param
      - `+ enterprise_project_id`
  - **ShowResourceTag**
    - changes of response param
      - `+ enterpriseProjectOrDefault`
  - **ListPrivateZones**
    - changes of request param
      - `* type: required -> optional`

### HuaweiCloud SDK ELB

- _Features_
  - Support the interfaces `DeleteLoadBalancerForce`, `DeleteListenerForce`, `BatchUpdateMembers`
- _Bug Fix_
  - None
- _Change_
  - **ShowQuota**
    - changes of response param
      - `+ quota.condition_per_policy`
      - `+ quota.listeners_per_pool`
      - `+ quota.listeners_per_loadbalancer`
      - `* quota.ipgroup_bindings: string -> int32`
      - `* quota.ipgroup_max_length: string -> int32`
  - **ShowLoadBalancer**
    - changes of response param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **UpdateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ListListeners**
    - changes of request param
      - `+ protection_status`
    - changes of response param
      - `+ listeners.protection_status`
      - `+ listeners.protection_reason`
      - `+ listeners.gzip_enable`
  - **CreateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
    - changes of response param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **ShowListener**
    - changes of response param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **UpdateListener**
    - changes of request param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
    - changes of response param
      - `+ listener.protection_status`
      - `+ listener.protection_reason`
      - `+ listener.gzip_enable`
  - **ListPools**
    - changes of request param
      - `+ protection_status`
    - changes of response param
      - `+ pools.protection_status`
      - `+ pools.protection_reason`
  - **CreatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **ShowPool**
    - changes of response param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **UpdatePool**
    - changes of request param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
    - changes of response param
      - `+ pool.protection_status`
      - `+ pool.protection_reason`
  - **UpdateMember**
    - changes of request param
      - `+ member.protocol_port`
  - **ListLoadBalancers**
    - changes of request param
      - `+ protection_status`
      - `+ global_eips`
    - changes of response param
      - `+ loadbalancers.protection_status`
      - `+ loadbalancers.protection_reason`
  - **CreateLoadBalancer**
    - changes of request param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
    - changes of response param
      - `+ loadbalancer.protection_status`
      - `+ loadbalancer.protection_reason`
  - **ListL7Policies**
    - changes of response param
      - `+ l7policies.redirect_pools_extend_config`
      - `- l7policies.redirect_pools_config`
  - **CreateL7Policy**
    - changes of request param
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
    - changes of response param
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
  - **ShowL7Policy**
    - changes of response param
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
  - **UpdateL7Policy**
    - changes of request param
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`
    - changes of response param
      - `+ l7policy.redirect_pools_extend_config`
      - `- l7policy.redirect_pools_config`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListInstanceTopics**
    - changes of request param
      - `+ offset`
      - `+ limit`
  - **ListInstances**
    - changes of request param
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK ProjectMan

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowIssueV4**
    - changes of response param
      - `+ story_point`
  - **SearchIssues**
    - changes of response param
      - `+ issue_list.due_date`
  - **ListIssueCommentsV4**
    - changes of response param
      - `+ comments.timestamp`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstanceByEngine**
    - changes of request param
      - `+ bss_param`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ bss_param`
  - **ListInstancesDetails**
    - changes of request param
      - `+ offset`
      - `+ limit`

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the following interfaces：
    - `SendRocketMqDlqMessage`
    - `ValidateRocketMqConsumedMessage`
    - `ListRocketMqMigrationTask`
    - `CreateRocketMqMigrationTask`
    - `DeleteRocketMqMigrationTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SMN

- _Features_
  - Support the following interfaces：
    - `UpdateSubscription`
    - `ListLogtank`
    - `CreateLogtank`
    - `UpdateLogtank`
    - `DeleteLogtank`
- _Bug Fix_
  - None
- _Change_
  - **ListTopicDetails**
    - changes of response param
      - `+ topic_id`
  - **ListTopics**
    - changes of request param
      - `+ topic_id`
    - changes of response param
      - `+ topics.topic_id`
  - **ListTopicAttributes**
    - changes of response param
      - `+ attributes.access_policy`
      - `+ attributes.introduction`
      - `- attributes.Version`
      - `- attributes.Id`
      - `- attributes.Statement`
  - **AddSubscription**
    - changes of request param
      - `+ extension`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateAssetByFileUpload**
    - changes of request param
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **PublishAssetFromObs**
    - changes of request param
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **CreateAssetReviewTask**
    - changes of request param
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
    - changes of response param
      - `+ review.interval`
      - `+ review.politics`
      - `+ review.terrorism`
      - `+ review.porn`
  - **UploadMetaDataByUrl**
    - changes of request param
      - `+ upload_metadatas.review.interval`
      - `+ upload_metadatas.review.politics`
      - `+ upload_metadatas.review.terrorism`
      - `+ upload_metadatas.review.porn`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateVpcPeering**
    - changes of request param
      - `+ peering.description`

# 3.1.40 2023-05-25

### HuaweiCloud SDK CBR

- _Features_
  - Support the following interfaces：
    - `ImportCheckpoint`
    - `ListExternalVault`
    - `BatchUpdateVault`
    - `SetVaultResource`
    - `ShowMetadata`
    - `CheckAgent`
    - `ListProjects`
    - `ListDomainProjects`
    - `ShowDomain`
    - `ShowMigrateStatus`
    - `MigrateDomain`
    - `ShowStorageUsage`
    - `UpdateOrder`
    - `CreatePostPaidVault`
    - `UpdateBackup`
- _Bug Fix_
  - None
- _Change_
  - **CreateVault**
    - changes of request param
      - `+ vault.threshold`
      - `+ vault.smn_notify`
      - `+ vault.backup_name_prefix`
      - `+ vault.demand_billing`
    - changes of response param
      - `+ vault.backup_name_prefix`
      - `+ vault.demand_billing`
      - `+ vault.cbc_delete_count`
      - `+ vault.frozen`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowCluster**
    - changes of response param
      - `+ metadata.alias`
  - **UpdateCluster**
    - changes of request param
      - `+ metadata`
    - changes of response param
      - `+ metadata.alias`
  - **DeleteCluster**
    - changes of response param
      - `+ metadata.alias`
  - **MigrateNode**
    - changes of request param
      - `+ spec.runtime`
    - changes of response param
      - `+ spec.runtime`
  - **CreateCluster**
    - changes of request param
      - `+ metadata.alias`
    - changes of response param
      - `+ metadata.alias`
  - **ListClusters**
    - changes of response param
      - `+ items.metadata.alias`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainDetailByName**
    - changes of response param
      - `+ domain.domain_name`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListMigrationTask**
    - changes of response param
      - `- task_name`
      - `- target_instance_id`
      - `- target_instance_address`
      - `- target_instance_name`
      - `- migrate_type`
      - `- created_at`
      - `- source_instance_id`
      - `- task_id`
      - `- data_source`
      - `- migration_method`
      - `- source_instance_name`
      - `- status`
  - **ListConfigTemplates**
    - changes of response param
      - `* template_num: number -> integer`
  - **ListInstances**
    - changes of response param
      - `+ instances.updated_at`
  - **ListBackgroundTask**
    - changes of response param
      - `- updated_at`
      - `- created_at`
      - `- status`
  - **ListFlavors**
    - changes of response param
      - `+ flavors.flavors_available_zones.unit`
      - `+ flavors.flavors_available_zones.available_zones`

### HuaweiCloud SDK ECS

- _Features_
  - Support the interface `ListFlavorSellPolicies`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPublicipsByTags**
    - changes of response param
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **AddPublicipsIntoSharedBandwidth**
    - changes of response param
      - `+ bandwidth.enable_bandwidth_rules`
      - `+ bandwidth.rule_quota`
      - `+ bandwidth.bandwidth_rules`

### HuaweiCloud SDK IAM

- _Features_
  - Support the interfaces `AssociateRoleToAgencyOnEnterpriseProject`, `RevokeRoleFromAgencyOnEnterpriseProject`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `CreateVideoObjectMaskingTask`, `ShowVideoObjectMaskingTask`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interfaces `DeleteConnector`, `CreateDeleteConnectorOrder`, `CreateKafkaConsumerGroup`, `CloseKafkaManager`
- _Bug Fix_
  - None
- _Change_
  - **ShowInstance**
    - changes of response param
      - `+ kafka_manager_enable`
  - **ListInstances**
    - changes of response param
      - `+ kafka_manager_enable`
      - `+ instances.kafka_manager_enable`

### HuaweiCloud SDK MSGSMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowSignatureFile**
    - changes of response param
      - `+ file_desc`
  - **UpdateApp**
    - changes of response param
      - `- app_secret`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreatePostPaidInstanceByEngine**
    - changes of request param
      - `+ engine_version: enum value [3.8.35]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ engine_version: enum value [3.8.35]`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateVpc**
    - changes of request param
      - `+ vpc.tags`
  - **CreateSubnet**
    - changes of request param
      - `+ subnet.tags`
    - **ShowAddressGroup**
    - changes of response param
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`
  - **UpdateAddressGroup**
    - changes of request param
      - `+ address_group.max_capacity`
    - changes of response param
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`
  - **ListAddressGroup**
    - changes of response param
      - `+ address_groups.max_capacity`
      - `+ address_groups.status`
      - `+ address_groups.status_message`
  - **CreateAddressGroup**
    - changes of request param
      - `+ address_group.max_capacity`
    - changes of response param
      - `+ address_group.max_capacity`
      - `+ address_group.status`
      - `+ address_group.status_message`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListServiceDescribeDetails**
    - changes of response param
      - `+ enable_policy`
  - **ListServiceDetails**
    - changes of response param
      - `- vip_port_id`
  - **UpdateEndpointService**
    - changes of request param
      - `- vip_port_id`
    - changes of response param
      - `- vip_port_id`
  - **ListServicePublicDetails**
    - changes of response param
      - `+ endpoint_services.enable_policy`
  - **CreateEndpointService**
    - changes of request param
      - `- vip_port_id`
    - changes of response param
      - `- vip_port_id`
  - **ListEndpointService**
    - changes of response param
      - `- endpoint_services.vip_port_id`

# 3.1.39 2023-05-18

### HuaweiCloud SDK CBR

- _Features_
  - Support the following interfaces：
    - `AddAgentPath`
    - `ShowAgent`
    - `UpdateAgent`
    - `UnregisterAgent`
    - `ListAgent`
    - `RegisterAgent`
    - `RemoveAgentPath`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ status.lastProbeTime`
  - **UpdateNode**
    - changes of response param
      - `+ status.lastProbeTime`
  - **DeleteNode**
    - changes of response param
      - `+ status.lastProbeTime`
  - **CreateNode**
    - changes of response param
      - `+ status.lastProbeTime`
  - **ListNodes**
    - changes of response param
      - `+ items.status.lastProbeTime`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateRefreshTasks**
    - changes of request param
      - `* refresh_task.mode: boolean -> string`
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.key`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.expire_time`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.flexible_origin`
      - `+ configs.slice_etag_status`
      - `+ configs.origin_receive_timeout`
      - `+ configs.remote_auth`
      - `+ configs.websocket`
      - `+ configs.video_seek`
      - `+ configs.request_limit_rules`
      - `+ configs.url_auth.sign_method`
      - `+ configs.url_auth.match_type`
      - `+ configs.url_auth.backup_key`
      - `+ configs.url_auth.sign_arg`
      - `+ configs.https.certificate_type`
      - `+ configs.https.ocsp_stapling_status`
      - `+ configs.sources.obs_bucket_type`
      - `+ configs.compress.file_type`
      - `+ configs.user_agent_filter.ua_list`
  - **ShowDomainDetailByName**
    - changes of response param
      - `+ domain.sources.obs_bucket_type`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateServers**
    - changes of request param
      - `+ server.root_volume.metadata`
      - `- server.root_volume.extendparam.__system__encrypted`
      - `- server.root_volume.extendparam.__system__cmkid`
      - `+ server.data_volumes.delete_on_termination`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.data_volumes.delete_on_termination`
      - `+ server.root_volume.metadata`
      - `- server.root_volume.extendparam.__system__encrypted`
      - `- server.root_volume.extendparam.__system__cmkid`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **BroadcastMessage**
    - changes of request param
      - `+ ttl`
      - `+ message_id`
  - **ShowDeviceGroup**
    - changes of response param
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **UpdateDeviceGroup**
    - changes of response param
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **SearchDevices**
    - changes of response param
      - `+ devices.groups`
  - **AddDeviceGroup**
    - changes of request param
      - `+ group_type`
      - `+ dynamic_group_rule`
    - changes of response param
      - `+ dynamic_group_rule`
      - `+ group_type`
  - **ListDeviceGroups**
    - changes of request param
      - `+ group_type`
      - `+ name`
    - changes of response param
      - `+ device_groups.group_type`
      - `* device_groups: list<DeviceGroupResponsSummery> -> list<DeviceGroupResponseSummary>`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `ListTemplates`, `SearchIssues`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.38 2023-05-11

### HuaweiCloud SDK AOS

- _Features_
  - Support the interface `ContinueDeployStack`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVaultResourceInstances**
    - changes of response param
      - `* resources.resource_detail: list<Vault> -> object<InstancesResourceDetail>`
  - **ListPolicies**
    - changes of response param
      - `+ policies.operation_definition.full_backup_interval`
  - **CreatePolicy**
    - changes of request param
      - `+ policy.operation_definition.full_backup_interval`
    - changes of response param
      - `+ policy.operation_definition.full_backup_interval`
  - **ShowPolicy**
    - changes of response param
      - `+ policy.operation_definition.full_backup_interval`
  - **UpdatePolicy**
    - changes of request param
      - `+ policy.operation_definition.full_backup_interval`
    - changes of response param
      - `+ policy.operation_definition.full_backup_interval`
  - **CreateVault**
    - changes of request param
      - `- vault.billing.extra_info`

### HuaweiCloud SDK ECS

- _Features_
  - Support the interface `NovaAttachInterface`
- _Bug Fix_
  - None
- _Change_
  - **ReinstallServerWithoutCloudInit**
    - changes of request param
      - `+ os-reinstall.metadata`
  - **ChangeServerOsWithoutCloudInit**
    - changes of request param
      - `+ os-change.metadata`
  - **ReinstallServerWithCloudInit**
    - changes of request param
      - `+ os-reinstall.metadata.__system__encrypted`
      - `+ os-reinstall.metadata.__system__cmkid`
  - **ChangeServerOsWithCloudInit**
    - changes of request param
      - `+ os-change.metadata.__system__encrypted`
      - `+ os-change.metadata.__system__cmkid`
  - **CreateServers**
    - changes of request param
      - `+ server.root_volume.extendparam.__system__encrypted`
      - `+ server.root_volume.extendparam.__system__cmkid`
  - **CreatePostPaidServers**
    - changes of request param
      - `+ server.root_volume.extendparam.__system__encrypted`
      - `+ server.root_volume.extendparam.__system__cmkid`

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `CreateVideoTaggingMediaTask`, `ShowVideoTaggingMediaTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListImages**
    - changes of request param
      - `+ __imagetype: enum value [market]`

# 3.1.37 2023-04-27

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.ipv6_accelerate`
      - `+ configs.origin_range_status`

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListIpsProtectModeUsingPost**
    - changes of response param
      - `+ data`
      - `- object_id`
      - `- status`

### HuaweiCloud SDK DCS

- _Features_
  - Support the interfaces `ResetPassword`, `UpdateInstanceBandwidth`, `ListConfigTemplates`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `RunQueryCustomTags`, `RunDeleteCustomTags`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateInstanceByEngine**
    - changes of request param
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms`
  - **ShowInstance**
    - changes of response param
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`
  - **CreatePostPaidInstance**
    - changes of request param
      - `+ kafka_security_protocol`
      - `+ sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`
  - **ListInstances**
    - changes of response param
      - `+ kafka_security_protocol`
      - `+ instances.kafka_security_protocol`
      - `+ instances.sasl_enabled_mechanisms: enum value [PLAIN,SCRAM-SHA-512]`

### HuaweiCloud SDK KMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListKeys**
    - changes of response param
      - `+ key_details.partition_type`
  - **ListKeyDetail**
    - changes of response param
      - `+ key_info.partition_type`
  - **ListRetirableGrants**
    - changes of response param
      - `+ total`
  - **ListKmsByTags**
    - changes of response param
      - `+ resources.resource_detail.partition_type`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowConsumerListOrDetails**
    - changes of response param
      - `* total: int64 -> int32`

# 3.1.36 2023-04-20

### HuaweiCloud SDK AOS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **GetStackTemplate**
    - changes of request param
      - `- executor`
  - **ListStackEvents**
    - changes of request param
      - `- executor`
  - **ListStackOutputs**
    - changes of request param
      - `- executor`
  - **DeleteStack**
    - changes of request param
      - `- executor`
  - **DeleteExecutionPlan**
    - changes of request param
      - `- executor`
  - **ApplyExecutionPlan**
    - changes of request param
      - `- executor`
  - **GetExecutionPlan**
    - changes of request param
      - `- executor`
  - **ListStackResources**
    - changes of request param
      - `- executor`
  - **ListExecutionPlans**
    - changes of request param
      - `- executor`
  - **CreateExecutionPlan**
    - changes of request param
      - `- executor`
  - **GetExecutionPlanMetadata**
    - changes of request param
      - `- executor`
  - **GetStackMetadata**
    - changes of request param
      - `- executor`
  - **ListStacks**
    - changes of request param
      - `- executor`
  - **CreateStack**
    - changes of request param
      - `- executor`
  - **DeployStack**
    - changes of request param
      - `- executor`

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces `ShowDomainFullConfig`, `UpdateDomainFullConfig`
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainFullConfig**
    - changes of response param
      - `+ configs.origin_follow302_status`
      - `+ configs.cache_rules`
      - `+ configs.ip_filter`
      - `+ configs.referer`
      - `+ configs.force_redirect.redirect_code`
  - **UpdateDomainFullConfig**
    - changes of request param
      - `+ configs.origin_follow302_status`
      - `+ configs.cache_rules`
      - `+ configs.ip_filter`
      - `+ configs.referer`
      - `+ configs.force_redirect.redirect_code`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateRedislogDownloadLink**
    - changes of response param
      - `+ backup_id`

### HuaweiCloud SDK DDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateConfiguration**
    - changes of response param
      - `+ configuration`
      - `- datastore_version`
      - `- created`
      - `- name`
      - `- description`
      - `- id`
      - `- datastore_name`
      - `- updated`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ImportFunction**
    - changes of response param
      - `+ gpu_memory`
      - `+ func_vpc.security_groups`
  - **ListFunctions**
    - changes of response param
      - `+ functions.gpu_memory`
      - `+ functions.is_bridge_function`
      - `+ functions.bind_bridge_funcUrns`
  - **CreateFunction**
    - changes of request param
      - `+ gpu_memory`
      - `+ log_config`
      - `+ network_controller`
      - `+ func_vpc.security_groups`
    - changes of response param
      - `+ gpu_memory`
      - `+ func_vpc.security_groups`
  - **ShowFunctionConfig**
    - changes of response param
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ func_vpc.security_groups`
  - **UpdateFunctionConfig**
    - changes of request param
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ log_config`
      - `+ network_controller`
      - `+ restore_hook_handler`
      - `+ restore_hook_timeout`
      - `+ func_vpc.security_groups`
    - changes of response param
      - `+ gpu_memory`
      - `+ ephemeral_storage`
      - `+ func_vpc.security_groups`
  - **UpdateFunctionMaxInstanceConfig**
    - changes of response param
      - `+ func_vpc.security_groups`
  - **CreateFunctionVersion**
    - changes of response param
      - `+ func_vpc.security_groups`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `CreateVideoTranslateTask`
    - `ShowVideoTranslateTask`
    - `CreateImageTranslateTask`
    - `ShowImageTranslateTask`
    - `CreateVideoCoverAnalysisTask`
    - `ShowVideoCoverAnalysisTask`
    - `CreateVideoSummarizationAnalysisTask`
    - `ShowVideoSummarizationAnalysisTask`
    - `CreateVideoShotSplitTask`
    - `ShowVideoShotSplitTask`
  - **CreateImageHighresolutionMattingTask**
    - changes of request param
      - `- input.data.bucket`
      - `- input.data.path`
  - **ShowImageHighresolutionMattingTask**
    - changes of response param
      - `- input.data.bucket`
      - `- input.data.path`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interface `BroadcastMessage`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeDriverLicense**
    - changes of response param
      - `+ result.front`
      - `+ result.back`
  - **RecognizeThailandIdcard**
    - changes of response param
      - `+ result.type`
      - `+ result.name_en`
      - `+ result.ref_number`
      - `+ result.confidence.name_en`
      - `+ result.confidence.ref_number`

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the interface `ShowConsumerConnections`
- _Bug Fix_
  - None
- _Change_
  - **ShowConsumerListOrDetails**
    - changes of response param
      - `+ total`
      - `+ brokers`
  - **ShowUser**
    - changes of response param
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **UpdateUser**
    - changes of request param
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
    - changes of response param
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **UpdateInstance**
    - changes of request param
      - `+ enable_publicip`
      - `+ publicip_id`
  - **CreateUser**
    - changes of request param
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
    - changes of response param
      - `- default_group_perm: enum value [PUB,PUB|SUB]`
      - `- group_perms.perm: enum value [PUB,PUB|SUB]`
  - **ListUser**
    - changes of response param
      - `- users.default_group_perm: enum value [PUB,PUB|SUB]`
      - `- users.group_perms.perm: enum value [PUB,PUB|SUB]`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListVpcsByTags**
    - changes of response param
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **ListSubnetsByTags**
    - changes of response param
      - `+ resources.resource_detail`
      - `- resources.resouce_detail`
  - **UpdateRouteTable**
    - changes of request param
      - `+ routetable.routes.add`
      - `+ routetable.routes.mod`
      - `+ routetable.routes.del`
      - `* routetable.routes: map<string, list<RouteTableRoute>> -> object<RouteTableRouteAction>`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListServiceDescribeDetails**
    - changes of response param
      - `+ public_border_group`
  - **ListServiceDetails**
    - changes of response param
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **UpdateEndpointService**
    - changes of request param
      - `+ tcp_proxy`
    - changes of response param
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **ListEndpointInfoDetails**
    - changes of response param
      - `+ endpoint_pool_id`
      - `+ public_border_group`
  - **CreateEndpointService**
    - changes of request param
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
    - changes of response param
      - `+ enable_policy`
      - `+ tcp_proxy: enum value [proxy_vni]`
  - **ListEndpointService**
    - changes of response param
      - `+ endpoint_services.enable_policy`
      - `+ endpoint_services.tcp_proxy: enum value [proxy_vni]`
  - **CreateEndpoint**
    - changes of response param
      - `+ endpoint_pool_id`
      - `+ public_border_group`
      - `+ ip`

# 3.1.35 2023-04-13

### HuaweiCloud SDK EVS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowVolume**
    - changes of response param
      - `+ volume.iops`
      - `+ volume.throughput`
  - **ListVolumes**
    - changes of response param
      - `+ volumes.iops`
      - `+ volumes.throughput`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `CreateVideoSynthesisTask`
    - `ShowVideoSynthesisTask`
    - `CreateImageToVideoTask`
    - `ShowImageToVideoTask`
    - `CreateVideoCuttingTask`
    - `ShowVideoCuttingTask`
    - `RunImageWisedesignCrop`
    - `RunImageWisedesignInpainting`
  - **RunImageTagging**
    - changes of response param
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<ImageTaggingBoundingBox>`
  - **RunImageMediaTagging**
    - changes of response param
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<BoundingBox>`
      - `* result.tags.instances: list<ImageTaggingInstance> -> list<ImageMediaTaggingInstance>`
  - **RunImageMediaTaggingDet**
    - changes of response param
      - `+ result.tags.instances.bounding_box.width`
      - `+ result.tags.instances.bounding_box.height`
      - `+ result.tags.instances.bounding_box.top_left_x`
      - `+ result.tags.instances.bounding_box.top_left_y`
      - `* result.tags.instances.bounding_box: object -> object<BoundingBox>`
  - **ShowVideoShotSplitTask**
    - changes of response param
      - `- state: enum value [SUCCEEDED,FAILED,RUNNING]`
  - **CreateVideoTranslateTask**
    - changes of request param
      - `* body: object<VideoTranslateRequestBody> -> object<CreateVideoTranslateTaskRequestBody>`
  - **CreateImageHighresolutionMattingTask**
    - changes of request param
      - `* input.data: list<TaskInputData> -> list<ImageHighresolutionMattingInputData>`
      - `* input: object<TaskInput> -> object<ImageHighresolutionMattingInput>`
  - **ShowImageHighresolutionMattingTask**
    - changes of response param
      - `* input.data: list<TaskInputData> -> list<ImageHighresolutionMattingInputData>`
      - `* input: object<TaskInput> -> object<ImageHighresolutionMattingInput>`
  - **CreateImageTranslateTask**
    - changes of request param
      - `* input.data: list<TaskInputData> -> list<ImageTranslateTaskInputData>`
      - `* input: object<TaskInput> -> object<ImageTranslateTaskInput>`
      - `* body: object<ImageTranslateRequestBody> -> object<CreateImageTranslateRequestBody>`
  - **ShowImageTranslateTask**
    - changes of response param
      - `* input.data: list<TaskInputData> -> list<ImageTranslateTaskInputData>`
      - `* input: object<TaskInput> -> object<ImageTranslateTaskInput>`
  - **CreateVideoCoverAnalysisTask**
    - changes of request param
      - `* input.data: list<TaskInputData> -> list<VideoCoverAnalysisTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoCoverAnalysisTaskInput>`
      - `* body: object<VideoCoverAnalysisCreateTaskRequestBody> -> object<CreateVideoCoverAnalysisTaskRequestBody>`
  - **ShowVideoCoverAnalysisTask**
    - changes of response param
      - `* input.data: list<TaskInputData> -> list<VideoCoverAnalysisTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoCoverAnalysisTaskInput>`
  - **CreateVideoSummarizationAnalysisTask**
    - changes of request param
      - `* input.data: list<TaskInputData> -> list<VideoSummarizationTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoSummarizationTaskInput>`
      - `* body: object<VideoSummarizationCreateTaskRequestBody> -> object<CreateVideoSummarizationTaskRequestBody>`
  - **ShowVideoSummarizationAnalysisTask**
    - changes of response param
      - `* input.data: list<TaskInputData> -> list<VideoSummarizationTaskInputData>`
      - `* input: object<TaskInput> -> object<VideoSummarizationTaskInput>`
  - **CreateVideoObjectMaskingTask**
    - changes of request param
      - `* input.data: list<TaskInputData> -> list<ObjectMaskingTaskInputData>`
      - `* input: object<TaskInput> -> object<ObjectMaskingTaskInput>`
  - **ShowVideoObjectMaskingTask**
    - changes of response param
      - `* input.data: list<TaskInputData> -> list<ObjectMaskingTaskInputData>`
      - `* input: object<TaskInput> -> object<ObjectMaskingTaskInput>`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interface `BatchDeleteGroup`
- _Bug Fix_
  - None
- _Change_
  - **ResizeEngineInstance**
    - changes of request param
      - `+ publicip_id`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeShortAudio**
    - changes of request param
      - `+ config.property: enum value [english_8k_common,english_16k_common]`
  - **CollectTranscriberJob**
    - changes of response param
      - `+ job_id`

# 3.1.34 2023-04-06

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateRefreshTasks**
    - changes of request param
      - `+ refresh_task.mode`

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListAlarmHistories**
    - changes of response param
      - `+ alarm_histories.type: enum value [DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`
  - **ListAlarmRules**
    - changes of response param
      - `+ alarms.type: enum value [EVENT.SYS,EVENT.CUSTOM,DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`
  - **CreateAlarmRules**
    - changes of request param
      - `+ type: enum value [EVENT.SYS,EVENT.CUSTOM,DNSHealthCheck,RESOURCE_GROUP,MULTI_INSTANCE,ALL_INSTANCE]`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `CreateTextToImageTask`, `ShowTextToImageTask`, `CreateImageVariationTask`, `ShowImageVariationTask`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeFinancialStatement**
    - changes of request param
      - `+ return_rectification_matrix`
    - changes of response param
      - `+ result.rectification_matrix`

# 3.1.33 2023-03-30

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBackups**
    - changes of request param
      - `+ incremental`
  - **ListVault**
    - changes of response param
      - `+ vaults.billing.object_type: enum value [vmware,rds,file]`
  - **CreateVault**
    - changes of request param
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
    - changes of response param
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowVault**
    - changes of response param
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **UpdateVault**
    - changes of response param
      - `+ vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowVaultResourceInstances**
    - changes of response param
      - `+ resources.resource_detail.billing.object_type: enum value [vmware,rds,file]`
  - **ListProtectable**
    - changes of response param
      - `+ instances.protectable.vault.billing.object_type: enum value [vmware,rds,file]`
  - **ShowProtectable**
    - changes of response param
      - `+ instance.protectable.vault.billing.object_type: enum value [vmware,rds,file]`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListOtaPackageInfo**
    - changes of request param
      - `- Sp-Auth-Token`
  - **CreateOtaPackage**
    - changes of request param
      - `- Sp-Auth-Token`
  - **DeleteOtaPackage**
    - changes of request param
      - `- Sp-Auth-Token`
  - **ShowOtaPackage**
    - changes of request param
      - `- Sp-Auth-Token`
  - **ShowRuleAction**
    - changes of response param
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **UpdateRuleAction**
    - changes of request param
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
    - changes of response param
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **CreateRuleAction**
    - changes of request param
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
    - changes of response param
      - `+ channel_detail.http_forwarding.signature_enable`
      - `+ channel_detail.http_forwarding.token`
  - **ListRuleActions**
    - changes of response param
      - `+ actions.channel_detail.http_forwarding.signature_enable`
      - `+ actions.channel_detail.http_forwarding.token`
  - **ShowRule**
    - changes of response param
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **UpdateRule**
    - changes of request param
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
    - changes of response param
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **CreateRule**
    - changes of request param
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
    - changes of response param
      - `+ actions.device_alarm.dimension`
      - `+ condition_group.conditions.device_linkage_status_condition`
      - `+ condition_group.conditions.device_property_condition.filters.in_values`
  - **ListRules**
    - changes of response param
      - `+ rules.actions.device_alarm.dimension`
      - `+ rules.condition_group.conditions.device_linkage_status_condition`
      - `+ rules.condition_group.conditions.device_property_condition.filters.in_values`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListPrivateDnats**
    - changes of response param
      - `* page_info.current_count: number -> integer`
  - **ListPrivateNats**
    - changes of response param
      - `* page_info.current_count: number -> integer`
  - **ListPrivateSnats**
    - changes of response param
      - `* page_info.current_count: number -> integer`
  - **ListTransitIps**
    - changes of response param
      - `* page_info.current_count: number -> integer`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **PublishAssetFromObs**
    - changes of request param
      - `+ video_type: enum value [RMVB,WEBM]`

# 3.1.32 2023-03-23

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowNode**
    - changes of response param
      - `+ spec.extendParam.agency_name`
  - **UpdateNode**
    - changes of response param
      - `+ spec.extendParam.agency_name`
  - **DeleteNode**
    - changes of response param
      - `+ spec.extendParam.agency_name`
  - **CreateNode**
    - changes of request param
      - `+ spec.extendParam.agency_name`
    - changes of response param
      - `+ spec.extendParam.agency_name`
  - **ListNodes**
    - changes of response param
      - `+ items.spec.extendParam.agency_name`
  - **ShowNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **UpdateNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **DeleteNodePool**
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **CreateNodePool**
    - changes of request param
      - `+ spec.nodeTemplate.extendParam.agency_name`
    - changes of response param
      - `+ spec.nodeTemplate.extendParam.agency_name`
  - **ListNodePools**
    - changes of response param
      - `+ items.spec.nodeTemplate.extendParam.agency_name`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowDomainDetailByName**
    - changes of response param
      - `- domain.banned_reason`
      - `- domain.locked_reason`
      - `- domain.enterprise_project_id`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **CreateMigrationTask**
    - changes of request param
      - `+ backup_files.file_source: enum value [backup_record]`
  - **ShowMigrationTask**
    - changes of response param
      - `+ backup_files.file_source: enum value [backup_record]`
  - **StopMigrationTask**
    - changes of response param
      - `+ backup_files.file_source: enum value [backup_record]`

### HuaweiCloud SDK DDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowReplSetName**
    - changes of response param
      - `+ name`
  - **UpdateReplSetName**
    - changes of response param
      - `+ job_id`

### HuaweiCloud SDK NAT

- _Features_
  - Support the following interfaces：
    - `ListPrivateNats`
    - `CreatePrivateNat`
    - `ShowPrivateNat`
    - `UpdatePrivateNat`
    - `DeletePrivateNat`
    - `ListPrivateDnats`
    - `CreatePrivateDnat`
    - `ShowPrivateDnat`
    - `UpdatePrivateDnat`
    - `DeletePrivateDnat`
    - `ListPrivateSnats`
    - `CreatePrivateSnat`
    - `ShowPrivateSnat`
    - `UpdatePrivateSnat`
    - `DeletePrivateSnat`
    - `ListTransitIps`
    - `CreateTransitIp`
    - `ShowTransitIp`
    - `DeleteTransitIp`
    - `ListPrivateNatsByTags`
    - `ListPrivateNatTags`
    - `ShowPrivateNatTags`
    - `CreatePrivateNatTag`
    - `BatchCreateDeletePrivateNatTags`
    - `DeletePrivateNatTag`
    - `ListTransitIpsByTags`
    - `ListTransitIpTags`
    - `ShowTransitIpTags`
    - `CreateTransitIpTag`
    - `BatchCreateDeleteTransitIpTags`
    - `DeleteTransitIpTag`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - Support the interfaces `ShowEngineInstanceExtendProductInfo`, `ResizeEngineInstance`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.31 2023-03-16

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ShowJobInfos**
    - changes of response param
      - `* begin_time: date-time -> string`
      - `* end_time: date-time -> string`
      - `* entities.sub_jobs.begin_time: date-time -> string`
      - `* entities.sub_jobs.end_time: date-time -> string`

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces `ListDomains`, `ShowDomainDetailByName`
- _Bug Fix_
  - None
- _Change_
  - **ListDomains**
    - changes of request param
      - `+ show_tags`
      - `+ exact_match`
    - changes of response param
      - `+ domains.tags`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **ListBandwidthPkg**
    - changes of request param
      - `+ limit`
      - `+ marker`
      - `+ offset`
  - **ListCommonPools**
    - changes of request param
      - `+ limit`
      - `+ offset`
  - **ListShareBandwidthTypes**
    - changes of request param
      - `+ marker`
      - `+ offset`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **KeystoneListMappings**
    - changes of response param
      - `* mappings.rules.local.groups: object -> string`
  - **KeystoneShowMapping**
    - changes of response param
      - `* mapping.rules.local.groups: object -> string`
  - **KeystoneCreateMapping**
    - changes of request param
      - `* mapping.rules.local.groups: object -> string`
    - changes of response param
      - `* mapping.rules.local.groups: object -> string`
  - **KeystoneUpdateMapping**
    - changes of request param
      - `* mapping.rules.local.groups: object -> string`
    - changes of response param
      - `* mapping.rules.local.groups: object -> string`

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `CreateVideoObjectMaskingTask`, `ShowVideoObjectMaskingTask`
- _Bug Fix_
  - None
- _Change_
  - **CreateTextToImageTask**
    - changes of request param
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **ShowTextToImageTask**
    - changes of response param
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **CreateImageVariationTask**
    - changes of request param
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`
  - **ShowImageVariationTask**
    - changes of response param
      - `+ config.common.inference.image_nums`
      - `+ config.common.inference.resolution: enum value [512*768,768*512,512*512]`

### HuaweiCloud SDK IVS

- _Features_
  - Support the interfaces `DetectStandardByVideoAndIdCardImage`, `DetectStandardByVideoAndNameAndId`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - **RecognizeMvsInvoice**
    - changes of request param
      - `+ return_text_location`
      - `+ return_confidence`
      - `+ type`
    - changes of response param
      - `+ result.buyer_address`
      - `+ result.buyer_phone`
      - `+ result.licence_plate_number`
      - `+ result.registration_number`
      - `+ result.dept_motor_vehicles`
      - `+ result.auction_org_name`
      - `+ result.auction_org_address`
      - `+ result.auction_org_id`
      - `+ result.auction_org_bank_account`
      - `+ result.auction_org_phone`
      - `+ result.used_vehicle_market_name`
      - `+ result.used_vehicle_market_id`
      - `+ result.used_vehicle_market_address`
      - `+ result.used_vehicle_market_bank_account`
      - `+ result.used_vehicle_market_phone`
      - `+ result.remark`
      - `+ result.drawer_name`
      - `+ result.type`
      - `+ result.text_location`
      - `+ result.confidence`

# 3.1.30 2023-03-14

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `CreateTextToImageTask`, `ShowTextToImageTask`, `CreateImageVariationTask`, `ShowImageVariationTask`
- _Bug Fix_
  - None
- _Change_
  - Remove the interfaces `RunImageWisedesignColorfilter`, `RunImageWisedesignCombine`

# 3.1.29 2023-03-09

### HuaweiCloud SDK AOS

- _Features_
  - Support the following interfaces：
    - `ListTemplates`
    - `DeleteTemplate`
    - `ShowTemplateMetadata`
    - `UpdateTemplateMetadata`
    - `ShowTemplateVersionContent`
    - `DeleteTemplateVersion`
    - `ShowTemplateVersionMetadata`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListExecutionPlans`:
    - Add the enum values `APPLY_IN_PROGRESS` to the response parameter `status`
    - The response parameter `stack_name`, `execution_plan_name` changed to required
  - Remove the enum values `IN_PLACE_UPDATE` from the response parameter `action` from the interface `GetExecutionPlan`
  - The response parameter `stack_name`, `execution_plan_name` changed to required of the interface `GetExecutionPlanMetadata`
  - Add the response parameter `resource_attributes` to the interface `ListStackResources`
  - Changes of the interface `EstimateExecutionPlanPrice`:
    - Add the response parameter `unsupported_message`
    - Modify the type `object` -> `double` of the response parameter `sale_price`
    - Modify the type `object` -> `double` of the response parameter `discount`
    - Modify the type `object` -> `double` of the response parameter `original_price`
    - Remove the enum values `WEEK` from the response parameter `period_type`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `connection_status_update_time`, `active_time` to the interface `UpdateDevice`
  - Add the response parameters `connection_status_update_time`, `active_time` to the interface `ShowDevice`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `extended_parameters` to the interface `RecognizeAutoClassification`

# 3.1.28 2023-03-07

### HuaweiCloud SDK VOD

- _Features_
  - Support the interface `ModifySubtitle`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.27 2023-03-02

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListBareMetalServers`:
    - Add the enum values `HARD_REBOOT`, `DELETED` to the response parameter `status`
    - Remove the enum values `suspended` from the response parameter `OS-EXT-STS:vm_state`
  - Changes of the interface `CreateBareMetalServers`:
    - Add the request parameter `chargingMode`
    - Remove the request parameter `chargingmode`
  - Remove the enum values `SUSPENDED` from the response parameter `OS-EXT-STS:vm_state` from the interface `ChangeBaremetalServerName`
  - Changes of the interface `ListBareMetalServerDetails`:
    - Add the enum values `HARD_REBOOT`, `DELETED` to the response parameter `status`
    - Remove the enum values `suspended` from the response parameter `OS-EXT-STS:vm_state`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowDomainFullConfig`:
    - Modify the type `string` -> `int32` of the response parameter `error_code`
    - Modify the type `string` -> `int32` of the response parameter `target_code`
  - Changes of the interface `UpdateDomainFullConfig`:
    - Modify the type `string` -> `int32` of the request parameter `error_code`
    - Modify the type `string` -> `int32` of the request parameter `target_code`

### HuaweiCloud SDK DDS

- _Features_
  - Support the interfaces `ShowReplSetName`, `UpdateReplSetName`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `UpdateTrigger`:
    - Add the request parameter `event_data`
    - Add the response parameters `trigger_id`, `trigger_type_code`, `trigger_status`, `event_data`, `last_updated_time`, `created_time`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the following interfaces：
    - `ResetDbUserPassword`
    - `ModifyDbUserPrivilege`
    - `ListDbUsers`
    - `CreateDbUser`
    - `DeleteDbUser`
    - `ListInstanceDatabases`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Image

- _Features_
  - Support the following interfaces：
    - `CreateVideoSynthesisTask`
    - `ShowVideoSynthesisTask`
    - `CreateImageToVideoTask`
    - `ShowImageToVideoTask`
    - `CreateVideoCuttingTask`
    - `ShowVideoCuttingTask`
    - `CreateVideoTranslateTask`
    - `ShowVideoTranslateTask`
    - `CreateImageHighresolutionMattingTask`
    - `ShowImageHighresolutionMattingTask`
    - `CreateImageTranslateTask`
    - `ShowImageTranslateTask`
    - `CreateVideoCoverAnalysisTask`
    - `ShowVideoCoverAnalysisTask`
    - `CreateVideoSummarizationAnalysisTask`
    - `ShowVideoSummarizationAnalysisTask`
    - `CreateVideoShotSplitTask`
    - `ShowVideoShotSplitTask`
    - `RunImageWisedesignCrop`
    - `RunImageWisedesignInpainting`
    - `RunImageWisedesignColorfilter`
    - `RunImageWisedesignCombine`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interfaces `ListOtaPackageInfo`, `CreateOtaPackage`, `ShowOtaPackage`, `DeleteOtaPackage`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListInstanceConsumerGroups`:
    - Add the response parameter `groups`
    - Remove the response parameters `group_ids`, `next_offset`, `previous_offset`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interface `ListSpecIssueStayTimes`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.26 2023-02-23

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The response parameter `value` changed to required of the interface `ListVault`
  - Changes of the interface `CreateVault`:
    - The request parameter `value` changed to required
    - The response parameter `value` changed to required
  - The response parameter `value` changed to required of the interface `ShowVault`
  - Changes of the interface `UpdateVault`:
    - The request parameter `value` changed to required
    - The response parameter `value` changed to required
  - The response parameter `value` changed to required of the interface `ListProtectable`
  - The response parameter `value` changed to required of the interface `ShowProtectable`
  - The response parameter `value` changed to required of the interface `ShowVaultResourceInstances`

### HuaweiCloud SDK DDS

- _Features_
  - Support the interface `ShrinkInstanceNodes`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `active` to the interface `ListRoutingRules`
  - Add the request parameter `mysql_forwarding` to the interface `CreateRuleAction`
  - Add the response parameter `mysql_forwarding` to the interface `ListRuleActions`
  - Changes of the interface `UpdateRuleAction`:
    - Add the request parameter `mysql_forwarding`
    - Add the response parameter `mysql_forwarding`
  - Add the response parameter `mysql_forwarding` to the interface `ShowRuleAction`

# 3.1.25 2023-02-16

### HuaweiCloud SDK DCS

- _Features_
  - Support the interfaces `CreateCustomTemplate`, `CreateAutoExpireScanTask`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByUrl`
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByUrlIntl`
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByFile`
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByFileIntl`
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByBase64`
  - Add the request parameter `nod_threshold` to the interface `DetectLiveByBase64Intl`

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `RunImageSuperResolution`, `RunRecaptureDetect`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the interfaces `CreateInstanceByEngine`, `BatchCreateOrDeleteRocketmqTag`, `ShowRocketmqTags`, `ShowRocketmqProjectTags`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `limit`, `offset` to the interface `ListInstances`
  - Add the request parameters `limit`, `offset` to the interface `ShowConsumerListOrDetails`
  - Add the request parameters `limit`, `offset` to the interface `ListConsumerGroupOfTopic`

# 3.1.24 2023-02-09

### HuaweiCloud SDK DDS

- _Features_
  - Support the interface `ListLtsSlowLogs`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `error_code` to the interface `ListAsyncInvocations`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowPauseResumeStutus`:
    - Add the request parameter `X-Auth-Token`
    - Add the response parameters `master_instance_id`, `slave_instance_id`, `data_sync_indicators`, `rto_and_rpo_indicators`
    - Remove the request parameter `x-auth-token`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `roma_forwarding`, `influxdb_forwarding`, `functiongraph_forwarding`, `mrs_kafka_forwarding`, `dms_rocketmq_forwarding` to the interface `ListRuleActions`
  - Add the request parameters `roma_forwarding`, `influxdb_forwarding`, `functiongraph_forwarding`, `mrs_kafka_forwarding`, `dms_rocketmq_forwarding` to the interface `CreateRuleAction`
  - Changes of the interface `UpdateRuleAction`:
    - Add the request parameters `roma_forwarding`, `influxdb_forwarding`, `functiongraph_forwarding`, `mrs_kafka_forwarding`, `dms_rocketmq_forwarding`
    - Add the response parameters `roma_forwarding`, `influxdb_forwarding`, `functiongraph_forwarding`, `mrs_kafka_forwarding`, `dms_rocketmq_forwarding`
  - Add the response parameters `roma_forwarding`, `influxdb_forwarding`, `functiongraph_forwarding`, `mrs_kafka_forwarding`, `dms_rocketmq_forwarding` to the interface `ShowRuleAction`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeTollInvoice`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`

# 3.1.23 2023-02-02

### HuaweiCloud SDK AOS

- _Features_
  - Support the interface `UpdateStack`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `executor` to the interface `ApplyExecutionPlan`
  - Changes of the interface `ListStackEvents`:
    - Add the request parameters `filter`, `field`
    - Remove the response parameters `resource_id_key`, `resource_id_value`, `resource_name`, `resource_type`, `time`, `event_type`, `event_message`, `elapsed_seconds`
  - The response parameter `stack_name` changed to required of the interface `GetStackMetadata`
  - Add the request parameter `executor` to the interface `CreateStack`
  - Changes of the interface `ListStackResources`:
    - Add the response parameter `index_key`
    - Remove the enum values `DELETION_SKIPPED` from the response parameter `resource_status`
  - Add the request parameter `executor` to the interface `DeployStack`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `IsoImage` to the request parameter `type` to the interface `CreateImage`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interfaces `CreateInstanceByEngine`, `ShowEngineInstanceExtendProductInfo`, `ResizeEngineInstance`, `CreateReassignmentTask`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `sasl_enabled_mechanisms` to the interface `ListInstances`
  - The request parameter `kafka_manager_user`, `kafka_manager_password` changed to not required of the interface `CreatePostPaidInstance`
  - Add the response parameter `sasl_enabled_mechanisms` to the interface `ShowInstance`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `white_glossaries` to the interface `RunTextModeration`

# 3.1.22 2023-01-19

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interface `UploadBatchTaskFile`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.21 2023-01-12

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListAlarmHistories`:
    - Add the response parameter `data_points`
    - Remove the response parameter `datapoints`

### HuaweiCloud SDK FRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByUrlIntl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveFaceByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByFileIntl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveFaceByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveByBase64Intl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectLiveFaceByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `SearchFaceByFaceId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByFileIntl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `UpdateFace`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DeleteFaceByExternalImageId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `ShowFacesByLimit`
  - Add the request parameter `Enterprise-Project-Id` to the interface `CompareFaceByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DeleteFaceByFaceId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `ShowFacesByFaceId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `AddFacesByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByUrlIntl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DeleteFaceSet`
  - Add the request parameter `Enterprise-Project-Id` to the interface `ShowFaceSet`
  - Add the request parameter `Enterprise-Project-Id` to the interface `CompareFaceByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectFaceByBase64Intl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `CreateFaceSet`
  - Add the request parameter `Enterprise-Project-Id` to the interface `ShowAllFaceSets`
  - Add the request parameter `Enterprise-Project-Id` to the interface `SearchFaceByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `AddFacesByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `AddFacesByFile`
  - Add the request parameter `Enterprise-Project-Id` to the interface `SearchFaceByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `SearchFaceByBase64`
  - Add the request parameter `Enterprise-Project-Id` to the interface `CompareFaceByUrl`
  - Add the request parameter `Enterprise-Project-Id` to the interface `BatchDeleteFaces`

### HuaweiCloud SDK IVS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectStandardByIdCardImage`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectStandardByNameAndId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectExtentionByNameAndId`
  - Add the request parameter `Enterprise-Project-Id` to the interface `DetectExtentionByIdCardImage`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeCustomTemplate`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeGeneralTable`:
    - Add the request parameters `return_char_location`, `return_rectification_matrix`
    - Add the response parameter `char_list`
  - Add the request parameter `language` to the interface `RecognizeGeneralText`
  - Changes of the interface `RecognizeWebImage`:
    - Add the response parameter `extracted_data`
    - Remove the response parameters `extracted_data`, `contact_info`, `image_size`, `height`, `width`, `name`, `phone`, `province`, `city`, `district`, `detail_address`

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the interface `ListRocketInstanceTopics`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `name` to the interface `ShowOneTopic`

# 3.1.20 2023-01-05

### HuaweiCloud SDK DCS

- _Features_
  - Support the interface `ListConfigHistories`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `ListResoleRules`
    - `SetPrivateZoneProxyPattern`
    - `ShowDomainQuota`
    - `ShowRetrieval`
    - `CreateRetrieval`
    - `ShowRetrievalVerification`
    - `CreateRetrievalVerification`
    - `ListEndpoints`
    - `CreateEndpoint`
    - `ShowEndpoint`
    - `UpdateEndpoint`
    - `DeleteEndpoint`
    - `ListEndpointIpaddresses`
    - `AssociateEndpointIpaddress`
    - `DisassociateEndpointIpaddress`
    - `ListEndpointVpcs`
    - `CreateResolveRule`
    - `AssociateResolveRuleRouter`
    - `DisassociateResolveRuleRouter`
    - `ShowResoleRule`
    - `UpdateResolveRule`
    - `DeleteResolveRule`
    - `BatchDeleteZones`
    - `BatchDeletePtrRecords`
    - `BatchSetZonesStatus`
    - `BatchSetRecordSetsStatus`
    - `BatchDeleteRecordSets`
  - Changes of the interface `CreatePrivateZone`:
    - Add the request parameter `proxy_pattern`
    - Add the response parameter `proxy_pattern`
  - Add the response parameter `proxy_pattern` to the interface `ListPrivateZones`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `DISABLED`, Remove the enum values `DISABLE` from the response parameter `trigger_status` to the interface `ListFunctionTriggers`
  - Add the enum values `DISABLED`, Remove the enum values `DISABLE` from the request parameter `trigger_status` to the interface `UpdateTrigger`
  - Add the enum values `DISABLED`, Remove the enum values `DISABLE` from the response parameter `trigger_status` to the interface `ShowFunctionTrigger`
  - Add the request parameter `enable_stream_response` to the interface `CreateWorkflow`
  - Add the request parameter `enable_stream_response` to the interface `UpdateWorkFlow`
  - Add the response parameter `enable_stream_response` to the interface `ShowWorkFlow`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `white_glossary_names` to the interface `RunTextModeration`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListPorts`:
    - Add the request parameter `security_groups`
    - Modify the type `string` -> `array` of the request parameter `fixed_ips`

# 3.1.19 2022-12-29

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `fw_instance_id`, `enterprise_project_id` to the interface `ListDnsServers`
  - Add the request parameters `fw_instance_id`, `enterprise_project_id` to the interface `UpdateDnsServers`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListVpcProtects`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListRuleHitCount`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteAclRuleCount`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ChangeIpsSwitchUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListIpsSwitchStatusUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListEastWestFirewall`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ChangeEwProtectStatus`
  - Add the request parameter `enterprise_project_id` to the interface `ListFlowLogs`
  - Add the request parameter `enterprise_project_id` to the interface `ListAccessControlLogs`
  - Add the request parameter `enterprise_project_id` to the interface `ListAttackLogs`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddRuleAclUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteRuleAclUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `UpdateRuleAclUsingPut`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListRuleAclsUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListRuleAclUsingPut`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddBlackWhiteListUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteBlackWhiteListUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `UpdateBlackWhiteListUsingPut`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListBlackWhiteListsUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ChangeIpsProtectModeUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListIpsProtectModeUsingPost`
  - Changes of the interface `ListFirewallUsingGet`:
    - Add the request parameters `enterprise_project_id`, `fw_instance_id`
    - Add the response parameters `fw_instance_name`, `enterprise_project_id`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddServiceSetUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteServiceSetUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListServiceSetDetails`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `UpdateServiceSetUsingPut`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddServiceItemsUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListServiceItemsDetails`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteServiceItemUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListParseDomainDetails`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `CountEips`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ChangeProtectEip`
  - Changes of the interface `ListEipResources`:
    - Add the request parameters `fw_instance_id`, `fw_key_word`, `eps_id`
    - Add the response parameters `fw_instance_name`, `fw_instance_id`, `fw_enterprise_project_id`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteAddressItemUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddAddressItemsUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListAddressItemsUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `AddAddressSetInfoUsingPost`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListAddressSetListUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `DeleteAddressSetInfoUsingDelete`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListAddressSetDetailUsingGet`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `UpdateAddressSetInfoUsingPut`
  - Add the request parameters `enterprise_project_id`, `fw_instance_id` to the interface `ListServiceSet`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int32` -> `int64` of the response parameter `size` of the interface `CreateBigkeyScanTask`
  - Modify the type `int32` -> `int64` of the response parameter `size` of the interface `ShowBigkeyScanTaskDetails`
  - Modify the type `int32` -> `int64` of the response parameter `size` of the interface `CreateHotkeyScanTask`
  - Modify the type `int32` -> `int64` of the response parameter `size` of the interface `ShowHotkeyTaskDetails`

### HuaweiCloud SDK DNS

- _Features_
  - Support the interfaces `AssociateResolveRuleRouter`, `DisassociateResolveRuleRouter`
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameter `total_count` from the interface `ListPublicZones`
  - Remove the response parameter `total_count` from the interface `ListPrivateZones`
  - Remove the response parameter `total_count` from the interface `ListRecordSetsByZone`
  - Remove the response parameter `total_count` from the interface `ListRecordSets`
  - Remove the response parameter `total_count` from the interface `BatchDeleteRecordSetWithLine`
  - Remove the response parameter `total_count` from the interface `BatchUpdateRecordSetWithLine`
  - Remove the response parameter `total_count` from the interface `ListRecordSetsWithLine`
  - Remove the response parameter `total_count` from the interface `CreateRecordSetWithBatchLines`
  - Remove the response parameter `total_count` from the interface `ShowRecordSetByZone`
  - Remove the response parameter `total_count` from the interface `ListPtrRecords`
  - Remove the response parameter `total_count` from the interface `ListCustomLine`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `extendParam` to the interface `ChangeBandwidthToPeriod`
  - Add the request parameter `extendParam` to the interface `ChangePublicipToPeriod`
  - Changes of the interface `ListBandwidthPkg`:
    - Add the response parameter `tenantId`
    - Remove the response parameter `tenant_id`
  - The request parameter `associate_instance_type`, `associate_instance_id` changed to required of the interface `UpdateAssociatePublicip`
  - The request parameter `associate_instance_type`, `associate_instance_id` changed to required of the interface `AssociatePublicips`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListLoadbalancersByTags`:
    - Remove the request parameter `without_any_tag`
    - The request parameter `values` changed to required
  - Changes of the interface `ListListenersByTags`:
    - Remove the request parameter `without_any_tag`
    - The request parameter `values` changed to required
  - Add the response parameters `ipgroup_bindings`, `ipgroup_max_length` to the interface `ShowQuota`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `sub_jobs_result`, `sub_jobs_list` to the interface `ShowJob`
  - Add the response parameters `sub_jobs_result`, `sub_jobs_list` to the interface `ShowJobProgress`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `name` changed to not required of the interface `UpdateTranscodeTemplate`
  - Changes of the interface `UpdateTemplateGroupCollection`:
    - The request parameter `collection_id` changed to required
    - The request parameter `name`, `template_group_list` changed to not required

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `ListVpcs`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `CreateVpc`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `ShowVpc`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `UpdateVpc`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `ListSubnets`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `CreateSubnet`
  - Add the response parameters `tenant_id`, `created_at`, `updated_at` to the interface `ShowSubnet`
  - Add the response parameters `created_at`, `updated_at` to the interface `ListRouteTables`
  - Add the response parameters `created_at`, `updated_at` to the interface `CreateRouteTable`
  - Add the response parameters `created_at`, `updated_at` to the interface `ShowRouteTable`
  - Add the response parameters `created_at`, `updated_at` to the interface `UpdateRouteTable`
  - Add the response parameters `created_at`, `updated_at` to the interface `AssociateRouteTable`
  - Add the response parameters `created_at`, `updated_at` to the interface `DisassociateRouteTable`

# 3.1.18 2022-12-26

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `group_id`, `name`, `bitrate`, `frame_rate`, `video_codec`, `format`, `hls_interval` changed to required of the interface `UpdateTranscodeTemplate`
  - The response parameter `bitrate`, `frame_rate`, `video_codec`, `format`, `hls_interval` changed to required of the interface `ListTranscodeTemplate`
  - The request parameter `name`, `bitrate`, `frame_rate`, `video_codec`, `format`, `hls_interval` changed to required of the interface `CreateTranscodeTemplate`
  - The request parameter `name`, `template_group_list` changed to required of the interface `UpdateTemplateGroupCollection`
  - The request parameter `name`, `template_group_list` changed to required of the interface `CreateTemplateGroupCollection`

# 3.1.17 2022-12-22

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowWorkflowExecutionForPage`:
    - Add the response parameter `created_by`
    - Remove the response parameter `create_by`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the interface `ModifyVolume`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `offset`, `limit` to the interface `ListAvailableFlavorInfos`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `vault_id` to the interface `CopyImageCrossRegion`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interface `SearchDevices`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `device_side` to the interface `CreateRule`
  - Add the response parameter `device_side` to the interface `ListRules`
  - Add the response parameter `device_side` to the interface `ShowRule`
  - Changes of the interface `UpdateRule`:
    - Add the request parameter `device_side`
    - Add the response parameter `device_side`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `sasl_enabled_mechanisms` to the interface `CreatePostPaidInstance`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `enterprise_project_id`, `enable_acl` to the interface `CreatePostPaidInstance`

# 3.1.16 2022-12-19

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateVault`:
    - Add the enum values `workspace` to the request parameter `object_type`
    - Add the enum values `workspace` to the response parameter `object_type`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ListVault`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowVault`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `UpdateVault`
  - Add the enum values `OS::Workspace::DesktopV2` to the response parameter `resource_type` to the interface `ShowBackup`
  - Changes of the interface `ListBackups`:
    - Add the enum values `OS::Workspace::DesktopV2` to the request parameter `resource_type`
    - Add the enum values `OS::Workspace::DesktopV2` to the response parameter `resource_type`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ListProtectable`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowProtectable`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowVaultResourceInstances`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `server_id` to the interface `ListServersDetails`

### HuaweiCloud SDK EIP

- _Features_
  - Support the interfaces `ShowResourcesJobDetail`, `ChangeBandwidthToPeriod`, `ChangePublicipToPeriod`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateFunction`:
    - Add the request parameters `depend_version_list`, `func_vpc`
    - Add the response parameter `depend_version_list`
  - Changes of the interface `UpdateFunctionCode`:
    - Add the request parameter `depend_version_list`
    - Add the response parameter `depend_version_list`
  - Add the response parameter `depend_version_list` to the interface `ShowFunctionCode`
  - Add the response parameter `depend_version_list` to the interface `ShowFunctionConfig`
  - Changes of the interface `ListReservedInstanceConfigs`:
    - Add the request parameters `marker`, `limit`
    - Add the response parameter `reserved_instances`
    - Remove the response parameter `reservedinstances`
  - Add the response parameter `depend_version_list` to the interface `ImportFunction`
  - Changes of the interface `ListFunctionReservedInstances`:
    - Add the request parameter `limit`
    - Remove the request parameter `maxitems`
  - Changes of the interface `ShowWorkflowExecutionForPage`:
    - Add the request parameters `offset`, `limit`, `start_time`, `end_time`
    - Remove the request parameter `CreateWorkflowRequestBody`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListConfigurationDatastores`:
    - Add the response parameter `datastore_name`
    - Remove the response parameter `datastore_type`
  - Remove the request parameters `instance`, `vcpus`, `ram` from the interface `ModifyEpsQuotas`
  - Remove the response parameters `instance`, `vcpus`, `ram`, `instance`, `vcpus`, `ram` from the interface `ListEpsQuotas`

# 3.1.15 2022-12-15

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateVault`:
    - Add the enum values `workspace` to the request parameter `object_type`
    - Add the enum values `workspace` to the response parameter `object_type`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ListVault`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowVault`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `UpdateVault`
  - Add the enum values `OS::Workspace::DesktopV2` to the response parameter `resource_type` to the interface `ShowBackup`
  - Changes of the interface `ListBackups`:
    - Add the enum values `OS::Workspace::DesktopV2` to the request parameter `resource_type`
    - Add the enum values `OS::Workspace::DesktopV2` to the response parameter `resource_type`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ListProtectable`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowProtectable`
  - Add the enum values `workspace` to the response parameter `object_type` to the interface `ShowVaultResourceInstances`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `server_id` to the interface `ListServersDetails`

### HuaweiCloud SDK EIP

- _Features_
  - Support the interfaces `ShowResourcesJobDetail`, `ChangeBandwidthToPeriod`, `ChangePublicipToPeriod`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateFunction`:
    - Add the request parameters `depend_version_list`, `func_vpc`
    - Add the response parameter `depend_version_list`
  - Changes of the interface `UpdateFunctionCode`:
    - Add the request parameter `depend_version_list`
    - Add the response parameter `depend_version_list`
  - Add the response parameter `depend_version_list` to the interface `ShowFunctionCode`
  - Add the response parameter `depend_version_list` to the interface `ShowFunctionConfig`
  - Changes of the interface `ListReservedInstanceConfigs`:
    - Add the request parameters `marker`, `limit`
    - Add the response parameter `reserved_instances`
    - Remove the response parameter `reservedinstances`
  - Add the response parameter `depend_version_list` to the interface `ImportFunction`
  - Changes of the interface `ListFunctionReservedInstances`:
    - Add the request parameter `limit`
    - Remove the request parameter `maxitems`
  - Changes of the interface `ShowWorkflowExecutionForPage`:
    - Add the request parameters `offset`, `limit`, `start_time`, `end_time`
    - Remove the request parameter `CreateWorkflowRequestBody`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListConfigurationDatastores`:
    - Add the response parameter `datastore_name`
    - Remove the response parameter `datastore_type`
  - Remove the request parameters `instance`, `vcpus`, `ram` from the interface `ModifyEpsQuotas`
  - Remove the response parameters `instance`, `vcpus`, `ram`, `instance`, `vcpus`, `ram` from the interface `ListEpsQuotas`

# 3.1.14 2022-12-08

### HuaweiCloud SDK AOS

- _Features_
  - Support the interfaces `GetExecutionPlan`, `DeleteExecutionPlan`, `DescribeExecutionPlan`, `GetStackMetadata`
- _Bug Fix_
  - None
- _Change_
  - Remove the request parameter `executor` from the interface `ListExecutionPlans`
  - Remove the request parameter `executor` from the interface `CreateExecutionPlan`
  - Remove the request parameter `executor` from the interface `ApplyExecutionPlan`
  - Changes of the interface `ListStackEvents`:
    - Remove the request parameters `limit`, `marker`, `executor`
    - Remove the response parameter `next_marker`
  - Remove the request parameter `executor` from the interface `ListStacks`
  - Remove the request parameter `executor` from the interface `CreateStack`
  - Remove the request parameter `executor` from the interface `GetStackTemplate`
  - Changes of the interface `ListStackResources`:
    - Remove the request parameter `executor`
    - Remove the response parameters `create_time`, `update_time`
  - Changes of the interface `ListStackOutputs`:
    - Remove the request parameters `executor`, `limit`, `marker`
    - Remove the response parameter `next_marker`
  - Remove the request parameter `executor` from the interface `DeployStack`
  - Remove the request parameter `executor` from the interface `DeleteStack`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `version` changed to not required of the interface `CreateAddonInstance`
  - The request parameter `version` changed to not required of the interface `UpdateAddonInstance`

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListIpsSwitchStatusUsingGet`:
    - Add the response parameters `id`, `virtual_patches_status`
    - Remove the response parameters `object_id`, `virtual_patches_stauts`
  - The request parameter `ips_type` changed to required of the interface `ChangeIpsSwitchUsingPost`
  - Remove the response parameters `fw_instance_id`, `resource_id`, `name`, `ha_type`, `charge_mode`, `service_type`, `engine_type`, `flavor`, `protect_objects`, `status`, `description`, `is_old_firewall_instance`, `support_ipv6`, `feature_toggle` from the interface `ListFirewallUsingGet`

### HuaweiCloud SDK EIP

- _Features_
  - Support the following interfaces：
    - `ListBandwidthPkg`
    - `CountPublicIp`
    - `ShowPublicIpType`
    - `CountPublicIpInstance`
    - `BatchCreatePublicips`
    - `BatchDeletePublicIp`
    - `BatchDisassociatePublicips`
    - `CountEipAvailableResources`
- _Bug Fix_
  - None
- _Change_
  - Remove the enum values `` from the request parameter `associate_instance_type` from the interface `AssociatePublicips`
  - Remove the enum values `` from the request parameter `associate_instance_type` from the interface `UpdateAssociatePublicip`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `dep_id` to the interface `CreateDependency`
  - Add the response parameter `dep_id` to the interface `CreateDependencyVersion`
  - Add the request parameters `enable_dynamic_memory`, `enable_auth_in_header` to the interface `UpdateFunctionConfig`
  - Changes of the interface `ShowWorkflowExecutionForPage`:
    - Add the request parameters `offset`, `limit`
    - Add the response parameters `total`, `size`, `executions`
    - Remove the request parameters `page`, `page_size`
    - Remove the response parameters `pager`, `hisRecords`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListAvailableFlavorInfos`:
    - Add the request parameter `x-auth-token`
    - Add the response parameter `list`
    - Remove the response parameter `optional_flavor_list`
    - The response parameter `instance_id`, `instance_name`, `vcpus`, `ram`, `spec_code`, `az_status`, `region_status`, `total_count` changed to required
  - Changes of the interface `ShowSlowLogDesensitization`:
    - Add the request parameter `x-auth-token`
    - The response parameter `desensitization_status` changed to required
  - The response parameter `type`, `key`, `values`, `total_count` changed to required of the interface `ListProjectTags`
  - The request parameter `instance`, `vcpus`, `ram` changed to required of the interface `ModifyEpsQuotas`
  - Changes of the interface `ListEpsQuotas`:
    - Remove the response parameters `enterprise_project_id`, `enterprise_project_name`, `quota`, `used`
    - The response parameter `total_count` changed to required

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `publicip_id` to the interface `ResizeInstance`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `DownloadAttachment`, `DeleteAttachment`, `ListStatusStatistic`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `CreateIssueV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `ListIssuesSfV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `ListIssuesV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `UpdateIssueV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `ShowIssueV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `ListChildIssuesV4`
  - Add the response parameters `user_id`, `user_num_id` to the interface `ListProjectIssuesRecordsV4`
  - Add the response parameters `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id`, `user_id`, `user_num_id` to the interface `CreateSystemIssueV4`

### HuaweiCloud SDK RocketMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `broker_num` changed to required of the interface `CreatePostPaidInstance`
  - Changes of the interface `UpdateInstance`:
    - Add the request parameter `enable_acl`
    - Remove the request parameter `retention_policy`
  - Add the response parameter `job_id` to the interface `BatchUpdateConsumerGroup`
  - Changes of the interface `ShowGroup`:
    - Add the response parameters `app_id`, `app_name`, `permissions`
    - Remove the response parameter `from_beginning`

### HuaweiCloud SDK TMS

- _Features_
  - Support the following interfaces：
    - `ListResource`
    - `CreateResourceTag`
    - `DeleteResourceTag`
    - `ListTagKeys`
    - `ListTagValues`
    - `ShowResourceTag`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.1.13 2022-12-01

### HuaweiCloud SDK CFW

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListIpsSwitchStatusUsingGet`:
    - Add the response parameter `data`
    - Remove the response parameters `object_id`, `basic_defense_status`, `virtual_patches_stauts`
  - Changes of the interface `ListEastWestFirewall`:
    - Add the response parameter `protect_infos`
    - Remove the response parameter `protected_infos`
  - The request parameter `fw_instance_id` changed to not required of the interface `ListAttackLogs`
  - Add the request parameter `type` to the interface `UpdateRuleAclUsingPut`
  - Add the request parameters `list_type`, `object_id` to the interface `UpdateBlackWhiteListUsingPut`
  - Changes of the interface `ListFirewallUsingGet`:
    - Add the response parameter `data`
    - Remove the response parameters `fw_instance_id`, `resource_id`, `name`, `ha_type`, `charge_mode`, `service_type`, `engine_type`, `flavor`, `protect_objects`, `status`, `description`, `is_old_firewall_instance`, `support_ipv6`, `feature_toggle`
  - Changes of the interface `ListServiceSetDetails`:
    - Add the response parameter `data`
    - Remove the response parameters `id`, `name`, `description`
  - Changes of the interface `CountEips`:
    - Add the response parameter `data`
    - Remove the response parameters `object_id`, `eip_total`, `eip_protected`
  - Changes of the interface `ListEipResources`:
    - Add the response parameter `data`
    - Remove the response parameters `id`, `public_ip`, `status`, `public_ipv6`, `enterprise_project_id`, `device_id`, `device_name`, `device_owner`, `associate_instance_type`
  - Add the request parameter `address_type` to the interface `UpdateAddressSetInfoUsingPut`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interface `AsyncInvokeReservedFunction`
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `http` to the response parameter `runtime` to the interface `ListDependencies`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ListDependencyVersion`
  - Changes of the interface `CreateFunction`:
    - Add the enum values `http` to the request parameter `runtime`
    - Add the enum values `http` to the response parameter `runtime`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ListFunctions`
  - Add the enum values `http` to the response parameter `runtime` to the interface `UpdateFunctionCode`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ShowFunctionCode`
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the enum values `http` to the request parameter `runtime`
    - Add the enum values `http` to the response parameter `runtime`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ShowFunctionConfig`
  - Add the enum values `http` to the response parameter `runtime` to the interface `UpdateFunctionMaxInstanceConfig`
  - Changes of the interface `ListReservedInstanceConfigs`:
    - Add the response parameters `reservedinstances`, `page_info`, `count`
    - Remove the response parameters `function_urn`, `qualifier_type`, `qualifier_name`, `min_count`, `idle_mode`, `tactics_config`
  - Add the enum values `http` to the response parameter `runtime` to the interface `CreateFunctionVersion`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ListFunctionVersions`
  - Add the enum values `http` to the response parameter `runtime` to the interface `ImportFunction`

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `RunQueryCustomTags`, `RunDeleteCustomTags`, `RunImageMediaTaggingDet`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `use_default_tags` to the interface `RunImageMediaTagging`

# 3.1.12 2022-11-30

### HuaweiCloud SDK DDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `string` -> `int32` of the request parameter `num` of the interface `AddReadonlyNode`

### HuaweiCloud SDK EIP

- _Features_
  - Support the interfaces `DisassociatePublicips`, `AssociatePublicips`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `metric_type` to the interface `ShowTenantMetric`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the following interfaces：
    - `ListAvailableFlavorInfos`
    - `CheckWeekPassword`
    - `ModifyPort`
    - `UpdateClientNetwork`
    - `DeleteEnlargeFailNode`
    - `ShowIpNumRequirement`
    - `ShowAutoEnlargePolicy`
    - `ShowSlowLogDesensitization`
    - `SwitchSlowlogDesensitization`
    - `ShowErrorLog`
    - `CopyConfiguration`
    - `CompareConfiguration`
    - `ListConfigurationDatastores`
    - `ShowAllInstancesBackups`
    - `CreateBack`
    - `ShowRecyclePolicy`
    - `SetRecyclePolicy`
    - `ListRecycleInstances`
    - `ShowPauseResumeStutus`
    - `PauseResumeDataSynchronization`
    - `ListProjectTags`
    - `ListEpsQuotas`
    - `ModifyEpsQuotas`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `public_ip`, `public_ip_id` changed to not required of the interface `ModifyPublicIp`
  - Add the request parameter `SwitchToMasterDisasterRecoveryBody` to the interface `SwitchToMaster`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `chinese_8k_general` to the request parameter `property` to the interface `PushTranscriberJobs`
  - Add the enum values `chinese_huaxiaoru_common`, `chinese_huaxiaohan_common`, `chinese_huaxiaoning_common`, `chinese_huaxiaozhen_common`, `english_alvin_common`, `english_amy_common` to the request parameter `property` to the interface `RunTts`

# 3.1.11 2022-11-24

### HuaweiCloud SDK AOS

- _Features_
  - Support the interfaces `ListStackEvents`, `ListStackResources`, `DeleteStack`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `children` to the interface `ShowBackup`
  - Add the response parameter `children` to the interface `ListBackups`

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `configurationsOverride` to the interface `CreateCluster`
  - Add the response parameter `configurationsOverride` to the interface `ListClusters`
  - Changes of the interface `UpdateCluster`:
    - Add the request parameters `eniNetwork`, `hostNetwork`
    - Add the response parameter `configurationsOverride`
  - Changes of the interface `DeleteCluster`:
    - Add the request parameter `delete_sfs30`
    - Add the response parameter `configurationsOverride`
  - Add the response parameter `configurationsOverride` to the interface `ShowCluster`
  - Add the request parameter `initializedConditions` to the interface `CreateNode`
  - Add the response parameter `initializedConditions` to the interface `ListNodes`
  - Add the response parameter `initializedConditions` to the interface `UpdateNode`
  - Add the response parameter `initializedConditions` to the interface `DeleteNode`
  - Add the response parameter `initializedConditions` to the interface `ShowNode`
  - Add the request parameter `initializedConditions` to the interface `AddNode`
  - Add the request parameter `initializedConditions` to the interface `ResetNode`
  - Add the request parameters `customSecurityGroups`, `initializedConditions` to the interface `CreateNodePool`
  - Add the response parameters `customSecurityGroups`, `initializedConditions` to the interface `ListNodePools`
  - Changes of the interface `UpdateNodePool`:
    - Add the request parameter `initializedConditions`
    - Add the response parameters `customSecurityGroups`, `initializedConditions`
  - Add the response parameters `customSecurityGroups`, `initializedConditions` to the interface `DeleteNodePool`
  - Add the response parameters `customSecurityGroups`, `initializedConditions` to the interface `ShowNodePool`

### HuaweiCloud SDK CES

- _新增特性_
  - 支持以下接口：
    - `ListAlarmTemplates`
    - `CreateAlarmTemplate`
    - `BatchDeleteAlarmTemplates`
    - `ShowAlarmTemplate`
    - `UpdateAlarmTemplate`
    - `ListAlarmTemplateAssociationAlarms`
    - `ListResourceGroups`
    - `CreateResourceGroup`
    - `ShowResourceGroup`
    - `UpdateResourceGroup`
    - `ListResourceGroupsServicesResources`
    - `BatchDeleteResourceGroups`
    - `BatchCreateResources`
    - `BatchDeleteResources`
- _解决问题_
  - 无
- _特性变更_
  - 无

### HuaweiCloud SDK DDS

- _Features_
  - Support the following interfaces：
    - `ListAppliedInstances`
    - `ShowConfigurationAppliedHistory`
    - `ShowConfigurationModifyHistory`
    - `CompareConfiguration`
    - `CopyConfiguration`
    - `ResetConfiguration`
    - `ListTasks`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `is_auto_pay` to the interface `AddReadonlyNode`

### HuaweiCloud SDK DNS

- _Features_
  - Support the following interfaces：
    - `SetPrivateZoneProxyPattern`
    - `AssociateHealthCheck`
    - `DisassociateHealthCheck`
    - `CreateRetrieval`
    - `ShowRetrieval`
    - `CreateRetrievalVerification`
    - `ShowRetrievalVerification`
    - `CreateEndpoint`
    - `ShowEndpoint`
    - `ListEndpoints`
    - `UpdateEndpoint`
    - `DeleteEndpoint`
    - `AssociateEndpointIpaddress`
    - `ListEndpointIpaddresses`
    - `DisassociateEndpointIpaddress`
    - `ListEndpointVpcs`
    - `CreateResolveRule`
    - `ShowResoleRule`
    - `ListResoleRules`
    - `UpdateResolveRule`
    - `DeleteResolveRule`
    - `CreateLineGroup`
    - `ListLineGroups`
    - `ShowLineGroup`
    - `UpdateLineGroups`
    - `DeleteLineGroup`
    - `BatchDeleteZones`
    - `BatchDeletePtrRecords`
    - `BatchSetZonesStatus`
    - `BatchSetRecordSetsStatus`
    - `BatchDeleteRecordSets`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the following interfaces：
    - `CreateDependencyVersion`
    - `ListDependencyVersion`
    - `ShowDependencyVersion`
    - `DeleteDependencyVersion`
    - `ListReservedInstanceConfigs`
    - `ListFunctionReservedInstances`
    - `ListFunctionAsMetric`
- _Bug Fix_
  - None
- _Change_
  - Remove the interface `AsyncInvokeReservedFunction`
  - Add the request parameter `custom_image` to the interface `UpdateFunctionConfig`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the following interfaces：
    - `ResizeColdVolume`
    - `CreateColdVolume`
    - `ModifyPublicIp`
    - `SwitchSsl`
    - `SetAutoEnlargePolicy`
    - `RestartInstance`
    - `ShowApplicableInstances`
    - `ShowModifyHistory`
    - `ShowApplyHistory`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `restore_info`, `port` to the interface `CreateInstance`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `test_interval` to the interface `RecognizeHealthCode`

# 3.1.10 2022-11-17

### HuaweiCloud SDK AOS

- _Features_
  - Support the `Application Orchestration Service`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `id` changed to required of the interface `DeleteServerNics`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `integer` -> `int32` of the request parameter `new_capacity` of the interface `ResizeInstance`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `string` -> `enum` of the request parameter `monitorMetrics` of the interface `RegisterServerMonitor`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `VPN` to the request parameter `associate_instance_type` to the interface `DisassociatePublicips`
  - Add the enum values `VPN` to the request parameter `associate_instance_type` to the interface `AssociatePublicips`

### HuaweiCloud SDK EPS

- _Features_
  - Support the interface `ListProviders`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the interfaces `ShowInstanceRole`, `SwitchToMaster`, `SwitchToSlave`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `ttl` to the interface `CreateMessage`
  - Add the request parameters `Sp-Auth-Token`, `Stage-Auth-Token` to the interface `ListCertificates`
  - Changes of the interface `AddCertificate`:
    - Add the request parameters `Sp-Auth-Token`, `Stage-Auth-Token`, `addCertificateRequestBody`
    - Remove the request parameter `AddCertificateRequestBody`
  - Add the request parameters `Sp-Auth-Token`, `Stage-Auth-Token` to the interface `DeleteCertificate`
  - Changes of the interface `CheckCertificate`:
    - Add the request parameters `Sp-Auth-Token`, `Stage-Auth-Token`, `checkCertificateRequestBody`
    - Remove the request parameter `CheckCertificateRequestBody`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `new_password` changed to required of the interface `ResetPassword`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeGeneralTable`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeVatInvoice`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeInvoiceVerification`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeGeneralText`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeWebImage`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeHealthCode`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeQuotaInvoice`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeIdCard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeHandwriting`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeVehicleLicense`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeTransportationLicense`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeTaxiInvoice`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeAutoClassification`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeTollInvoice`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeMvsInvoice`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeLicensePlate`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeFlightItinerary`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeBusinessLicense`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeDriverLicense`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeBusinessCard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeTrainTicket`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeVin`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizePassport`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeBankcard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeInsurancePolicy`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeFinancialStatement`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeQualificationCertificate`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeThailandIdcard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeMyanmarIdcard`
  - Changes of the interface `RecognizeMyanmarDriverLicense`:
    - Add the request parameter `Enterprise-Project-Id`
    - Add the response parameters `birth`, `birth`
    - Remove the response parameters `Birth`, `Birth`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeChileIdCard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeThailandLicensePlate`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeWaybillElectronic`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizePcrTestRecord`
  - Changes of the interface `RecognizeIdDocument`:
    - Add the request parameter `Enterprise-Project-Id`
    - Modify the type `object` -> `object` of the response parameter `result`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeHkIdCard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeCambodianIdCard`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeExitEntryPermit`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeMainlandTravelPermit`
  - Add the request parameter `Enterprise-Project-Id` to the interface `RecognizeMacaoIdCard`

### HuaweiCloud SDK TMS

- _Features_
  - Support the interface `ListProviders`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateSubnet`:
    - Add the enum values `addresstime` to the request parameter `opt_name`
    - Add the enum values `addresstime` to the response parameter `opt_name`
  - Add the enum values `addresstime` to the response parameter `opt_name` to the interface `ListSubnets`
  - Add the enum values `addresstime` to the response parameter `opt_name` to the interface `ShowSubnet`
  - Add the enum values `addresstime` to the request parameter `opt_name` to the interface `UpdateSubnet`

# 3.1.9 2022-11-14

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The response parameter `job_id` changed to required of the interface `DeleteServerNics`
  - Changes of the interface `UpdateBaremetalServerInterfaceAttachments`:
    - Modify the type `string` -> `boolean` of the request parameter `delete_on_termination`
    - The request parameter `delete_on_termination` changed to required
  - Add the response parameter `remote_console` to the interface `ShowServerRemoteConsole`

### HuaweiCloud SDK DDS

- _Features_
  - Support the following interfaces：
    - `ShowSlowlogDesensitizationSwitch`
    - `ListRecycleInstances`
    - `CheckWeakPassword`
    - `ShowUpgradeDuration`
    - `ShowDiskUsage`
    - `ListSslCertDownloadAddress`
    - `DeleteAuditLog`
    - `ShowRecyclePolicy`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `X-Language` to the interface `SwitchSlowlogDesensitization`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interface `ShowWorkflowExecutionForPage`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `enable_stream_response` to the interface `ListWorkflow`
  - Add the response parameter `enable_stream_response` to the interface `UpdateWorkFlow`

### HuaweiCloud SDK VPCEP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `string` -> `array` of the response parameter `Action` of the interface `ListEndpoints`
  - Modify the type `string` -> `array` of the response parameter `Action` of the interface `DeleteEndpointPolicy`
  - Changes of the interface `UpdateEndpointPolicy`:
    - Modify the type `string` -> `array` of the request parameter `Action`
    - Modify the type `string` -> `array` of the response parameter `Action`

# 3.1.8 2022-11-03

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `destination_type` changed to not required of the interface `NovaCreateServers`

### HuaweiCloud SDK EPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `region_id` to the interface `MigrateResource`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeGeneralText`:
    - Add the request parameter `character_mode`
    - Add the response parameters `confidence`, `char_list`
  - Changes of the interface `RecognizeThailandIdcard`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`

# 3.1.7 2022-11-02

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowUrlTaskInfo`:
    - Modify the type `int32` -> `int64` of the response parameter `modify_time`
    - Modify the type `int32` -> `int64` of the response parameter `create_time`

### HuaweiCloud SDK ECS

- _Features_
  - Support the interfaces `UpdateServerBlockDevice`, `RegisterServerMonitor`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `sichuan_8k_common` to the request parameter `property` to the interface `PushTranscriberJobs`
  - Add the enum values `chinese_huaxiaolong_common`, `chinese_huaxiaorui_common` to the request parameter `property` to the interface `RunTts`

# 3.1.6 2022-10-27

### HuaweiCloud SDK BMS

- _Features_
  - Support the interfaces `DeleteServerNics`, `UpdateBaremetalServerInterfaceAttachments`, `AddServerNics`, `ShowServerRemoteConsole`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int32` -> `int64` of the response parameter `id` of the interface `ShowUrlTaskInfo`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowInstance`:
    - Modify the type `string` -> `int64` of the response parameter `begin_time`
    - Modify the type `string` -> `int64` of the response parameter `end_time`
    - Modify the type `string` -> `int64` of the response parameter `current_time`
    - Modify the type `string` -> `int64` of the response parameter `next_expand_time`
    - Modify the type `string` -> `int64` of the response parameter `expand_effect_time`
    - Modify the type `string` -> `int64` of the response parameter `expand_interval_time`
  - Modify the type `int32` -> `integer` of the request parameter `new_capacity` of the interface `ResizeInstance`
  - Add the response parameters `target_instance_address`, `migration_method`, `task_name`, `target_instance_id`, `source_instance_name`, `target_instance_name`, `migrate_type`, `created_at`, `source_instance_id`, `task_id`, `data_source`, `status` to the interface `ListMigrationTask`
  - Changes of the interface `ListRedislog`:
    - Add the response parameter `backup_id`
    - Remove the response parameter `backupId`
  - Add the response parameter `enable_show` to the interface `ListBackgroundTask`

### HuaweiCloud SDK DDS

- _Features_
  - Support the following interfaces：
    - `AddReadonlyNode`
    - `UpgradeDatabaseVersion`
    - `ShowSecondLevelMonitoringStatus`
    - `SwitchSecondLevelMonitoring`
    - `ChangeOpsWindow`
    - `SetRecyclePolicy`
    - `ExpandReplicasetNode`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `node_type` to the interface `ListConfigurations`
  - Add the response parameter `patch_available` to the interface `ListInstances`
  - Add the request parameter `node_ids` to the interface `ResizeInstanceVolume`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `X-Client-Token`, `batch_create_in_multi_az` to the interface `CreateServers`
  - Add the request parameter `X-Client-Token` to the interface `CreatePostPaidServers`

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `tls-1-1`, `tls-1-2`, `tls-1-2-strict`, Remove the enum values ` tls-1-1`, ` tls-1-2`, ` tls-1-2-strict` from the request parameter `tls_ciphers_policy` to the interface `CreateListener`
  - Remove the request parameter `cascade` from the interface `DeleteListener`
  - Remove the request parameter `cascade` from the interface `DeleteLoadbalancer`
  - Changes of the interface `ListApiVersions`:
    - Add the response parameter `versions`
    - Remove the response parameters `id`, `status`
  - Remove the request parameter `global_eip_ids` from the interface `CreateLoadBalancer`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the interfaces `ShowRestorableList`, `ListRestoreTime`, `DeleteBackup`, `RestoreExistingInstance`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `market` to the request parameter `__imagetype` to the interface `ListTags`
  - Changes of the interface `GlanceListImages`:
    - Add the enum values `market` to the request parameter `__imagetype`
    - Add the enum values `market` to the response parameter `__imagetype`
  - Add the enum values `market` to the response parameter `__imagetype` to the interface `GlanceShowImage`
  - Add the enum values `market` to the response parameter `__imagetype` to the interface `GlanceUpdateImage`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `properties` to the interface `CreateMessage`
  - Add the response parameter `properties` to the interface `ListDeviceMessages`
  - Add the response parameter `properties` to the interface `ShowDeviceMessage`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreatePostPaidInstance`:
    - Add the request parameters `disk_encrypted_enable`, `disk_encrypted_key`
    - Add the enum values `2.7` to the request parameter `engine_version`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `float` -> `integer` of the request parameter `frame_interval` of the interface `RunCreateVideoModerationJob`
  - Modify the type `float` -> `integer` of the response parameters `start_time`, `end_time` of the interface `RunQueryAudioModerationJob`
  - Changes of the interface `RunQueryVideoModerationJob`:
    - Modify the type `integer` -> `float` of the response parameter `time`
    - Modify the type `integer` -> `float` of the response parameters `start_time`, `end_time`

# 3.1.5 2022-09-28

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `domain_id` to the interface `ListDomains`
  - Changes of the interface `CreateDomain`:
    - Add the request parameter `domain_id`
    - Add the response parameter `domain_id`
  - Add the response parameter `domain_id` to the interface `ShowDomainDetail`
  - Add the response parameter `domain_id` to the interface `DeleteDomain`
  - Add the response parameter `domain_id` to the interface `EnableDomain`
  - Add the response parameter `domain_id` to the interface `DisableDomain`
  - Changes of the interface `UpdateDomainOrigin`:
    - Add the request parameter `domain_id`
    - Add the response parameter `domain_id`
  - Add the response parameters `origin_range_status`, `user_agent_filter`, `origin_request_url_rewrite`, `error_code_redirect_rules` to the interface `ShowDomainFullConfig`
  - Add the request parameters `origin_range_status`, `user_agent_filter`, `origin_request_url_rewrite`, `error_code_redirect_rules` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowInstance`:
    - Modify the type `string` -> `int64` of the response parameter `begin_time`
    - Modify the type `string` -> `int64` of the response parameter `end_time`
    - Modify the type `string` -> `int64` of the response parameter `current_time`
    - Modify the type `string` -> `int64` of the response parameter `next_expand_time`
    - Modify the type `string` -> `int64` of the response parameter `expand_effect_time`
    - Modify the type `string` -> `int64` of the response parameter `expand_interval_time`
  - Modify the type `int32` -> `integer` of the request parameter `new_capacity` of the interface `ResizeInstance`
  - Add the response parameters `target_instance_address`, `migration_method`, `task_name`, `target_instance_id`, `source_instance_name`, `target_instance_name`, `migrate_type`, `created_at`, `source_instance_id`, `task_id`, `data_source`, `status` to the interface `ListMigrationTask`
  - Changes of the interface `ListRedislog`:
    - Add the response parameter `backup_id`
    - Remove the response parameter `backupId`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `region` changed to required of the interface `ListFlavors`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `type`, `idcard_number`, `phone_number`, `province`, `city`, `vaccination_status`, `pcr_test_result`, `pcr_test_organization`, `pcr_test_time`, `pcr_sampling_time`, `reached_city` to the interface `RecognizeHealthCode`

### HuaweiCloud SDK VPCEP

- _Features_
  - Support the following interfaces：
    - `UpdateEndpointServiceName`
    - `UpdateEndpointConnectionsDesc`
    - `BatchAddEndpointServicePermissions`
    - `BatchRemoveEndpointServicePermissions`
    - `UpdateEndpointServicePermissionDesc`
    - `UpdateEndpointPolicy`
    - `DeleteEndpointPolicy`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateEndpointService`:
    - Add the request parameter `description`
    - Add the response parameter `description`
  - Changes of the interface `ListEndpointService`:
    - Add the request parameter `public_border_group`
    - Add the response parameters `description`, `public_border_group`
    - Modify the type `string` -> `enum` of the response parameter `service_type`
    - Modify the type `enum` -> `string` of the response parameter `server_type`
  - Changes of the interface `UpdateEndpointService`:
    - Add the request parameter `description`
    - Add the response parameter `description`
  - Changes of the interface `ListServiceDetails`:
    - Add the response parameter `description`
    - Modify the type `string` -> `enum` of the response parameter `service_type`
  - Remove the response parameters `id`, `marker_id`, `created_at`, `updated_at`, `domain_id`, `status` from the interface `ListServiceConnections`
  - Add the response parameter `description` to the interface `AcceptOrRejectEndpoint`
  - Remove the response parameters `id`, `permission`, `created_at` from the interface `ListServicePermissionsDetails`
  - Changes of the interface `CreateEndpoint`:
    - Add the request parameter `description`
    - Add the response parameters `specification_name`, `description`, `policy_statement`, `enable_status`
  - Changes of the interface `ListEndpoints`:
    - Add the request parameter `public_border_group`
    - Add the response parameters `description`, `policy_statement`, `endpoint_pool_id`, `public_border_group`
  - Add the response parameters `description`, `policy_statement` to the interface `ListEndpointInfoDetails`
  - Remove the response parameters `status`, `id`, `updated`, `version`, `min_version`, `links` from the interface `ListVersionDetails`
  - Remove the response parameters `status`, `id`, `updated`, `version`, `min_version`, `links` from the interface `ListSpecifiedVersionDetails`
  - Changes of the interface `ListResourceInstances`:
    - Add the request parameters `sys_tags`, `without_any_tag`
    - Remove the request parameters `key`, `value`, `key`, `value`, `key`, `value`, `key`, `value`

# 3.1.4 2022-09-26

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `version`, `last_modified` to the interface `CreateDependency`
  - Add the response parameters `version`, `last_modified` to the interface `ListDependencies`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `disk_encrypted_key`, `public_management_connect_address`, `subnet_cidr`, `subnet_name`, `enable_acl` to the interface `ListInstances`
  - Add the response parameters `disk_encrypted_key`, `public_management_connect_address`, `subnet_cidr`, `subnet_name`, `enable_acl` to the interface `ShowInstance`
  - Add the request parameters `oper_type`, `new_broker_num`, `new_product_id` to the interface `ResizeInstance`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - Fix the problem that the response parameters' type of the interface `CheckImageModeration` is incorrect
- _Change_
  - None

# 3.1.3 2022-09-22

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `event_type` to the interface `CreateEvents`
  - Add the response parameter `event_type` to the interface `ListEventDetail`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `port_id` to the interface `CreatePublicip`
  - Add the request parameter `port_id` to the interface `CreatePrePaidPublicip`

### HuaweiCloud SDK IoTDA

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `error_info` to the interface `ListDeviceMessages`
  - Add the response parameter `error_info` to the interface `ShowDeviceMessage`

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interface `CheckImageModeration`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `url`, `categories` changed to required of the interface `RunCreateAudioModerationJob`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeIdCard`:
    - Add the request parameter `detect_copy`
    - Add the response parameter `detect_copy_result`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `DownloadImageFile`, `ListScrumProjectStatuses`, `UploadAttachments`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RabbitMQ

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `rabbitmq`, Remove the enum values `true`, `false` from the request parameter `all_failure` to the interface `BatchRestartOrDeleteInstances`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `pack_type`, `pack_type` to the interface `PublishAssets`
  - Add the response parameters `pack_type`, `pack_type` to the interface `UnpublishAssets`
  - Add the response parameters `pack_type`, `pack_type` to the interface `ShowAssetMeta`
  - Add the response parameters `pack_type`, `pack_type` to the interface `ShowAssetDetail`
  - Add the response parameters `pack_type`, `pack_type` to the interface `ShowTakeOverTaskDetails`
  - Add the response parameters `pack_type`, `pack_type` to the interface `ShowTakeOverAssetDetails`

# 3.1.2 2022-09-15

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces `ShowTags`, `CreateTags`, `BatchDeleteTags`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowUrlTaskInfo`:
    - Add the response parameter `result`
    - Remove the response parameter `results`
  - Add the response parameter `error_code_cache` to the interface `ShowDomainFullConfig`
  - Add the request parameter `error_code_cache` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `enterprise_project_name`, `update_at`, `product_type`, `storage_type`, `launched_at`, `cache_mode`, `support_slow_log_flag`, `db_number`, `replica_count`, `sharding_count`, `bandwidth_info` to the interface `ShowInstance`
  - Add the response parameter `backupId` to the interface `ListRedislog`
  - Add the response parameter `instance_id` to the interface `ShowIpWhitelist`
  - Add the request parameter `instance_id` to the interface `UpdateIpWhitelist`
  - Add the response parameters `updated_at`, `created_at`, `status` to the interface `ListBackgroundTask`

### HuaweiCloud SDK EVS

- _Features_
  - Support the following interfaces：
    - `ShowVersion`
    - `ListVersions`
    - `CinderShowVolumeTransfer`
    - `CinderDeleteVolumeTransfer`
    - `CinderListVolumeTransfers`
    - `CinderCreateVolumeTransfer`
    - `CinderAcceptVolumeTransfer`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interfaces `RunCreateVideoModerationJob`, `RunQueryVideoModerationJob`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `url` changed to not required of the interface `RunCreateAudioModerationJob`

# 3.1.1 2022-09-08

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces `ShowTags`, `CreateTags`, `BatchDeleteTags`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowUrlTaskInfo`:
    - Add the response parameter `result`
    - Remove the response parameter `results`
  - Add the response parameter `error_code_cache` to the interface `ShowDomainFullConfig`
  - Add the request parameter `error_code_cache` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `enterprise_project_name`, `update_at`, `product_type`, `storage_type`, `launched_at`, `cache_mode`, `support_slow_log_flag`, `db_number`, `replica_count`, `sharding_count`, `bandwidth_info` to the interface `ShowInstance`
  - Add the response parameter `backupId` to the interface `ListRedislog`
  - Add the response parameter `instance_id` to the interface `ShowIpWhitelist`
  - Add the request parameter `instance_id` to the interface `UpdateIpWhitelist`
  - Add the response parameters `updated_at`, `created_at`, `status` to the interface `ListBackgroundTask`

### HuaweiCloud SDK EVS

- _Features_
  - Support the following interfaces：
    - `ShowVersion`
    - `ListVersions`
    - `CinderShowVolumeTransfer`
    - `CinderDeleteVolumeTransfer`
    - `CinderListVolumeTransfers`
    - `CinderCreateVolumeTransfer`
    - `CinderAcceptVolumeTransfer`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interfaces `RunCreateVideoModerationJob`, `RunQueryVideoModerationJob`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `url` changed to not required of the interface `RunCreateAudioModerationJob`

# 3.0.104 2022-09-01

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameters `version`, `last_modified` from the interface `CreateDependency`
  - Remove the response parameters `version`, `last_modified` from the interface `ListDependencies`

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `UpdateDomainProtectPolicy`:
    - Add the request parameters `allow_user`, `mobile`, `admin_check`, `email`, `scene`
    - Remove the response parameter `operation_protection`
  - Remove the response parameter `operation_protection` from the interface `ShowDomainProtectPolicy`
  - The request parameter `maximum_consecutive_identical_chars`, `minimum_password_age`, `minimum_password_length`, `number_of_recent_passwords_disallowed`, `password_not_username_or_invert`, `password_validity_period`, `password_char_combination` changed to not required of the interface `UpdateDomainPasswordPolicy`
  - The request parameter `account_validity_period`, `custom_info_for_login`, `lockout_duration`, `login_failed_times`, `period_with_login_failures`, `session_timeout`, `show_recent_login_info` changed to not required of the interface `UpdateDomainLoginPolicy`
  - Add the enum values `mapping` to the request parameter `type` to the interface `ShowDomainQuota`

# 3.0.103 2022-08-29

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `batch_create_in_multi_az` to the interface `CreatePostPaidServers`

### HuaweiCloud SDK IMS

- _Features_
  - Support the interface `ShowJobProgress`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.102 2022-08-25

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the following interfaces：
    - `ListMasterSlavePools`
    - `CreateMasterSlavePool`
    - `ShowMasterSlavePool`
    - `DeleteMasterSlavePool`
  - Add the response parameter `waf_failure_action` to the interface `ListLoadBalancers`
  - Add the request parameter `waf_failure_action` to the interface `CreateLoadBalancer`
  - Add the response parameter `waf_failure_action` to the interface `ShowLoadBalancer`
  - Changes of the interface `UpdateLoadBalancer`:
    - Add the request parameter `waf_failure_action`
    - Add the response parameter `waf_failure_action`
    - Remove the request parameter `cloud_service_console_url`
  - Add the response parameters `enc_certificate`, `enc_private_key` to the interface `ListCertificates`
  - Add the request parameters `enc_certificate`, `enc_private_key` to the interface `CreateCertificate`
  - Add the response parameters `enc_certificate`, `enc_private_key` to the interface `ShowCertificate`
  - Changes of the interface `UpdateCertificate`:
    - Add the request parameters `enc_certificate`, `enc_private_key`
    - Add the response parameters `enc_certificate`, `enc_private_key`
  - Add the response parameter `sni_match_algo` to the interface `ListListeners`
  - Add the request parameter `sni_match_algo` to the interface `CreateListener`
  - Add the response parameter `sni_match_algo` to the interface `ShowListener`
  - Changes of the interface `UpdateListener`:
    - Add the request parameter `sni_match_algo`
    - Add the response parameter `sni_match_algo`
  - Add the request parameter `instance_id` to the interface `ListMembers`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeWebImage`:
    - Add the request parameter `detect_font`
    - Add the response parameters `font_list`, `font_scores`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int32` -> `int64` of the request parameter `size` of the interface `CheckMd5Duplication`

# 3.0.101 2022-08-18

### HuaweiCloud SDK ECS

- _Features_
  - Support the interface `ListServersByTag`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `destination_type` changed to required of the interface `NovaCreateServers`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateFunction`:
    - Add the response parameters `enable_dynamic_memory`, `is_stateful_function`, `enable_auth_in_header`, `custom_image`
    - The request parameter `file`, `link` changed to required
    - Modify the type `int32` -> `string` of the response parameter `user_id`
    - Modify the type `int32` -> `string` of the response parameter `user_group_id`
    - The response parameter `concurrent_num` changed to required
    - The response parameter `mount_share_path` changed to not required
  - Changes of the interface `ListFunctions`:
    - Add the response parameter `fail_count`
    - Remove the request parameter `X-Auth-Token`
    - The response parameter `concurrent_num` changed to required
  - Changes of the interface `ShowFunctionCode`:
    - Remove the response parameter `id`
    - The response parameter `file`, `link`, `concurrent_num` changed to required
  - Changes of the interface `UpdateFunctionCode`:
    - Remove the response parameter `id`
    - The request parameter `file`, `link` changed to required
    - The response parameter `file`, `link`, `concurrent_num` changed to required
  - Changes of the interface `ShowFunctionConfig`:
    - Add the response parameters `is_stateful_function`, `enable_auth_in_header`, `custom_image`
    - Remove the response parameter `id`
    - Modify the type `int32` -> `string` of the response parameter `user_id`
    - Modify the type `int32` -> `string` of the response parameter `user_group_id`
    - The response parameter `concurrent_num` changed to required
    - The response parameter `mount_share_path` changed to not required
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the response parameters `enable_auth_in_header`, `custom_image`
    - Remove the request parameter `X-Auth-Token`
    - Remove the response parameter `id`
    - Modify the type `int32` -> `string` of the request parameter `user_id`
    - Modify the type `int32` -> `string` of the request parameter `user_group_id`
    - The request parameter `concurrent_num` changed to required
    - The request parameter `mount_share_path` changed to not required
    - Modify the type `int32` -> `string` of the response parameter `user_id`
    - Modify the type `int32` -> `string` of the response parameter `user_group_id`
    - The response parameter `concurrent_num` changed to required
    - The response parameter `mount_share_path` changed to not required
  - Changes of the interface `UpdateFunctionMaxInstanceConfig`:
    - Remove the response parameter `id`
    - Modify the type `int32` -> `string` of the response parameter `user_id`
    - Modify the type `int32` -> `string` of the response parameter `user_group_id`
    - The response parameter `concurrent_num` changed to required
    - The response parameter `mount_share_path` changed to not required
  - Changes of the interface `CreateFunctionVersion`:
    - Remove the response parameter `id`
    - Modify the type `int32` -> `string` of the response parameter `user_id`
    - Modify the type `int32` -> `string` of the response parameter `user_group_id`
    - The response parameter `concurrent_num` changed to required
    - The response parameter `mount_share_path` changed to not required
  - Changes of the interface `ListFunctionVersions`:
    - Add the response parameters `is_stateful_function`, `enable_auth_in_header`, `custom_image`, `reserved_instance_idle_mode`
    - Remove the response parameters `log_group_id`, `log_stream_id`
    - The response parameter `concurrent_num` changed to required
  - Add the enum values `SMN`, `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the request parameter `trigger_type_code` to the interface `CreateFunctionTrigger`
  - Changes of the interface `ListFunctionTriggers`:
    - Add the enum values `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the response parameter `trigger_type_code`
    - Add the enum values `DISABLE`, Remove the enum values `DISABLED` from the response parameter `trigger_status`
  - Add the enum values `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the request parameter `trigger_type_code` to the interface `DeleteFunctionTrigger`
  - Changes of the interface `ShowFunctionTrigger`:
    - Add the enum values `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the request parameter `trigger_type_code`
    - Add the enum values `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the response parameter `trigger_type_code`
    - Add the enum values `DISABLE`, Remove the enum values `DISABLED` from the response parameter `trigger_status`
  - Changes of the interface `UpdateTrigger`:
    - Add the enum values `DISABLE`, Remove the enum values `DISABLED` from the request parameter `trigger_status`
    - Add the enum values `RABBITMQ`, `DEDICATEDGATEWAY`, `OPENSOURCEKAFKA`, `APIC`, `GAUSSMONGO`, `EVENTGRID` to the request parameter `trigger_type_code`
    - The request parameter `trigger_status` changed to not required
  - Modify the type `float` -> `int32` of the response parameter `value` of the interface `ListStatistics`
  - Changes of the interface `UpdateFunctionReservedInstancesCount`:
    - Add the request parameter `UpdateFunctionReservedInstancesCountRequestBody`
    - Add the response parameters `idle_mode`, `tactics_config`
    - Remove the request parameter `UpdateFunctionReservedInstancesRequestBody`
  - Changes of the interface `CreateDependency`:
    - Add the response parameters `version`, `last_modified`
    - Modify the type `enum` -> `string` of the response parameter `runtime`
  - Changes of the interface `ListDependencies`:
    - Add the request parameters `maxitems`, `ispublic`
    - Add the response parameters `version`, `last_modified`
    - Modify the type `int32` -> `int64` of the response parameter `count`
  - Changes of the interface `ShowDependcy`:
    - Add the response parameters `version`, `last_modified`
    - Modify the type `enum` -> `string` of the response parameter `runtime`
  - Changes of the interface `UpdateDependcy`:
    - Add the request parameter `UpdateDependcyRequestBody`
    - Remove the request parameter `UpdateDependencyRequestBody`
    - Modify the type `enum` -> `string` of the response parameter `runtime`
  - Remove the response parameters `content`, `last_modified` from the interface `CreateEvent`
  - Remove the response parameters `content`, `last_modified` from the interface `UpdateEvent`
  - Changes of the interface `ImportFunction`:
    - Add the request parameter `package`
    - Remove the request parameter `X-Auth-Token`
    - The response parameter `concurrent_num` changed to required
  - Add the request parameter `X-Auth-Token` to the interface `EnableLtsLogs`
  - Add the response parameter `group_name` to the interface `ShowLtsLogDetails`
  - The request parameter `request_id` changed to required of the interface `CancelAsyncInvocation`
  - Changes of the interface `CreateWorkflow`:
    - Add the request parameter `duration`
    - Add the enum values `SMN`, `APIG`, `APIG_DE` to the request parameter `trigger_type`
  - Changes of the interface `ListWorkflow`:
    - Add the request parameters `enterprise_project`, `mode`
    - Remove the response parameters `id`, `workflow_urn`, `name`, `description`, `created_time`, `updated_time`, `created_by`
  - Add the request parameter `X-WorkflowRun-MergeFnParameters` to the interface `StartWorkflowExecution`
  - Remove the response parameters `workflow_id`, `workflow_urn`, `execution_id`, `status`, `begin_time`, `end_time`, `last_update_time`, `created_by` from the interface `ListWorkflowExecutions`
  - Changes of the interface `ShowWorkflowExecution`:
    - Add the request parameter `X-Get-Workflow-Full-History-Data`
    - Modify the type `string` -> `object` of the response parameter `workflow_urn`
  - Changes of the interface `ShowWorkFlow`:
    - Remove the response parameters `name`, `description`, `triggers`, `start`, `functions`, `states`, `constants`, `retries`, `mode`, `express_config`, `enterprise_project_id`
    - Modify the type `string` -> `object` of the response parameter `workflow_urn`
    - The response parameter `id`, `workflow_urn`, `created_time`, `updated_time`, `created_by` changed to required
  - Changes of the interface `UpdateWorkFlow`:
    - Add the request parameter `duration`
    - Add the enum values `SMN`, `APIG`, `APIG_DE` to the request parameter `trigger_type`
    - Modify the type `string` -> `object` of the response parameter `workflow_urn`
    - The response parameter `id`, `workflow_urn`, `name`, `description`, `created_time`, `updated_time`, `created_by` changed to required

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeIdCard`:
    - Add the request parameter `detect_reproduce`
    - Add the response parameter `detect_reproduce_result`

### HuaweiCloud SDK ProjectMan

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateIssueV4`:
    - Add the request parameter `field_name`
    - Add the response parameter `field_name`
  - Add the response parameter `field_name` to the interface `ListIssuesV4`
  - Changes of the interface `UpdateIssueV4`:
    - Add the request parameter `field_name`
    - Add the response parameter `field_name`
  - Add the response parameter `field_name` to the interface `ListChildIssuesV4`
  - Changes of the interface `CreateSystemIssueV4`:
    - Add the request parameter `field_name`
    - Add the response parameter `field_name`

### HuaweiCloud SDK VOD

- _Features_
  - Support the following interfaces：
    - `ListTranscodeTemplate`
    - `UpdateTranscodeTemplate`
    - `CreateTranscodeTemplate`
    - `DeleteTranscodeTemplate`
    - `ListTemplateGroupCollection`
    - `UpdateTemplateGroupCollection`
    - `CreateTemplateGroupCollection`
    - `DeleteTemplateGroupCollection`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.100 2022-08-11

### HuaweiCloud SDK CDN

- _Features_
  - Support the interface `ShowUrlTaskInfo`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `ipv6_accelerate` to the interface `ShowDomainFullConfig`
  - Add the request parameter `ipv6_accelerate` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreatePostPaidInstance`:
    - Add the request parameter `broker_num`
    - Add the enum values `c6.2u4g.cluster`, `c6.4u8g.cluster`, `c6.8u16g.cluster`, `c6.12u24g.cluster`, `c6.16u32g.cluster` to the request parameter `specification`
    - Add the enum values `250`, `500`, `1000`, `1500`, `2000` to the request parameter `partition_num`
    - Add the enum values `dms.physical.storage.high.v2`, `dms.physical.storage.ultra.v2` to the request parameter `storage_spec_code`
    - The request parameter `specification` changed to not required
  - Add the response parameters `description`, `access_user`, `ssl_two_way_enable`, `cert_replaced`, `public_boundwidth`, `agent_enable`, `public_access_enabled`, `node_num`, `new_spec_billing_enable`, `broker_num` to the interface `ListInstances`
  - Add the response parameters `description`, `access_user`, `ssl_two_way_enable`, `cert_replaced`, `public_boundwidth`, `agent_enable`, `public_access_enabled`, `node_num`, `new_spec_billing_enable`, `broker_num` to the interface `ShowInstance`
  - The request parameter `engine` changed to not required of the interface `ShowInstanceExtendProductInfo`
  - Changes of the interface `ShowPartitionBeginningMessage`:
    - Add the response parameter `offset`
    - Remove the response parameter `message_offset`
  - Changes of the interface `ShowPartitionEndMessage`:
    - Add the response parameter `offset`
    - Remove the response parameter `message_offset`
  - Add the response parameter `product_alias` to the interface `ListEngineProducts`

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interfaces `RunCreateAudioModerationJob`, `RunQueryAudioModerationJob`
- _Bug Fix_
  - None
- _Change_
  - Remove the request parameter `ad_glossaries` from the interface `RunImageModeration`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeMacaoIdCard`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SWR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `filter` to the interface `ListNamespaces`
  - Add the request parameters `limit`, `offset`, `order_column`, `order_type` to the interface `ListReposDetails`
  - Add the request parameter `filter` to the interface `ListRepositoryTags`
  - Add the request parameters `namespace`, `name`, `center`, `limit`, `offset`, `order_column`, `order_type` to the interface `ListSharedReposDetails`
  - Changes of the interface `ListRetentionHistories`:
    - Add the request parameter `filter`
    - Remove the request parameters `offset`, `limit`

# 3.0.99 2022-08-02

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - Support the interface `UpgradeDbVersion`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `patch_available` to the interface `ListInstances`

### HuaweiCloud SDK Image

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the request parameter `language` from the interface `RunImageDescription`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `CreateProjectDomain`, `ListProjectDomains`, `UpdateProjectDomain`, `CancelProjectDomain`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `auto` to the request parameter `audio_format` to the interface `RecognizeShortAudio`

# 3.0.98 2022-07-28

### HuaweiCloud SDK GaussDB

- _Features_
  - Support the interfaces `ShowDedicatedResourceInfo`, `SetGaussMySqlProxyWeight`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `proxy`, `master_node`, `readonly_nodes` to the interface `ShowGaussMySqlProxy`
  - Add the response parameter `proxy_list` to the interface `ShowGaussMySqlProxyList`
  - Add the response parameter `proxy_flavor_groups` to the interface `ShowGaussMySqlProxyFlavors`
  - Changes of the interface `ShowGaussMySqlBackupList`:
    - Add the enum values `BUILDING`, `COMPLETED`, `FAILED`, `AVAILABLE` to the response parameter `status`
    - Add the enum values `auto`, `manual` to the response parameter `type`
    - Add the enum values `0`, `1`, `2` to the response parameter `backup_level`

### HuaweiCloud SDK KMS

- _Features_
  - Support the following interfaces：
    - `ListKeyStores`
    - `CreateKeyStore`
    - `ShowKeyStore`
    - `DeleteKeyStore`
    - `EnableKeyStore`
    - `DisableKeyStore`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `keystore_id` to the interface `CreateKey`
  - Add the response parameters `keystore_id`, `key_label` to the interface `ListKeys`
  - Add the response parameters `keystore_id`, `key_label` to the interface `ListKeyDetail`
  - Add the response parameters `keystore_id`, `key_label` to the interface `ListKmsByTags`

# 3.0.97 2022-07-21

### HuaweiCloud SDK Core

- _Features_
  - None
- _Bug Fix_
  - Solve the problem of response data decoding failure
- _Change_
  - None

### HuaweiCloud SDK CES

- _Features_
  - Support the following interfaces：
    - `ListAlarmRules`
    - `CreateAlarmRules`
    - `BatchDeleteAlarmRules`
    - `BatchEnableAlarmRules`
    - `ListAlarmRuleResources`
    - `DeleteAlarmRuleResources`
    - `AddAlarmRuleResources`
    - `ListAlarmRulePolicies`
    - `UpdateAlarmRulePolicies`
    - `ListAgentDimensionInfo`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListAlarmHistories`:
    - Add the response parameter `datapoints`
    - Remove the response parameters `data_points`, `type`, `notification_list`, `type`, `notification_list`
    - Modify the type `string` -> `enum` of the response parameter `status`
    - Modify the type `int32` -> `enum` of the response parameter `level`
    - Modify the type `string` -> `enum` of the response parameter `type`
    - Modify the type `integer` -> `enum` of the response parameter `period`
    - Modify the type `float` -> `double` of the response parameter `value`
    - Modify the type `integer` -> `enum` of the response parameter `suppress_duration`

### HuaweiCloud SDK Image

- _Features_
  - Support the interface `RunImageDescription`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `security_group_rules_links` to the interface `NeutronListSecurityGroupRules`

# 3.0.96 2022-07-14

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `tls_version` to the interface `UpdateDomainFullConfig`
  - Add the response parameter `tls_version` to the interface `ShowDomainFullConfig`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `tags`, `cpu_type` to the interface `ShowInstance`

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `date-time` -> `string` of the response parameter `create_time` of the interface `ListPublicips`
  - Modify the type `date-time` -> `string` of the response parameter `create_time` of the interface `ShowPublicip`

### HuaweiCloud SDK Image

- _Features_
  - Support the interfaces `RunImageMediaTagging`, `RunImageMainObjectDetection`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `port_filter`, `ovs_hybrid_plug` to the interface `ListPorts`
  - Add the response parameters `port_filter`, `ovs_hybrid_plug` to the interface `UpdatePort`
  - Add the response parameters `port_filter`, `ovs_hybrid_plug` to the interface `ShowPort`
  - Add the response parameter `remote_address_group_id` to the interface `CreateSecurityGroup`
  - Add the response parameter `remote_address_group_id` to the interface `ListSecurityGroups`
  - Add the response parameter `remote_address_group_id` to the interface `ShowSecurityGroup`
  - Add the response parameter `remote_address_group_id` to the interface `ListSecurityGroupRules`
  - Add the response parameter `remote_address_group_id` to the interface `ShowSecurityGroupRule`
  - Add the response parameter `remote_address_group_id` to the interface `NeutronListSecurityGroups`
  - Add the response parameter `remote_address_group_id` to the interface `NeutronUpdateSecurityGroup`
  - Add the response parameter `remote_address_group_id` to the interface `NeutronShowSecurityGroup`
  - Add the response parameter `remote_address_group_id` to the interface `NeutronListSecurityGroupRules`
  - Add the response parameter `remote_address_group_id` to the interface `NeutronShowSecurityGroupRule`

# 3.0.95 2022-07-07

### HuaweiCloud SDK CCE

- _Features_
  - Support the interfaces `UpdateClusterEip`, `ShowClusterEndpoints`, `ShowVersion`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListNodes`:
    - Add the response parameters `isStatic`, `privateIPv6IP`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `CreateNode`:
    - Add the request parameter `isStatic`
    - The request parameter `key`, `effect` changed to required
  - Changes of the interface `ShowNode`:
    - Add the response parameters `isStatic`, `privateIPv6IP`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `DeleteNode`:
    - Add the response parameters `isStatic`, `privateIPv6IP`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `UpdateNode`:
    - Add the response parameters `isStatic`, `privateIPv6IP`
    - The response parameter `key`, `effect` changed to required
  - The request parameter `key`, `effect` changed to required of the interface `AddNode`
  - The request parameter `key`, `effect` changed to required of the interface `ResetNode`
  - Changes of the interface `ListNodePools`:
    - Add the response parameter `isStatic`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `CreateNodePool`:
    - Add the request parameter `isStatic`
    - The request parameter `key`, `effect` changed to required
  - Changes of the interface `ShowNodePool`:
    - Add the response parameter `isStatic`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `DeleteNodePool`:
    - Add the response parameter `isStatic`
    - The response parameter `key`, `effect` changed to required
  - Changes of the interface `UpdateNodePool`:
    - Add the response parameter `isStatic`
    - The request parameter `key`, `effect` changed to required
    - The response parameter `key`, `effect` changed to required

### HuaweiCloud SDK ELB

- _Features_
  - Support the interfaces `ListMasterSlavePools`, `CreateMasterSlavePool`, `ShowMasterSlavePool`, `DeleteMasterSlavePool`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListSystemSecurityPolicies`:
    - Modify the type `array` -> `string` of the response parameter `protocols`
    - Modify the type `array` -> `string` of the response parameter `ciphers`
  - Add the request parameter `X-Auth-Token` to the interface `ListQuotaDetails`
  - Add the request parameter `public_border_group` to the interface `ListAvailabilityZones`
  - Changes of the interface `CreateLoadBalancer`:
    - Add the request parameters `id`, `global_eip_ids`
    - Remove the request parameter `min_l4_flavor_id`
    - The request parameter `X-Auth-Token` changed to required
  - Changes of the interface `ListLoadBalancers`:
    - Add the response parameters `global_eips`, `public_border_group`
    - Remove the response parameter `min_l4_flavor_id`
    - The request parameter `X-Auth-Token` changed to required
  - Changes of the interface `UpdateLoadBalancer`:
    - Add the request parameter `cloud_service_console_url`
    - Add the response parameters `global_eips`, `public_border_group`
    - Remove the request parameter `min_l4_flavor_id`
    - Remove the response parameter `min_l4_flavor_id`
  - Changes of the interface `ShowLoadBalancer`:
    - Add the response parameters `global_eips`, `public_border_group`
    - Remove the response parameter `min_l4_flavor_id`
  - Add the request parameter `X-Auth-Token` to the interface `ChangeLoadbalancerChargeMode`
  - Remove the request parameters `enc_certificate`, `enc_private_key` from the interface `CreateCertificate`
  - Remove the response parameters `enc_certificate`, `enc_private_key` from the interface `ListCertificates`
  - Changes of the interface `UpdateCertificate`:
    - Remove the request parameters `enc_certificate`, `enc_private_key`
    - Remove the response parameters `enc_certificate`, `enc_private_key`
  - Remove the response parameters `enc_certificate`, `enc_private_key` from the interface `ShowCertificate`
  - Add the request parameter `quic_config` to the interface `CreateListener`
  - Add the response parameter `quic_config` to the interface `ListListeners`
  - Changes of the interface `UpdateListener`:
    - Add the request parameter `quic_config`
    - Add the response parameter `quic_config`
  - Add the response parameter `quic_config` to the interface `ShowListener`
  - Add the request parameters `vpc_id`, `type` to the interface `CreatePool`
  - Changes of the interface `ListPools`:
    - Add the request parameters `vpc_id`, `type`
    - Add the response parameters `created_at`, `updated_at`, `vpc_id`, `type`
  - Changes of the interface `UpdatePool`:
    - Add the request parameters `X-Auth-Token`, `vpc_id`, `type`
    - Add the response parameters `created_at`, `updated_at`, `vpc_id`, `type`
  - Add the response parameters `created_at`, `updated_at`, `vpc_id`, `type` to the interface `ShowPool`
  - Modify the type `enum` -> `string` of the request parameter `project_id` of the interface `CreateMember`
  - Changes of the interface `ListMembers`:
    - Add the response parameters `status`, `loadbalancers`, `created_at`, `updated_at`
    - Remove the request parameter `instance_id`
  - Add the response parameters `status`, `loadbalancers`, `created_at`, `updated_at` to the interface `UpdateMember`
  - Add the response parameters `status`, `loadbalancers`, `created_at`, `updated_at` to the interface `ShowMember`
  - Add the response parameters `status`, `loadbalancers`, `created_at`, `updated_at` to the interface `ListAllMembers`
  - Add the response parameters `created_at`, `updated_at` to the interface `ListHealthMonitors`
  - Add the response parameters `created_at`, `updated_at` to the interface `UpdateHealthMonitor`
  - Add the response parameters `created_at`, `updated_at` to the interface `ShowHealthMonitor`
  - Add the request parameter `redirect_pools_config` to the interface `CreateL7Policy`
  - Add the response parameters `redirect_pools_config`, `created_at`, `updated_at` to the interface `ListL7Policies`
  - Changes of the interface `UpdateL7Policy`:
    - Add the request parameter `redirect_pools_config`
    - Add the response parameters `redirect_pools_config`, `created_at`, `updated_at`
  - Add the response parameters `redirect_pools_config`, `created_at`, `updated_at` to the interface `ShowL7Policy`
  - Add the request parameter `X-Auth-Token` to the interface `BatchUpdatePoliciesPriority`
  - Add the response parameters `created_at`, `updated_at` to the interface `ListL7Rules`
  - Add the response parameters `created_at`, `updated_at` to the interface `UpdateL7Rule`
  - Add the response parameters `created_at`, `updated_at` to the interface `ShowL7Rule`
  - Changes of the interface `UpdateIpList`:
    - Remove the request parameters `name`, `ip_list`, `description`
    - The request parameter `X-Auth-Token` changed to required
  - Changes of the interface `BatchDeleteIpList`:
    - Add the request parameter `BatchDeleteIpListRequestBody`
    - Remove the request parameter `BatchDeleteIpGroupIpListRequestBody`
    - The request parameter `X-Auth-Token` changed to required
  - Changes of the interface `BatchCreateMembers`:
    - Add the request parameter `BatchCreateMembersRequestBody`
    - Add the response parameter `status`
    - Remove the request parameter `BatchCreateMemberRequestBody`
  - Changes of the interface `BatchDeleteMembers`:
    - Add the request parameter `BatchDeleteMembersRequestBody`
    - Remove the request parameter `BatchDeleteMemberRequestBody`
  - Changes of the interface `UpdateLogtank`:
    - Add the request parameter `UpdateLogtankRequestBody`
    - Remove the request parameter `logtank`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `title` to the interface `RecognizeVatInvoice`

### HuaweiCloud SDK SIS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `chinese_16k_travel` to the request parameter `property` to the interface `RecognizeShortAudio`
  - Add the enum values `chinese_16k_media` to the request parameter `property` to the interface `PushTranscriberJobs`
  - Add the response parameter `audio_duration` to the interface `CollectTranscriberJob`
  - Add the enum values `chinese_huaxiaomei_common`, `chinese_huaxiaofei_common` to the request parameter `property` to the interface `RunTts`

# 3.0.94 2022-06-30

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `cache_url_parameter_filter` to the interface `ShowDomainFullConfig`
  - Add the request parameter `cache_url_parameter_filter` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK DNS

- _Features_
  - Support the interfaces `CreateRecordSetWithBatchLines`, `BatchUpdateRecordSetWithLine`, `BatchDeleteRecordSetWithLine`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `records` changed to not required of the interface `CreateRecordSetWithLine`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interface `UpdateFunctionMaxInstanceConfig`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `lb_port` to the interface `ListInstances`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interfaces `RecognizeHkIdCard`, `RecognizeCambodianIdCard`, `RecognizeExitEntryPermit`, `RecognizeMainlandTravelPermit`
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int32` -> `float` of the response parameter `direction` of the interface `RecognizeGeneralText`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `CreateProjectModule`, `ListProjectModules`, `UpdateProjectModule`, `DeleteProjectModule`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.93 2022-06-25

### HuaweiCloud SDK DDS

- _Features_
  - Support the following interfaces:
    - `ShowEntityConfiguration`
    - `UpdateEntityConfiguration`
    - `ShowConfigurationParameter`
    - `UpdateConfigurationParameter`
    - `DeleteConfiguration`
    - `ListConfigurations`
    - `CreateConfiguration`
    - `SwitchConfiguration`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `configurations`, `charge_info` to the interface `CreateInstance`
  - Changes of the interface `ResizeInstanceVolume`:
    - Add the request parameter `is_auto_pay`
    - Add the response parameter `order_id`
  - Changes of the interface `AddShardingNode`:
    - Add the request parameter `is_auto_pay`
    - Add the response parameter `order_id`
  - Changes of the interface `ResizeInstance`:
    - Add the request parameter `is_auto_pay`
    - Add the response parameter `order_id`
  - Add the request parameters `configurations`, `charge_info` to the interface `RestoreNewInstance`

# 3.0.92 2022-06-23

### HuaweiCloud SDK ELB

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListQuotaDetails`:
    - Add the request parameter `quota_key`
    - Remove the request parameter `type`
  - Changes of the interface `ListListeners`:
    - Add the request parameters `loadbalancer_id`, `connection_limit`, `admin_state_up`, `http2_enable`, `enterprise_project_id`
    - Remove the request parameters `member_timeout`, `client_timeout`, `keepalive_timeout`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `subnet_id` to the interface `ListInstances`
  - Add the request parameter `subnet_id` to the interface `ExpandInstanceNode`

# 3.0.91 2022-06-19

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeIdDocument`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.90 2022-06-09

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `UpdateFunctionCode`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `ShowFunctionCode`
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the request parameter `domain_names`
    - Add the response parameter `domain_names`
    - Modify the type `string` -> `enum` of the response parameter `runtime`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `ShowFunctionConfig`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `CreateFunctionVersion`
  - Add the request parameter `option` to the interface `ListStatistics`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `CreateDependency`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `ListDependencies`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `UpdateDependency`
  - Modify the type `string` -> `enum` of the response parameter `runtime` of the interface `ShowDependency`
  - The request parameter `content` changed to required of the interface `UpdateEvent`
  - Add the request parameter `marker` to the interface `ListFunctionAsyncInvocations`
  - The request parameter `workflow_urns` changed to required of the interface `BatchDeleteWorkflows`
  - The request parameter `name`, `trigger_name`, `trigger_type`, `bucket`, `events`, `prefix`, `suffix`, `start`, `name`, `operation`, `id`, `name`, `type`, `end`, `transition`, `ref_name`, `arguments`, `constants`, `name` changed to required of the interface `CreateWorkflow`
  - The request parameter `input` changed to required of the interface `StartWorkflowExecution`
  - Add the response parameters `node_name`, `execution_id`, `request_id` to the interface `ShowWorkflowExecution`
  - The request parameter `name`, `trigger_name`, `trigger_type`, `bucket`, `events`, `prefix`, `suffix`, `start`, `name`, `operation`, `id`, `name`, `type`, `end`, `transition`, `ref_name`, `arguments`, `constants`, `name` changed to required of the interface `UpdateWorkFlow`
  - Changes of the interface `ShowWorkFlow`:
    - Add the response parameters `lts_group_id`, `lts_stream_id`
    - The response parameter `name`, `trigger_name`, `trigger_type`, `bucket`, `events`, `prefix`, `suffix`, `start`, `name`, `operation`, `id`, `name`, `type`, `end`, `transition`, `ref_name`, `arguments`, `constants`, `name` changed to required
  - The request parameter `input` changed to required of the interface `StartSyncWorkflowExecution`

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interface `RunTextModeration`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.89 2022-06-02

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `instance_id` to the interface `ListFlavors`

### HuaweiCloud SDK NAT

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListNatGateways`:
    - Modify the type `date-time` -> `string` of the request parameter `created_at`
    - Modify the type `date-time` -> `string` of the response parameter `created_at`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `UpdateNatGateway`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `ShowNatGateway`
  - Changes of the interface `ListNatGatewayDnatRules`:
    - Modify the type `date-time` -> `string` of the request parameter `created_at`
    - Modify the type `date-time` -> `string` of the response parameter `created_at`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `UpdateNatGatewayDnatRule`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `ShowNatGatewayDnatRule`
  - Changes of the interface `ListNatGatewaySnatRules`:
    - Modify the type `date-time` -> `string` of the request parameter `created_at`
    - Modify the type `date-time` -> `string` of the response parameter `created_at`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `UpdateNatGatewaySnatRule`
  - Modify the type `date-time` -> `string` of the response parameter `created_at` of the interface `ShowNatGatewaySnatRule`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `words_block_count`, `words_block_list` to the interface `RecognizeHealthCode`
  - Modify the type `float` -> `object` of the response parameter `confidence` of the interface `RecognizePcrTestRecord`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the following interfaces:
    - `ListIssueCustomFields`
    - `ListIssuesSfV4`
    - `ListProjectIssuesRecordsV4`
    - `ListWorkitemStatusRecordsV4`
    - `ListWorkitems`
    - `ShowIssuesWrokFlowConfig`
    - `ShowWorkItemWrokflowConfig`
    - `ListAssociatedIssues`
    - `ListAssociatedWikis`
    - `ListIssueAssociatedCommits`
    - `ListAssociatedTestCases`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateIssueV4`:
    - Add the request parameter `new_custom_fields`
    - Add the response parameters `new_custom_fields`, `new_name`
  - Changes of the interface `ListIssuesV4`:
    - Add the request parameter `custom_fields`
    - Add the response parameters `new_custom_fields`, `new_name`
  - Add the response parameters `new_custom_fields`, `new_name` to the interface `ShowIssueV4`
  - Changes of the interface `UpdateIssueV4`:
    - Add the request parameter `new_custom_fields`
    - Add the response parameters `new_custom_fields`, `new_name`
  - Add the response parameters `new_custom_fields`, `new_name` to the interface `ListChildIssuesV4`
  - Changes of the interface `CreateSystemIssueV4`:
    - Add the request parameter `new_custom_fields`
    - Add the response parameters `new_custom_fields`, `new_name`

# 3.0.88 2022-05-26

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `features`, `sub_status` to the interface `ListInstances`
  - Add the response parameters `features`, `transparent_client_ip_enable`, `sub_status` to the interface `ShowInstance`
  - Add the request parameter `execute_immediately` to the interface `ResizeInstance`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `volume_type`, `hw:passthrough` to the interface `AttachServerVolume`

### HuaweiCloud SDK KMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ValidateSignature`:
    - Add the response parameter `signature_valid`
    - Remove the response parameter `signature_vaild`

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `ocr_text`, `error_code`, `error_msg` to the interface `RunCheckResult`
  - Changes of the interface `RunImageBatchModeration`:
    - Add the request parameters `moderation_rule`, `ad_categories`, `show_ocr_text`
    - Add the response parameters `ocr_text`, `error_code`, `error_msg`
  - Add the request parameters `moderation_rule`, `ad_categories`, `show_ocr_text` to the interface `RunTaskSumbit`

# 3.0.87 2022-05-19

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `dry_run` to the interface `ResizeServer`
  - Add the request parameter `dry_run` to the interface `ResizePostPaidServer`
  - Add the request parameter `dry_run` to the interface `AttachServerVolume`

### HuaweiCloud SDK VOD

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `M3U8` to the request parameter `video_type` to the interface `UploadMetaDataByUrl`
  - Add the response parameter `sign_url` to the interface `PublishAssets`
  - Add the response parameter `sign_url` to the interface `UnpublishAssets`
  - Add the response parameter `sign_url` to the interface `ShowAssetMeta`
  - Add the response parameter `sign_url` to the interface `ShowAssetDetail`
  - Add the response parameter `sign_url` to the interface `ShowTakeOverTaskDetails`
  - Add the response parameter `sign_url` to the interface `ShowTakeOverAssetDetails`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `neutron:VIP_PORT`, Remove the enum values `network:VIP_PORT` from the response parameter `device_owner` to the interface `ListPorts`
  - Add the enum values `neutron:VIP_PORT`, Remove the enum values `network:VIP_PORT` from the response parameter `device_owner` to the interface `UpdatePort`
  - Add the enum values `neutron:VIP_PORT`, Remove the enum values `network:VIP_PORT` from the response parameter `device_owner` to the interface `ShowPort`

# 3.0.86 2022-05-12

### HuaweiCloud SDK FRS

- _Features_
  - Support the following interfaces:
    - `DetectLiveByUrlIntl`
    - `DetectLiveByFileIntl`
    - `DetectLiveByBase64Intl`
    - `DetectFaceByFileIntl`
    - `DetectFaceByUrlIntl`
    - `DetectFaceByBase64Intl`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IAM

- _Features_
  - Support the interface `ShowDomainRoleAssignments`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RunImageModeration`:
    - Add the request parameter `show_ocr_text`
    - Add the response parameter `ocr_text`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeHealthCode`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK RocketMQ

- _Features_
  - Support the service `RocketMQ`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.85 2022-05-05

### HuaweiCloud SDK Moderation

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `byte` -> `string` of the request parameter `image` of the interface `RunImageModeration`

# 3.0.84 2022-04-28

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interfaces `CancelAsyncInvocation`, `StartSyncWorkflowExecution`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListFunctionStatistics`:
    - Modify the type `int32` -> `int64` of the response parameter `timestamp`
    - Modify the type `int32` -> `double` of the response parameter `value`
  - Changes of the interface `ListStatistics`:
    - Modify the type `int32` -> `int64` of the response parameter `timestamp`
    - Modify the type `int32` -> `double` of the response parameter `value`
  - Add the response parameter `enable_async_status_log` to the interface `ListFunctionAsyncInvokeConfig`
  - Add the response parameter `enable_async_status_log` to the interface `ShowFunctionAsyncInvokeConfig`
  - Changes of the interface `UpdateFunctionAsyncInvokeConfig`:
    - Add the request parameter `enable_async_status_log`
    - Add the response parameter `enable_async_status_log`
  - Changes of the interface `CreateWorkflow`:
    - Add the request parameters `mode`, `express_config`
    - Add the enum values `End` to the request parameter `type`
  - Changes of the interface `ShowWorkFlow`:
    - Add the response parameters `mode`, `express_config`
    - Add the enum values `End` to the response parameter `type`
  - Changes of the interface `UpdateWorkFlow`:
    - Add the request parameters `mode`, `express_config`
    - Add the enum values `End` to the request parameter `type`
  - Changes of the interface `ShowTenantMetric`:
    - Add the request parameters `start_time`, `end_time`
    - Modify the type `int32` -> `int64` of the response parameter `timestamp`
    - Modify the type `int32` -> `double` of the response parameter `value`
  - Changes of the interface `ShowWorkFlowMetric`:
    - Add the request parameters `start_time`, `end_time`
    - Modify the type `int32` -> `int64` of the response parameter `timestamp`
    - Modify the type `int32` -> `double` of the response parameter `value`

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - Fix the problem that the response body's type of the interface `RecognizeMyanmarDriverLicense` is incorrect.
- _Change_
  - None

# 3.0.83 2022-04-21

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `iam_agency_name` to the interface `CreateScalingGroup`
  - Add the response parameter `iam_agency_name` to the interface `ListScalingGroups`
  - Add the request parameter `iam_agency_name` to the interface `UpdateScalingGroup`
  - Add the response parameter `iam_agency_name` to the interface `ShowScalingGroup`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `domain_name_info` to the interface `ShowInstance`

# 3.0.82 2022-04-14

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `sources`, `origin_protocol`, `force_redirect`, `compress` to the interface `UpdateDomainFullConfig`
  - Changes of the interface `ShowDomainFullConfig`:
    - Add the response parameters `sources`, `origin_protocol`, `force_redirect`, `compress`
    - Modify the type `string` -> `int32` of the response parameter `certificate_source`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `rename_commands` to the interface `UpdateInstance`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `ip_eq` to the interface `ListServersDetails`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `encrypted_user_data` to the interface `UpdateFunctionConfig`

### HuaweiCloud SDK Moderation

- _Features_
  - Support the interface `RunModerationAudio`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.81 2022-04-07

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the request parameters `kind`, `apiVersion`, `status` from the interface `UpdateNodePool`

### HuaweiCloud SDK OCR

- _Features_
  - Support the interface `RecognizeWaybillElectronic`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `print_code` to the interface `RecognizeVatInvoice`
  - Changes of the interface `RecognizeVehicleLicense`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`
  - Changes of the interface `RecognizeTaxiInvoice`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`
  - Add the response parameters `type`, `accumulated_scores`, `status`, `generation_date`, `current_time` to the interface `RecognizeDriverLicense`
  - Changes of the interface `RecognizeTrainTicket`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`
  - Changes of the interface `RecognizeBankcard`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`

# 3.0.80 2022-03-31

### HuaweiCloud SDK DCS

- _Features_
  - Support the interface `BatchShowNodesInformation`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.79 2022-03-25

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces(v2):
    - `ShowDomainLocationStats`
    - `ShowDomainStats`
    - `ShowTopUrl`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameters `group_name`, `replication_ip` to the interface `ListRedislog`

### HuaweiCloud SDK DNS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameter `routers` from the interface `ListPublicZones`
  - Add the request parameters `marker`, `limit`, `offset`, `line_id`, `tags`, `status`, `type`, `name`, `id`, `sort_key`, `sort_dir`, `search_mode` to the interface `ShowRecordSetByZone`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the following interfaces:
    - `ListWorkflows`
    - `CreateWorkflow`
    - `BatchDeleteWorkflows`
    - `ListWorkflowExecutions`
    - `StartWorkflowExecution`
    - `ShowWorkflowExecution`
    - `ShowWorkFlow`
    - `UpdateWorkFlow`
    - `ShowTenantMetric`
    - `ShowWorkFlowMetric`
    - `RetryWorkFlow`
    - `StopWorkFlow`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IMS

- _Features_
  - Support the interfaces `ListVersions`, `ShowVersion`
- _Bug Fix_
  - None
- _Change_
  - The request parameter `os_type` changed to not required of the interface `CreateDataImage`

### HuaweiCloud SDK IoTDA

- _Features_
  - Support the interface `ResetFingerprint`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK OCR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `RecognizeVatInvoice`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`
  - Changes of the interface `RecognizeIdCard`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`
  - Changes of the interface `RecognizeDriverLicense`:
    - Add the request parameter `return_text_location`
    - Add the response parameter `text_location`

# 3.0.78 2022-03-10

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `cluster_id` changed to not required of the interface `DeleteAddonInstance`

### HuaweiCloud SDK CDN

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the request parameter `X-Auth-Token` from the interface `ShowTopUrl`
  - Remove the request parameter `X-Auth-Token` from the interface `ShowDomainLocationStats`
  - Remove the request parameter `X-Auth-Token` from the interface `ShowDomainItemDetails`
  - Remove the request parameter `X-Auth-Token` from the interface `ShowDomainStats`
  - Remove the request parameter `X-Auth-Token` from the interface `ShowDomainItemLocationDetails`

### HuaweiCloud SDK ELB

- _Features_
  - Support the following interfaces:
    - `ListLogtanks`
    - `CreateLogtank`
    - `ShowLogtank`
    - `UpdateLogtank`
    - `DeleteLogtank`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `https_cps` to the interface `ListFlavors`
  - Add the response parameter `https_cps` to the interface `ShowFlavor`
  - The request parameter `X-Auth-Token` changed to not required of the interface `ListLoadBalancers`
  - The request parameter `X-Auth-Token` changed to not required of the interface `CreateLoadBalancer`
  - The request parameter `X-Auth-Token` changed to not required of the interface `UpdateIpList`
  - The request parameter `X-Auth-Token` changed to not required of the interface `BatchDeleteIpList`

# 3.0.77 2022-03-07

### HuaweiCloud SDK CCE

- _Features_
  - Support the interfaces `UpdateClusterEip`, `ShowClusterEndpoints`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CES

- _Features_
  - Support the following interfaces (V2):
    - `ListAlarms`
    - `CreateAlarm`
    - `DeleteAlarm`
    - `UpdateAlarmAction`
    - `ListAlarmResources`
    - `DeleteAlarmResources`
    - `AddAlarmResources`
    - `AddResourceGroupsResourcesBatch`
    - `DeleteResourceGroupsResourcesBatch`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK EIP

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type of the request parameter `ip_version` of the interface `CreatePrePaidPublicip`: `integer` -> `enum`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `order_id` to the interface `ShrinkInstanceNode`

# 3.0.76 2022-02-25

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `alarm_id` to the interface `ListAllScalingV2Policies`
  - Add the enum values `GPSSD` to the request parameter `volume_type` to the interface `CreateScalingConfig`
  - Add the response parameter `min` to the interface `ShowResourceQuota`
  - Add the response parameter `min` to the interface `ShowPolicyAndInstanceQuota`

### HuaweiCloud SDK BMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `UpdateBaremetalServerMetadata`:
    - Modify the type of the request body `MetaData` -> `UpdateBaremetalServerMetadataReq`
    - Remove the response parameter `key`

### HuaweiCloud SDK CDN

- _Features_
  - Support the interfaces `ShowDomainLocationStats`, `ShowDomainFullConfig`
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ShowDomainStats`:
    - Add the request parameter `service_area`
    - Remove the request parameters `X-Auth-Token`, `country`, `district`, `isp`
    - Remove the response parameters `start_time`, `end_time`, `interval`, `action`, `stat_type`, `group_by`
  - Add the request parameter `https` to the interface `UpdateDomainFullConfig`

### HuaweiCloud SDK ELB

- _Features_
  - Support the interfaces `BatchCreateMembers`, `BatchDeleteMembers`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `ListFunctions`
  - Changes of the interface `CreateFunction`:
    - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the request parameter `runtime`
    - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `ShowFunctionCode`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `UpdateFunctionCode`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `ShowFunctionConfig`
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the request parameter `runtime`
    - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `ListFunctionVersions`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `CreateFunctionVersion`
  - Add the enum values `Java11`, `Node.js14.18`, `Python3.9` to the request parameter `runtime` to the interface `CreateDependency`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `PHP 7.3` from the request parameter `runtime` to the interface `UpdateDependency`
  - Add the enum values `Java8`, `Java11`, `Node.js6.10`, `Node.js8.10`, `Node.js10.16`, `Node.js12.13`, `Node.js14.18`, `Python2.7`, `Python3.6`, `Python3.9`, `Go1.8`, `Go1.x`, `PHP7.3`, Remove the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3` from the response parameter `runtime` to the interface `ImportFunction`

### HuaweiCloud SDK ProjectMan

- _Features_
  - Support the interfaces `BatchUpdateChildNickNames`, `ListIterationHistories`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `updated_time_interval`, `include_deleted` to the interface `ListProjectIterationsV4`
  - Add the request parameters `include_deleted`, `updated_time_interval` to the interface `ListIssuesV4`
  - Add the response parameters `description`, `order`, `accessories` to the interface `ShowIssueV4`

### HuaweiCloud SDK VOD

- _Features_
  - Support the interface `ListDomainLogs`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `delete_type` to the interface `DeleteAssets`

### HuaweiCloud SDK VPC

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `subnetpool_id` to the interface `NeutronListSubnets`

# 3.0.75 2022-02-10

### HuaweiCloud SDK CBR

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListProtectable`:
    - Modify the type `string` -> `boolean` of the response parameter `result`
    - Modify the type `string` -> `int32` of the response parameter `size`
  - Changes of the interface `ShowProtectable`:
    - Modify the type `string` -> `boolean` of the response parameter `result`
    - Modify the type `string` -> `int32` of the response parameter `size`

### HuaweiCloud SDK CCE

- _Features_
  - Support the interface `ShowVersion`
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameters `kind`, `apiVersion`, `metadata`, `spec`, `status` from the interface `CreateAddonInstance`
  - Add the response parameters `isStatic`, `privateIPv6IP` to the interface `ListNodes`
  - Add the request parameter `isStatic` to the interface `CreateNode`
  - Add the response parameters `isStatic`, `privateIPv6IP` to the interface `DeleteNode`
  - Add the response parameters `isStatic`, `privateIPv6IP` to the interface `ShowNode`
  - Add the response parameters `isStatic`, `privateIPv6IP` to the interface `UpdateNode`
  - Changes of the interface `RemoveNode`:
    - The request parameter `uid` changed to required
    - The response parameter `uid` changed to required
  - Changes of the interface `MigrateNode`:
    - The request parameter `uid` changed to required
    - The response parameter `uid` changed to required
  - Add the response parameter `isStatic` to the interface `ListNodePools`
  - Add the request parameter `isStatic` to the interface `CreateNodePool`
  - Add the response parameter `isStatic` to the interface `DeleteNodePool`
  - Add the response parameter `isStatic` to the interface `ShowNodePool`
  - Changes of the interface `UpdateNodePool`:
    - Add the request parameter `isStatic`
    - Add the response parameter `isStatic`

### HuaweiCloud SDK DCS

- _Features_
  - Support the interfaces `CreateOnlineMigrationTask`, `SetOnlineMigrationTask`, `BatchStopMigrationTasks`, `StopMigrationTaskSync`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `CreateFunction`:
    - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the request parameter `runtime`
    - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `ListFunctions`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `UpdateFunctionCode`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `ShowFunctionCode`
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the request parameter `runtime`
    - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `ShowFunctionConfig`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `CreateFunctionVersion`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `ListFunctionVersions`
  - Add the enum values `Go1.x` to the request parameter `runtime` to the interface `CreateDependency`
  - Add the enum values `Go1.x` to the request parameter `runtime` to the interface `UpdateDependency`
  - Add the enum values `Java 8`, `Node.js 6.10`, `Node.js 8.10`, `Node.js 10.16`, `Node.js 12.13`, `Python 2.7`, `Python 3.6`, `Go 1.8`, `Go 1.x`, `PHP 7.3`, Remove the enum values `Python2.7`, `Python3.6`, `Go1.8`, `Java8`, `Node.js6.10`, `Node.js8.10`, `Custom`, `PHP7.3` from the response parameter `runtime` to the interface `ImportFunction`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int32` -> `string` of the response parameter `port` of the interface `ListInstances`

# 3.0.74 2022-01-25

### HuaweiCloud SDK CES

- _Features_
  - Support the interface `ListAlarmHistories`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK IAM

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `session_user_id` to the interface `CreateLoginToken`

### HuaweiCloud SDK Kafka

- _Features_
  - Support the interface `ListEngineProducts`
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `dr_enable` to the interface `ListInstances`
  - Add the response parameter `dr_enable` to the interface `ShowInstance`
  - Changes of the interface `ListProducts`:
    - Add the response parameters `Hourly`, `Monthly`
    - Remove the response parameters `hourly`, `honthly`

### HuaweiCloud SDK RabbitMQ

- _Features_
  - Support the interface `ListEngineProducts`
- _Bug Fix_
  - None
- _Change_
  - None
  
# 3.0.73 2022-01-17

### HuaweiCloud SDK CCE

- _Features_
  - None
- _Bug Fix_
  - Fix the problem that the request body structure of the interface `CreateNodePool` is incorrect
- _Change_
  - None

### HuaweiCloud SDK FunctionGraph

- _Features_
  - Support the interface `ListFunctionAsyncInvocations`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.72 2022-01-10

### HuaweiCloud SDK CCE

- _Features_
  - Support the interface `ShowQuotas`
- _Bug Fix_
  - None
- _Change_
  - Add the request parameters `customSan`, `offloadCluster`, `cidrs`, `flavor`, `faultDomain` to the interface `CreateCluster`
  - Add the response parameters `customSan`, `offloadCluster`, `cidrs`, `flavor`, `faultDomain` to the interface `ListClusters`
  - Changes of the interface `UpdateCluster`:
    - Add the request parameters `customSan`, `containerNetwork`
    - Add the response parameters `customSan`, `offloadCluster`, `cidrs`, `flavor`, `faultDomain`
  - Add the response parameters `customSan`, `offloadCluster`, `cidrs`, `flavor`, `faultDomain` to the interface `ShowCluster`
  - Add the response parameters `customSan`, `offloadCluster`, `cidrs`, `flavor`, `faultDomain` to the interface `DeleteCluster`
  - Add the request parameters `faultDomain`, `offloadNode`, `offloadNode` to the interface `CreateNode`
  - Add the response parameters `faultDomain`, `offloadNode`, `offloadNode` to the interface `ListNodes`
  - Add the response parameters `faultDomain`, `offloadNode`, `offloadNode` to the interface `UpdateNode`
  - Add the response parameters `faultDomain`, `offloadNode`, `offloadNode` to the interface `ShowNode`
  - Add the response parameters `faultDomain`, `offloadNode`, `offloadNode` to the interface `DeleteNode`
  - Add the request parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode` to the interface `CreateNodePool`
  - Add the response parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode` to the interface `ListNodePools`
  - Changes of the interface `UpdateNodePool`:
    - Add the request parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode`
    - Add the response parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode`
  - Add the response parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode` to the interface `ShowNodePool`
  - Add the response parameters `podSecurityGroups`, `faultDomain`, `offloadNode`, `offloadNode` to the interface `DeleteNodePool`

### HuaweiCloud SDK CDN

- _Features_
  - Support `Content Delivery Network` service.
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `ecs_tenant_private_ip` to the interface `ListMigrationTask`
  - Add the response parameter `ecs_tenant_private_ip` to the interface `ShowMigrationTask`
  - Add the response parameter `ecs_tenant_private_ip` to the interface `StopMigrationTask`

### HuaweiCloud SDK DDS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameter `lb_ip_address` from the interface `ListInstances`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `delete_on_termination` to the interface `CreateServers`

### HuaweiCloud SDK FunctionGraph

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `UpdateFunctionConfig`:
    - Add the request parameter `is_stateful_function`
    - Add the response parameter `is_stateful_function`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `lb_ip_address` to the interface `ListInstances`

### HuaweiCloud SDK IMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The response parameter `active_at` changed to not required of the interface `GlanceListImages`
  - The response parameter `active_at` changed to not required of the interface `GlanceShowImage`
  - The response parameter `active_at` changed to not required of the interface `GlanceUpdateImage`

### HuaweiCloud SDK KPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListKeypairs`:
    - Add the request parameters `limit`, `marker`
    - Add the response parameter `page_info`
  - Add the request parameters `limit`, `offset` to the interface `ListFailedTask`
  - Add the request parameters `limit`, `offset` to the interface `ListRunningTask`

# 3.0.71 2021-12-25

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `backup_format` to the interface `CopyInstance`

### HuaweiCloud SDK ECS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameter `updated_at` from the interface `NovaListServerActions`

### HuaweiCloud SDK Kafka

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `partition_num` changed to not required of the interface `CreatePostPaidInstance`
  - Add the response parameters `result`, `instance_id` to the interface `RestartManager`
  - Changes of the interface `ListProducts`:
    - Add the response parameters `hourly`, `honthly`
    - Remove the response parameters `Hourly`, `Monthly`

### HuaweiCloud SDK KPS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Modify the type `int64` -> `string` of the response parameter `task_time` of the interface `ListFailedTask`
  - Modify the type `int64` -> `string` of the response parameter `task_time` of the interface `ListRunningTask`

# 3.0.70 2021-12-17

### HuaweiCloud SDK CCE

- _Features_
  - Support the interface `ShowVersion`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK CES

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Changes of the interface `ListEvents`:
    - Modify the type `string` -> `int32` of the response parameter `event_count`
    - Modify the type `string` -> `int64` of the response parameter `latest_occur_time`
  - Modify the type `string` -> `double` of the response parameter `variance` of the interface `BatchListMetricData`
  - Modify the type `string` -> `int32` of the response parameter `type_statistics` of the interface `ListResourceGroup`
  - Changes of the interface `ListEventDetail`:
    - Modify the type `string` -> `array` of the response parameter `event_users`
    - Modify the type `string` -> `array` of the response parameter `event_sources`

### HuaweiCloud SDK OCR

- _Features_
  - Support the following interfaces:
    - `RecognizeThailandIdcard`
    - `RecognizeMyanmarIdcard`
    - `RecognizeMyanmarDriverLicense`
    - `RecognizeChileIdCard`
    - `RecognizeThailandLicensePlate`
- _Bug Fix_
  - None
- _Change_
  - None

### HuaweiCloud SDK SIS

- _Features_
  - Support the `Voice Interaction Service`
- _Bug Fix_
  - None
- _Change_
  - None

# 3.0.69 2021-12-10

### HuaweiCloud SDK AS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `allowed_address_pairs` to the interface `ListScalingGroups`
  - Add the request parameter `allowed_address_pairs` to the interface `CreateScalingGroup`
  - Add the request parameter `allowed_address_pairs` to the interface `UpdateScalingGroup`
  - Add the response parameter `allowed_address_pairs` to the interface `ShowScalingGroup`

### HuaweiCloud SDK DCS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the response parameter `readonly_domain_name` to the interface `ListInstances`
  - Add the response parameter `readonly_domain_name` to the interface `ShowInstance`

### HuaweiCloud SDK FRS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Remove the response parameters `landmark`, `gender`, `yaw_angle`, `roll_angle`, `pitch_angle`, `headpose`, `smile`, `skin`, `ethnic` from the interface `DetectFaceByFile`
  - Remove the response parameters `landmark`, `gender`, `yaw_angle`, `roll_angle`, `pitch_angle`, `headpose`, `smile`, `skin`, `ethnic` from the interface `DetectFaceByUrl`
  - Remove the response parameters `landmark`, `gender`, `yaw_angle`, `roll_angle`, `pitch_angle`, `headpose`, `smile`, `skin`, `ethnic` from the interface `DetectFaceByBase64`

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - The request parameter `region` changed to required of the interface `ListFlavors`

### HuaweiCloud SDK KMS

- _Features_
  - None
- _Bug Fix_
  - None
- _Change_
  - Add the request parameter `encrypted_privatekey` to the interface `ImportKeyMaterial`

### HuaweiCloud SDK SWR

- _Features_
  - Support the interface `ListQuotas`
- _Bug Fix_
  - None
- _Change_
  - Modify the name `UpdateNamespaceAuthReq` -> `UpdateNamespaceAuthRequestBody` of the request body of the interface `UpdateNamespaceAuth`

# 3.0.68 2021-11-29

### HuaweiCloud SDK CBR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `provider_id` to the interface `ListBackups`.

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `cidrs` to the interface `ShowCluster`.

### HuaweiCloud SDK DSC

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `start_time` to the interface `ShowScanJobs`.

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Remove the interface `CinderExportToImage`.

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `os:scheduler_hints` to the interfaces `NovaShowServer` and `NovaListServersDetails`.

### HuaweiCloud SDK ELB

- _Features_
    - Support the following interfaces:
        - `ListApiVersions`
        - `ListSecurityPolicies`
        - `CreateSecurityPolicy`
        - `ShowSecurityPolicy`
        - `UpdateSecurityPolicy`
        - `DeleteSecurityPolicy`
        - `ListSystemSecurityPolicies`
        - `ListQuotaDetails`
        - `ChangeLoadbalancerChargeMode`
        - `BatchUpdatePoliciesPriority`
        - `UpdateIpList`
        - `BatchDeleteIpList`
- _Bug Fix_
    - None
- _Change_
    - Remove the interface `ShowQuotaDefaults`.
    - Add the response parameters `flavor_sold_out` and `lcu` to the interfaces `ListFlavors` and `ShowFlavor`, and remove the response parameter `availability_zone_ids`.
    - Add the response parameter `members_per_pool` to the interface `ShowQuota`.
    - Add the request parameters `enc_certificate` and `enc_private_key` to the interfaces `CreateCertificate` and `UpdateCertificate`.
    - Add the response parameters `enc_certificate` and `enc_private_key` to the interfaces `ListCertificates` and `ShowCertificate`.
    - Add the request parameters `prepaid_options`, `autoscaling` and `id` to the interface `CreateLoadBalancer`.
    - Add the request parameters `elb_virsubnet_type` and `autoscaling` and the response parameters `autoscaling` and `ip_version` to the interface `ListLoadBalancers`.
    - Add the request parameters `elb_virsubnet_type` and `autoscaling` and the response parameters `loadbalancer_id`, `order_id`, `autoscaling` and `ip_version` to the interface `UpdateLoadBalancer`.
    - Add the response parameters `autoscaling` and `ip_version` to the interface `ShowLoadBalancer`.
    - Add the response parameters `id`, `type` and `provisioning_status` to the interface `ShowLoadBalancerStatus`.
    - Add the request parameters `security_policy_id` and `enhance_l7policy_enable` to the interface `CreateListener`.
    - Add the request parameters `enhance_l7policy_enable` and `member_instance_id` and the response parameters `security_policy_id`, `transparent_client_ip_enable` and `enhance_l7policy_enable` to the interface `ListListeners`.
    - Add the request parameters `enhance_l7policy_enable` and `member_instance_id` and the response parameters `security_policy_id`, `transparent_client_ip_enable` and `enhance_l7policy_enable` to the interface `UpdateListener`.
    - Add the response parameters `security_policy_id`, `transparent_client_ip_enable` and `enhance_l7policy_enable` to the interface `ShowListener`.
    - Add the request parameters `listener_id` and `member_instance_id` to the interface `ListPools`.
    - Add the request parameters `ip_version` and `member_type` and the response parameters `member_type` and `instance_id` to the interface `ListMembers`.
    - Add the response parameters `member_type` and `instance_id` to the interfaces `UpdateMember`, `ShowMember` and `ListAllMembers`.
    - Add the request parameters `priority`, `redirect_url_config`, `fixed_response_config` and `conditions` to the interface `CreateL7Policy`.
    - Add the request parameter `priority` and the response parameters `redirect_url_config` and `fixed_response_config` to the interface `ListL7Policies`.
    - Add the request parameters `priority`, `redirect_url_config`, `fixed_response_config` and `rules` and the response parameters `member_type` and `instance_id` to the interface `UpdateL7Policy`.
    - Add the response parameters `redirect_url_config` and `fixed_response_config` to the interface `ShowL7Policy`.
    - Add the request parameter `conditions` to the interface `CreateL7Rule`.
    - Add the response parameter `conditions` to the interfaces `ListL7Rules` and `ShowL7Rule`.
    - Add the request and response parameter `conditions` to the interface `UpdateL7Rule`.

### HuaweiCloud SDK FunctionGraph

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `ListVersionAliases` to the interface `ListVersionAliases`.
    - Update the request parameter `name` to required of the interfaces  `CreateDependency` and `UpdateDependency`.
    - Update the request parameters `name` and `content` to required of the interface `CreateEvent`.

### HuaweiCloud SDK KMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Update the request parameter `key_alias` to required of the interface `CreateKey`.
    - Update the request parameter `key_id` to required of the interfaces `EnableKey`, `CancelKeyDeletion`, `ListKeys`, `ListKeyDetail`, `ShowPublicKey`, `ListGrants`, `DeleteImportedKeyMaterial`, `EnableKeyRotation`, `DisableKeyRotation` and `ShowKeyRotationStatus`.
    - Update the request parameters `key_id` and `pending_days` to required of the interface `DeleteKey`.
    - Add the request parameter `enterprise_project_id` to the interface `ListKeys`.
    - Update the request parameter `random_data_length` to required of the interface `CreateRandom`.
    - Update the request parameters `key_id` and `datakey_length` to required of the interfaces `CreateDatakey` and `CreateDatakeyWithoutPlaintext`.
    - Update the request parameters `key_id`, `plain_text` and `datakey_plain_length` to required of the interface `EncryptDatakey`.
    - Update the request parameters `key_id`, `cipher_text` and `datakey_cipher_length` to required of the interface `DecryptDatakey`.
    - Update the request parameters `key_id` and `key_alias` to required of the interface `UpdateKeyAlias`.
    - Update the request parameters `key_id` and `key_description` to required of the interface `UpdateKeyDescription`.
    - Update the request parameters `key_id`, `grantee_principal` and `operations` to required of the interface `CreateGrant`.
    - Update the request parameters `key_id` and `grant_id` to required of the interfaces `CancelGrant` and `CancelSelfGrant`.
    - Update the request parameters `key_id` and `plain_text` to required of the interface `EncryptData`.
    - Update the request parameter `cipher_text` to required of the interface `DecryptData`.
    - Update the request parameters `key_id` and `wrapping_algorithm` to required of the interface `CreateParametersForImport`.
    - Update the request parameters `key_id`, `import_token` and `encrypted_key_material` to required of the interface `ImportKeyMaterial`.
    - Update the request parameters `key_id` and `rotation_interval` to required of the interface `UpdateKeyRotationInterval`.
    - Add the request parameter `sequence` to the interface `CreateKmsTag`.

# 3.0.67 2021-11-25

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `platformVersion` to the interface `ShowCluster`.
    - Add the enumeration values `RollingBack` and `RollbackFailed` to the request parameter `status` of the interface `ListClusters`.

### HuaweiCloud SDK DDS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `tags` to the interfaces `CreateInstance` and `ListInstances`.

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request and response parameter `alias` to the interfaces `CreatePrePaidPublicip` and `CreatePublicip`.
    - Add the response parameter `alias` to the interfaces `ShowPublicip` and `UpdatePublicip`.

### HuaweiCloud SDK KMS

- _Features_
    - Support the interfaces of version `V2`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK OCR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Remove the response parameter `extracted_data` of the interface `RecognizeHandwriting`.

### HuaweiCloud SDK TMS

- _Features_
    - Support the interface `ShowTagQuota`.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.66 2021-11-12

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `customSan` to the interface `UpdateNode`.

### HuaweiCloud SDK DDS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the response parameter of the interface `ListAuditLogs`: `total_count` -> `total_record`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `results` to the interface `ShowJob`.

### HuaweiCloud SDK OCR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `confidence` to the interface `RecognizeGeneralTable`.

### HuaweiCloud SDK ProjectMan

- _Features_
    - Support the interface `CreateSystemIssueV4`.
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `sequence` to the interface `ListIrs`.
    - Add the request parameter `status_id` to the interface `BatchUpdateIrs`.

### HuaweiCloud SDK VPC

- _Features_
    - Support interfaces(V3): `AddVpcExtendCidr`、`RemoveVpcExtendCidr`、`ListVpcs`、`ShowVpc`
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.65 2021-10-25

### HuaweiCloud SDK DNS

- _Features_
    - Support the interface `ShowDomainQuota`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `bandwidth_type` to the interface `CreateSharedBandwidth`.

### HuaweiCloud SDK FRS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `single` to the interfaces `AddFacesByFile`, `AddFacesByBase64` and `AddFacesByUrl`.

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the type of request and response parameters `num` and `size` of the interface `CreateInstance`: `integer` -> `string`.

### HuaweiCloud SDK ImageSearch

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the request parameter of the interface `RunSearchPicture`: `isCrop` -> `is_crop`
    - Add the request parameter `box` to the interface `RunSearchPicture`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `current_task`, `image_name` and `process_percent` to the interface `ShowJob`.

### HuaweiCloud SDK IoTDA

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `status` to the interface `ListDevices`.
    - Add the request parameter `file_path` to the interface `CreateRuleAction`.

### HuaweiCloud SDK OCR

- _Features_
    - Support the interfaces `RecognizeInsurancePolicy`, `RecognizeFinancialStatement` and `RecognizeQualificationCertificate`.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.64 2021-10-19

### HuaweiCloud SDK EIP

- _Features_
    - Support the following interfaces:
        - `ListCommonPools`
        - `ListPublicBorderGroups`
        - `ListPublicipPool`
        - `ShowPublicipPool`
        - `ListShareBandwidthTypes`
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `allow_share_bandwidth_type_any` to the interface `ListPublicips`.
    - Modify the type of the request parameter `limit` of the interface `NeutronListFloatingIps`.
    - Modify the name of the request body of the interface `NeutronUpdateFloatingIp`: `floatingip` -> `NeutronUpdateFloatingIpRequestBody`
    - Add the response parameter `allow_share_bandwidth_types` to the interface `ShowPublicip`.

# 3.0.63 2021-10-11

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Set the request parameter `reverse_binding` to `optional` of the interface `DisassociateServerVirtualIp`.

### HuaweiCloud SDK FRS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the optional value to `2,4,6,7,8,11,12,13,21` of the request parameter `attributes` of the interfaces `DetectFaceByFile`,`DetectFaceByBase64` and `DetectFaceByUrl`.

# 3.0.62 2021-09-29

### HuaweiCloud SDK DNS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the type of the response parameter `resource_detail` of the interface `ListTag`: `string` -> `object`
    - Modify the type of the response parameter `masters` of the interfaces `CreatePrivateZone`,`UpdatePublicZone` and `DeletePublicZone`: `string` -> `array`
    - Modify the type of the request parameter `ttl` of the interfaces `CreatePrivateZone` and `UpdatePublicZone`: `string` -> `integer`
    - Modify the type of the request parameters `limit` and `offset` of the interfaces `ListRecordSets`,`ListRecordSetsWithLine` and `ListRecordSetsByZone`: `string` -> `integer`
    - Add the response parameter `tags` to the interfaces `CreatePrivateZone`,`ListRecordSetsByZone`,`ShowRecordSetWithLine`,`ListPtrRecords` and `ListPublicZones`.

### HuaweiCloud SDK ECS

- _Features_
    - Support the following interfaces:
        - `ListServerTags`
        - `BatchAttachSharableVolumes`
        - `ShowServerAutoRecovery`
        - `BatchResetServersPassword`
        - `ReinstallServerWithoutCloudInit`
        - `ChangeServerOsWithoutCloudInit`
        - `BatchUpdateServersName`
        - `ShowServerPassword`
        - `AssociateServerVirtualIp`
        - `MigrateServer`
        - `ShowServerBlockDevice`
        - `DisassociateServerVirtualIp`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ProjectMan

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `id` and `name` to the interface `ListIssueRecordsV4`.
    - Add the response parameter `status` to the interface `ListProjectIterationsV4`.

# 3.0.61 2021-09-24

### HuaweiCloud SDK CCE

- _Features_
    - Support the interface `ShowQuotas`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK Classroom

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the optional request parameter `testcases` to the interface `ApplyJudgement`.

### HuaweiCloud SDK IVS

- _Features_
    - Support the service `Identity Verification Solution`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK SWR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `domain_id`, `scanned` and `tag_type` to the interface `ListRepositoryTags`.

# 3.0.60 2021-09-16

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `platformVersion` to the interface `ShowCluster`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the optional request parameter `__support_amd` to the interface `CreateDataImage`.
    - Add the response parameter `__support_amd` to the interface `ListImages`.

### HuaweiCloud SDK KMS

- _Features_
    - Support the interfaces `ShowPublicKey` and `Sign`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK OCR

- _Features_
    - Support the interface `RecognizeInvoiceVerification`.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.59 2021-09-10

### HuaweiCloud SDK CCE

- _Features_
    - Support the interfaces `AddNode` and `ResetNode`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK DDS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `status` and `fail_reason` to the interface `ShowJobDetail`.

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Set the request parameter `size` of the interface `CreateVolume` to `required`.

### HuaweiCloud SDK OCR

- _Features_
    - Support the interface `RecognizeInvoiceVerification`.
- _Bug Fix_
    - None
- _Change_
    - Add the optional request parameter `return_verification` to the interface `RecognizeIdCard`.

# 3.0.58 2021-08-31

### HuaweiCloud SDK FRS

- _Features_
    - Support the following interfaces:
        - `DetectLiveByUrl`
        - `DetectLiveFaceByUrl`
        - `DetectLiveByFile`
        - `DetectLiveFaceByFile`
        - `DetectLiveByBase64`
        - `DetectLiveFaceByBase64`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK SMN

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameters `enterprise_project_id`, `name` and `fuzzy_name` to the interface `ListTopics`.
    - Add the request parameters `protocol`, `status` and `endpoint` to the interface `ListSubscriptions`.

# 3.0.57 2021-08-25

### HuaweiCloud SDK DDS

- _Features_
    - Support the following interfaces:
        - `ShowJobDetail`
        - `SwitchSlowlogDesensitization`
        - `ListFlavorInfos`
        - `UpdateInstanceRemark`
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `job_id` to the interfaces `RestoreInstance`, `CreateManualBackup` and `RestoreInstanceFromCollection`.
    - Add the response parameter `remark` to the interface `ListInstances`.

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the following response parameters to the interface `ListServerInterfaces`:
        - `delete_on_termination`
        - `driver_mode`
        - `min_rate`
        - `multiqueue_num`
        - `pci_address`
    - Add the response parameters `cpu_options` and `hypervisor` to the interface `ListServersDetails`.

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request and response parameter `public_border_group` to the interface `BatchCreateSharedBandwidths`.
    - Add the response parameter `public_border_group` to the interface `AddPublicipsIntoSharedBandwidth`.

### HuaweiCloud SDK FRS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the interface: `AuthorizeFaceRecognitionService` -> `ShowSubscribes`.

### HuaweiCloud SDK FunctionGraph

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameters `function_urn` and `type` to the interface `ExportFunction`.
    - -The optional value of the request parameter `filter` of the interface `ListStatistics` is modified to [`monitor_data`, `monthly_report`]

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
    - Support the following interfaces:
        - `ListDedicatedResources`
        - `ListFlavorInfos`
        - `ListConfigurationTemplates`
        - `ListInstancesByResourceTags`
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `dedicated_resource_id` to the interface `CreateInstance`.
    - Add the response parameter `dedicated_resource_id` to the interface `ListInstances`.

### HuaweiCloud SDK ImageSearch

- _Features_
    - Support the service `ImageSearch`.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.56 2021-08-17

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the following response parameters to the interface `ListNodePools`:
        - `annotations`
        - `updateTimestamp`
        - `creationTimestamp`
        - `creatingNode`
        - `deletingNode`
        - `conditions`
        - `enterprise_project_id`
    - Add the response parameters `orderID` and `upgradefrom` to the interface `ListClusters`.

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `ecs:instance_architecture` to the interface `ListServerResizeFlavors`.
    - Add the request parameters `tenancy` and `dedicated_host_id` to the interface `NovaCreateServers`.

### HuaweiCloud SDK ELB

- _Features_
    - None
- _Bug Fix_
    - Fix the problem of abnormal creation of LB.
- _Change_
    - None

# 3.0.55 2021-08-10

### HuaweiCloud SDK AS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the request parameters `key` and `value` of the interface `ListResourceInstances` as required parameters.

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the response parameter of the interfaces `ListBandwidths` and `ShowPublicip`: `publicip_border_group` -> `public_border_group`

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `server_id` to the interface `ListVolumes`.

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Remove the response parameter `order_id` from the interface `CreateDeployment`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the request parameter `value` of the interface `UpdateImage` as a required parameter.

### HuaweiCloud SDK Kafka

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `new_partition_numbers` to the interface `UpdateInstanceTopic`.

### HuaweiCloud SDK SWR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the following response parameters to the interface `ShowAccessDomain`:
        - `namespace`
        - `repository`
        - `access_domain`
        - `permit`
        - `deadline`
        - `description`
        - `creator_id`
        - `creator_name`
        - `created`
        - `updated`
        - `status`

### HuaweiCloud SDK VOD

- _Features_
    - Support the service `Video on Demand`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK VPC

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `enable_dhcp` to the interface `NeutronListSubnets`.
    - Add the response parameter `security_groups_links` to the interface `NeutronListSecurityGroups`.

# 3.0.54 2021-07-27

### HuaweiCloud SDK Classroom

- _Features_
    - Support the interfaces `ApplyJudgement`,`ShowJudgementDetail`,`ShowJudgementFile`.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.53 2021-07-26

### HuaweiCloud SDK DCS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `dcs_cluster_proxy2_node` to the interface `UpdateConfigurations`.

### HuaweiCloud SDK DDS

- _Features_
    - Support the interface `UpdateClientNetwork`.
- _Bug Fix_
    - None
- _Change_
    - Change the request parameters `start_time`,`stop_time` from `optional` to `required` of the interface `SetBalancerWindow`.
    - Add the request parameter `port` and response parameter `port` to the interface `CreateInstance`.

### HuaweiCloud SDK FunctionGraph

- _Features_
    - Support the interface `EnableLtsLogs`.
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `concurrent_num`,`id`,`encrypted_user_data`.
    - Add the response parameters `func_vpc_id`,`encrypted_user_data`,`long_time`,`log_group_id`,`log_stream_id`,`type` to the interface `ListFunctions`, and remove the response parameters `version_description`,`last_modified_utc`,`dependencies` of this interface.
    - Remove the request parameter `name`,`last_modified`,`alias_urn` of the interface `UpdateVersionAlias`.
    - Add the response parameters `encrypted_user_data`,`long_time`,`log_group_id`,`log_stream_id`,`type` of the interface `ShowFunctionConfig`, and remove the response parameters `version_description`,`concurrency` of this interface.
    - Add the response parameters `encrypted_user_data`,`long_time`,`log_group_id`,`log_stream_id`,`type` to the interface `ListFunctionVersions`, and remove the response parameters `version_description`,`concurrency`,`depend_list`.
    - Add the response parameters `encrypted_user_data`,`long_time`,`log_group_id`,`log_stream_id`,`type` to the interface `ListFunctionVersions`, remove the response parameters `last_modified_utc`,`concurrency`.
    - Modify the type of the request parameter `size` of the interface `UpdateTrigger`: `string`->`integer`
    - Modify the type of the response parameter `size` of the interface `ShowDependency`: `string`->`integer`
    - Modify the type of the response parameter `size` of the interface `UpdateDependency`: `string`->`integer`

# 3.0.52 2021-07-16

### HuaweiCloud SDK AS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `description` to the interface `CreateScalingV2Policy`.
    - Add the response parameter `description` to the interfaces `ShowScalingV2Policy`, `ShowScalingGroup`.

### HuaweiCloud SDK DCS

- _Features_
    - Support more interfaces:
        - `CreateDiagnosisTask`
        - `CreateRedislog`
        - `CreateRedislogDownloadLink`
        - `ListDiagnosisTasks`
        - `ListRedislog`
        - `ListSlowlog`
        - `ShowDiagnosisTaskDetails`
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `include_delete` to the interface `ListInstances`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - [Issue 40](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/40): Fix the issue that the type of the response parameter `__lazyloading` is incorrectly defined.
- _Change_
    - None

# 3.0.51 2021-07-09

### HuaweiCloud SDK BMS

- _Features_
    - None
- _Bug Fix_
    - Fix the issue that the data structure of the response parameter `addresses` of the interface `ListBareMetalServers` is incorrectly defined.
- _Change_
    - None

### HuaweiCloud SDK CBR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `smn_notify`,`threshold` to the interface `ListProtectable`.
    - Add the request parameter `add_policy_ids` and the response parameters `without_any_tag`,`smn_notify`,`threshold` to the interface `AssociateVaultPolicy`.

### HuaweiCloud SDK CCE

- _Features_
    - Support the interfaces `RemoveNode`,`MigrateNode`.
- _Bug Fix_
    - None
- _Change_
    - Add the request parameter `tobedeleted` to the interface `DeleteCluster`.

### HuaweiCloud SDK DNS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the type of the response parameters `masters`, `zones` of the interface `CreatePublicZone`: `string`->`array`

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameter `publicip_border_group` to the interfaces `CreateSharedBandwidth`,`ListBandwidths`.

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `__root_origin`,`checksum`,`size` to the interfaces `GlanceCreateImageMetadata`.
    - Remove the request parameters `deleted`, `deleted_at` of the interface `GlanceAddImageMember`, and add the following request parameters:
        - `__lazyloading`
        - `__os_feature_list`
        - `__root_origin`
        - `__sequence_num`
        - `__support_agent_list`
        - `__system__cmkid`
        - `active_at`
        - `hw_vif_multiqueue_enabled`
        - `max_ram`
        - `__image_location`
        - `__is_config_init`
        - `__account_code`

### HuaweiCloud SDK IoTDA

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `edge_node_ids`, `last_update_time` to the interface `ListRules`.

### HuaweiCloud SDK SWR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the response parameters `domain_id`,`priority` to the interface `ShowRepository`.
    - Add the response parameter `template` to the interface `CreateRetention`.

# 3.0.50 2021-06-29

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add a request parameter `storage` to interfaces `CreateNodePool`,`ShowNodePool`,`UpdateNodePool`,`DeleteNodePool`.

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the type of the response parameter `port` of the interface `ListInstances`: `string`->`integer`.
    - Modify the name of response parameter of the interface `ListInstances`: `storage_engine`->`mode`
    - Remove a response parameter `node_name` and add a response parameter `time` to the interface `ListSlowLogs`.

### HuaweiCloud SDK NAT

- _Features_
    - None
- _Bug Fix_
    - Fix the issue that the request parameter `project_id` of the interface `ListNatGateways` is duplicated.
- _Change_
    - None

# 3.0.49 2021-06-25

### HuaweiCloud SDK BMS

- _Features_
    - Support interface `ChangeBaremetalServerOs`.
- _Bug Fix_
    - None
- _Change_
    - Modify the name of reponse parameter of interface `ChangeBaremetalServerName`: `server_tags`->`sys_tags`.

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add request parameters`permission_type`,`display_name`,`catalog`,`type` of interface `KeystoneListPermissions`.

# 3.0.48 2021-06-21

### HuaweiCloud SDK BMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add response parameters `server_tags`,`enterprise_project_id`,`group` to interface `ChangeBaremetalServerName`.

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - [Issue 22](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/22): Modify the optional value of response parameter `status` of interface `ListAddonInstances`.
- _Change_
    - None

### HuaweiCloud SDK Kafka

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the type of response parameter `partitions` of interface `ShowGroups`: `array[string]` -> `array[integer]`

### HuaweiCloud SDK RabbitMQ

- _Features_
    - None
- _Bug Fix_
    - Fix the issue of compilation failure.
- _Change_
    - None

# 3.0.47 2021-06-10

### HuaweiCloud SDK FunctionGraph

- _Features_
    - Support interfaces
        - `ImportFunction`
        - `ExportFunction`
        - `AsyncInvokeReservedFunction`
        - `DeleteReservedInstanceById`
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.46 2021-06-04

### HuaweiCloud SDK CCE

- _Features_
    - None
- _Bug Fix_
    - [Issue 20](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/20): Fix the issue that the type of `extendParam`
      is defined incorrectly.
- _Change_
    - Add the request parameter `tobedeleted` to the interface `DeleteCluster`.

### HuaweiCloud SDK DDS

- _Features_
    - Support the interface `ShowQuotas`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IoTDA

- _Features_
    - Support interface `ListComplexQueryDevice`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK GaussDBforNoSQL

- _Features_
    - Support `GaussDBforNoSQL` service.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.45 2021-05-25

### HuaweiCloud SDK AS

- _Features_
    - Support more interfaces:
        - `ListApiVersions`
        - `ShowApiVersion`
        - `BatchProtectScalingInstances`
        - `BatchRemoveScalingInstances`
        - `CreateScalingTagInfo`
        - `BatchResumeScalingPolicies`
        - `BatchPauseScalingPolicies`
        - `PauseScalingGroup`
        - `BatchSetScalingInstancesStandby`
        - `BatchUnsetScalingInstancesStandby`
        - `ResumeScalingPolicy`
        - `PauseScalingPolicy`
- _Bug Fix_
    - None
- _Change_
    - Modify the operation name of the following interfaces:
        - from `ExecuteScalingPolicies` to `BatchDeleteScalingPolicies`
        - from `EnableOrDisableScalingGroup` to `ResumeScalingGroup`
        - from `UpdateScalingGroupInstance` to `BatchAddScalingInstances`
        - from `CompleteLifecycleAction` to `AttachCallbackInstanceLifeCycleHook`
    - Remove the interface: `DeleteScalingTags`
    - Add the parameter `enterprise_project_id` to the interface `ListScalingGroups`.
    - Add the parameter `log_id` to the interface `ListScalingActivityV2Logs`.

### HuaweiCloud SDK DMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of interface from `ShowProjectTags` to `ShowQueueProjectTags`.

### HuaweiCloud SDK EPS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Change request parameter `offset` of interface `ListEnterpriseProject` from required to optional.

### HuaweiCloud SDK FunctionGraph

- _Features_
    - Support more interfaces:
        - `ListFunctionAsyncInvokeConfig`
        - `ShowFunctionAsyncInvokeConfig`
        - `DeleteFunctionAsyncInvokeConfig`
        - `UpdateFunctionAsyncInvokeConfig`
- _Bug Fix_
    - None
- _Change_
    - Modify the name of request parameter of interfaces `DeleteVersionAlias`,`UpdateVersionAlias`
      ,`ShowVersionAlias`: `name` -> `alias_name`
    - Modify the name of request parameter of interfaces `DeleteFunctionTrigger`,`UpdateTrigger`
      ,`ShowFunctionTrigger`: `triggerId` -> `trigger_id`

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the parameter `access_mode` to interface `CreateUsers`.
    - Change the parameter `authentication_code` of interface `DeleteBindingDevice` from required to optional.

### HuaweiCloud SDK Kafka

- _Features_
    - Support more interfaces:
        - `CreateInstanceUser`
        - `BatchDeleteInstanceUsers`
        - `ShowInstanceUsers`
        - `ShowTopicAccessPolicy`
        - `UpdateTopicAccessPolicy`
        - `ShowKafkaTopicPartitionDiskusage`
        - `ShowInstanceMessages`
        - `ResetUserPassword`
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the interface:
        - from `ShowInstanceTags` to `ShowKafkaTags`
        - from `ShowProjectTags` to `ShowKafkaProjectTags`
        - from `BatchCreateOrDeleteInstanceTag` to `BatchCreateOrDeleteKafkaTag`
    - Modify the request body name of the interface:
        - from `BatchCreateOrDeleteInstanceTagRequestBody` to `BatchCreateOrDeleteKafkaTagRequestBody`
    - Modify the data type of parameter `sink_max_tasks` in the request body of interface `UpdateSinkTaskQuota` from
      String to Integer.

### HuaweiCloud SDK RabbitMQ

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the name of the following interfaces:
        - from `BatchCreateOrDeleteInstanceTag` to `BatchCreateOrDeleteRabbitMqTag`;
        - from `ShowProjectTags` to `ShowRabbitMqProjectTags`;
        - from `ShowInstanceTags` to `ShowRabbitMqTags`.
    - Modify the request body name of interface `BatchCreateOrDeleteInstanceTag`
      from `BatchCreateOrDeleteInstanceTagRequestBody` to
      `BatchCreateOrDeleteRabbitMqTagRequestBody`.

# 3.0.43-rc 2021-05-14

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - Solve the issue of abnormal parsing result when using interface `NovaShowKeypair` to obtain the secret key.
- _Change_
    - None

# 3.0.42-rc 2021-05-10

### HuaweiCloud SDK BMS

- _Features_
    - Support interface `BatchCreateBaremetalServerTags`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK DDS

- _Features_
    - Support interfaces `MigrateAz`, `ListAz2Migrate`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK EPS

- _Features_
    - None
- _Bug Fix_
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/17): Fix the issue that `EpDetailType` enum
      is defined incorrectly.
- _Change_
    - None

### HuaweiCloud SDK KPS

- _Features_
    - None
- _Bug Fix_
    - [Issue 19](https://github.com/huaweicloud/huaweicloud-sdk-go-v3/issues/19): Fix the issue of type of response body
      in `ListKeypairs`.
- _Change_
    - None

# 3.0.41-rc 2021-04-30

### HuaweiCloud SDK DDS

- _Features_
    - Support interfaces:
        - `ShowShardingBalancer`
        - `SetBalancerSwitch`
        - `SetBalancerWindow`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add optional values to request parameter `type` of the interface `ShowDomainQuota`:
        - `assigment_group_mp`
        - `assigment_agency_mp`
        - `assigment_group_ep`
        - `assigment_user_ep`

### HuaweiCloud SDK IoTDA

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Remove interfaces:
        - `ListSubscriptions`
        - `CreateSubscription`
        - `UpdateSubscription`
        - `ShowSubscription`
        - `DeleteSubscription`

### HuaweiCloud SDK ProjectMan

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add a field `project_code` to response body of the interface `ShowProjectInfoV4`.

# 3.0.40-rc 2021-04-15

### HuaweiCloud SDK DDS

- _Features_
    - Support more interfaces `DeleteDatabaseUser`,`DeleteDatabaseRole`,`ShowConnectionStatistics`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ProjectMan

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add fields `closed_time` ,`id` ,`created_time` to reponse body of interfaces `ListIssuesV4`, `ListChildIssuesV4`.

### HuaweiCloud SDK VPC

- _Features_
    - None
- _Bug Fix_
    - Fix the bug, open the tags of the VPC and subnet.
- _Change_
    - None

# 3.0.39-rc 2021-03-30

### HuaweiCloud SDK Kafka

- _Features_
    - None
- _Bug Fix_
    - Fix the issue that the interface for querying messages does not contain the timestamp field.
- _Change_
    - None

### HuaweiCloud SDK ProjectMan

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add the attribute `name` to the response body `IssueResponseV4` of the interfaces `ShowIssueV4`
      and `UpdateIssueV4`.
    - Change the attribute `work_time` to `work_date` in `ShowProjectWorkHoursResponseBody` in the response body of the
      interfaces `ShowProjectWorkHours` and `ListProjectWorkHours`.

### HuaweiCloud SDK SMN

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Change the request parameter `protocol`  of the interface `PublishMessage`  from mandatory to optional.
    - Change the attribute `subject`  of the class `PublishMessageRequestBody` in the request body of the
      interface `PublishMessage`  from mandatory to optional.

# 3.0.38-rc 2021-03-26

### HuaweiCloud SDK SMN

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Change the property `protocol` in `ListMessageTemplates` from required to optional.

# 3.0.37-rc 2021-03-19

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - Fix the problem of deserialization failure of response body of interface `ListFlavors`.
- _Change_
    - None

# 3.0.36-rc 2021-03-16

### HuaweiCloud SDK EIP

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Add request field `enterprise_project_id` in interface `CreatePrePaidPublicip`.

### HuaweiCloud SDK ProjectMan

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that the SDK can not be used.
- _Change_
    - None

# 3.0.35-rc 2021-03-15

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - If the `endpoint` input by the user does not contain a protocol prefix, the `https` prefix will be automatically
      added.

### HuaweiCloud SDK CES

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Class adjustment in interface `CreateAlarmRequestBody`: change class definition of property `metric`
      from `MetricInfoForAlarm` to `MetricForAlarm`.

### HuaweiCloud SDK DDS

- _Features_
    - Support more interfaces:
        - `RestoreNewInstance`
        - `ListSessions`
        - `DeleteSession`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ECS

- _Features_
    - Support more interface: `ShowServerGroup`.
- _Bug Fix_
    - None
- _Change_
    - Change the interface name from `ShowWindowsServerPassword` to `ShowServerPassword`.
    - Change the interface name from `DeleteWindowsServerPassword` to `DeleteServerPassword`.

### HuaweiCloud SDK ELB

- _Features_
    - Support more interface: `ListAllMembers`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - Support more interfaces:
        - `KeystoneShowIdentityProvider`
        - `KeystoneCreateIdentityProvider`
        - `KeystoneUpdateIdentityProvider`
        - `KeystoneDeleteIdentityProvider`
        - `CreateTokenWithIdToken`
- _Bug Fix_
    - None
- _Change_
    - Do not support interface `CreateUnscopeTokenByIdpInitiated` anymore.

### HuaweiCloud SDK IMS

- _Features_
    - Support more interfaces:
        - `ListImageByTags` which mead list images queried by tags.
        - `ListImagesTags` which means list all tags of all images in current account.
        - `ListImageTags` which means list all tags of specified image.
        - `AddImageTag`
        - `DeleteImageTag`
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ProjectMan

- _Features_
    - Support more interfaces:
        - `CreateCustomfields`
        - `ShowBugsPerDeveloper`
        - `ShowCompletionRate`
        - `ShowBugDensityV2`
        - `ShowProjectInfoV4`
- _Bug Fix_
    - Change the incorrect name of interface from `ShowtIssueCompletionRate` to `ShowIssueCompletionRate`.
- _Change_
    - Change the data type of property `created_time` and `updated_time` in class `ListProjectV4ResponseBody` from
      string to long?.

# 3.0.34-rc 2021-02-27

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Optimize the description of `README` and the format of `CHANGELOG`.

### HuaweiCloud SDK BMS

- _Features_
    - None
- _Bug Fix_
    - Correct operation name from `WindowsBaremetalServerCleanPwd` to `DeleteWindowsBareMetalServerPassword`.
- _Change_
    - None

### HuaweiCloud SDK BSS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - All properties with type `decimal?` have been changed to `double?`.

### HuaweiCloud SDK CES

- _Features_
    - None
- _Bug Fix_
    - Fix the problem of circular dependency in the `CreateAlarmResponse` class.
- _Change_
    - None

### HuaweiCloud SDK DDS

- _Features_
    - Support more interfaces: `DownloadSlowlog` and `DownloadErrorlog`.
- _Bug Fix_
    - Correct operation name from `ModifyConfigurationParameter` to `UpdateConfigurationParameter`, change the class
      name of this operation from `ModifyConfigurationParameterRequestBody` to `UpdateConfigurationParameterRequestBody`
      .
- _Change_
    - None

### HuaweiCloud SDK ELB

- _Features_
    - None
- _Bug Fix_
    - Correct operation name from `ListMenbers` to `ListMembers`.
- _Change_
    - None

### HuaweiCloud SDK EPS

- _Features_
    - None
- _Bug Fix_
    - Correct operation name from `ModifyEnterpriseProject` to `UpdateEnterpriseProject`.
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - Correct property from `pwd_stength` to `pwd_strength` in class `KeystoneUserResult`.
- _Change_
    - None

### HuaweiCloud SDK IoTDA

- _Features_
    - Offline the following interfaces:
        - CreateAppCertificate
        - ListAppCertificates
        - ShowAppCertificate
        - UpdateAppCertificate
        - DeleteAppCertificate
- _Bug Fix_
    - None
- _Change_
    - Hide the internal fields `Sp-Auth-Token` and `Stage-Auth-Token` of all interfaces which doesn't affect actual use
      in SDK.

### HuaweiCloud SDK SWR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Change the data type of property `size` from `int?` to `long?`.

# 3.0.33-rc 2021-02-07

### HuaweiCloud SDK IMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Interface `ListOsVersions` adjustment: change the data type of `os_bit` which is the property of response of the
      interface from string to integer.

### HuaweiCloud SDK IoTDA

- _Features_
    - Support more interfaces: ListAsyncCommands, ListAsyncHistoryCommands, CreateAppCertificate, ListAppCertificates,
      ShowAppCertificate, UpdateAppCertificate, DeleteAppCertificate
- _Bug Fix_
    - None
- _Change_
    - SDK of interface `DeviceManagement` deprecated.(It's not supported any more in SDK, but you can also using it by
      customized coding using API.)

# 3.0.32-rc 2021-01-30

### HuaweiCloud SDK DNS

- _Features_
    - Support `Domain Name Service`.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Change interface name from `UpdateAutoTerminateTimeServer` to `UpdateServerAutoTerminateTime`.

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Interface `CinderCreateVolume` is supported to specify the id of dedicated storage pool using
      property `OS-SCH-HNT:scheduler_hints`.
    - Modify property type of `allocated` of class `QuotaDetails` from `String` to `Integer`.

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Increases the property `access_mode` of response class of interface `ShowUser`.

# 3.0.31-rc 2021-01-25

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - The default value of `Timeout` is set to 120 seconds.

### HuaweiCloud SDK BSS

- _Features_
    - Support more interface: ListOrderDiscounts.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ECS

- _Features_
    - Support more interface: UpdateAutoTerminateTimeServer.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.30-rc 2021-01-15

### HuaweiCloud SDK Core

- _Features_
    - Support function `ValueOf` to get region information.
- _Bug Fix_
    - Fix response exception when using temporary AK/SK.
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Modify the data type of response field `is_domain_owner` from string to boolean of interface `ShowUser`
      and `CreateUser`.

### HuaweiCloud SDK SWR

- _Features_
    - Support `Software Repository for Container` service.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.29-beta 2020-12-31

### HuaweiCloud SDK DCS

- _Features_
    - None
- _Bug Fix_
    - Modify the interface return data type to prevent deserialization failure:
        - ListSlowlog: change data type of `Tags` from Tag to ResourceTag.
        - ListInstances: change data type of `duration` from int32 to string.
        - ShowBigkeyScanTaskDetails: change data type of `db` from int32 to string.
        - ShowHotkeyTaskDetails: change data type of `db` from int32 to string.
- _Change_
    - None

### HuaweiCloud SDK SMN

- _Features_
    - None
- _Bug Fix_
    - Modify the request parameters of interface `PublishMessage` from Object to Map<String, String>
- _Change_
    - None

# 3.0.28-beta 2020-12-28

### HuaweiCloud SDK DCS

- _Features_
    - None
- _Bug Fix_
    - Change property type of `port` from string to integer.
- _Change_
    - None

# 3.0.27-beta 2020-12-25

### HuaweiCloud SDK DCS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Query parameter in interface `ListInstances` modification: id → instance_id.

# 3.0.26-beta 2020-12-23

### HuaweiCloud SDK Core

- _Features_
    - Support Endpoint Resolver: it's supported to use {Service}Region when initializing {ServiceClient} which can
      automatically backfill endpoint. After choosing a region, the projectId/domainId will be backfilled automatically.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK BSS

- _Features_
    - Support more interfaces: ListMeasureUnits.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK CES

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Update interface: ShowMetricData

### HuaweiCloud SDK SMN

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Update field type in message_template_name.

# 3.0.25-beta 2020-12-15

### HuaweiCloud SDK CCE

- _Features_
    - Support Cloud Container Engine service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ELB

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that sending request to interface `CreateListener` returns empty response.
    - Fix the problem that sending request to interface `CreateListener` returns response with wrong type.
- _Change_
    - None

### HuaweiCloud SDK NAT

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that using interface `BatchCreateNatGatewayDnatRules` failed.
- _Change_
    - None

# 3.0.24-beta 2020-12-04

### HuaweiCloud SDK SMN

- _Features_
    - Support Simple Message Notification service.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.23-beta 2020-11-30

### HuaweiCloud SDK BMS

- _Features_
    - Support Bare Metal Server service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK BSS

- _Features_
    - Support more interfaces: ListUsageTypes, ModPeriodToOnDemand.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK CBR

- _Features_
    - Support more interfaces: MigrateVaultResource.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK CES

- _Features_
    - Support more interfaces:
        - ListEvents
        - ListEventDetail
        - CreateResourceGroup
        - UpdateResourceGroup
        - DeleteResourceGroup
        - ListResourceGroup
        - UpdateAlarm
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - [Issue 21](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/21) Open related interface.

### HuaweiCloud SDK IAM

- _Features_
    - Support more interfaces.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.22-beta 2020-11-17

### HuaweiCloud SDK DMS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Type of property adjustment: type of property `created` and type of `eff_date` are changed from `string`
      to `integer64`.

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Property adjustment:  increase property `dry_run` in interfaces `CreatePostPaidServers` and `CreateServers` which
      means whether parameters will be checked before sending real requests.

### HuaweiCloud SDK NAT

- _Features_
    - Support NAT Gateway service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK Kafka

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Name of interface adjustment: UpdateInstanceCrossVPCIP → UpdateInstanceCrossVpcIp

### HuaweiCloud SDK VPC

- _Features_
    - Support more interfaces: interfaces related to Network ACLs.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.21-beta 2020-11-11

### HuaweiCloud SDK CBR

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Interface adjustment: property `object_type` in interface `CreateVault` support key `turbo`.
    - Interface adjustment: property `description` in interface `UpdatePolicy` is removed.

### HuaweiCloud SDK CES

- _Features_
    - Add examples of interface response and adjust some filed description.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.20-beta 2020-11-02

### HuaweiCloud SDK CES

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Interface adjustment: property `alarm_type` in class `CreateAlarmRequestBody` support key `RESOURCE_GROUP`.
    - Interface adjustment: property `meta_data` in class `ListAlarmHistoriesResponse` only returns total number of
      alarm histories.

### HuaweiCloud SDK ELB

- _Features_
    - None
- _Bug Fix_
    - Modify wrong parameter in class `CreateL7ruleRequestBody`.
- _Change_
    - None

# 3.0.19-beta 2020-10-31

### HuaweiCloud SDK CBR

- _Features_
    - Support more interfaces: interfaces related to `TAG`.
- _Bug Fix_
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/17) fix the problem of interface:
      ListBackups.
- _Change_
    - None

### HuaweiCloud SDK CTS

- _Features_
    - Support more interface: ListQuotas
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Adjust interfaces' names, the involved interfaces are:
        1. KeystoneCreateUserTokenByPasswordAndMFA → KeystoneCreateUserTokenByPasswordAndMfa
        2. CreateUnscopeTokenByIDPInitiated → CreateUnscopeTokenByIdpInitiated

### HuaweiCloud SDK ProjectMan

- _Features_
    - Support more interfaces: iteration information, user information, project members, project information, project
      indicators, project statistics, etc.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.18-beta 2020-10-20

### HuaweiCloud SDK DCS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Remove redundant `Dcs` in interfaces.

### HuaweiCloud SDK ELB

- _Features_
    - Support more interfaces of version v2.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IoTDA

- _Features_
    - Support more interfaces related to rules.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.17-beta 2020-10-14

### HuaweiCloud SDK BSS

- _Features_
    - Partner center supports exporting product catalog prices.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK DCS

- _Features_
    - Support more interfaces.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.16-beta 2020-10-12

### HuaweiCloud SDK CTS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Delete deprecated interfaces of version v1.

# 3.0.15-beta 2020-09-30

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that the value type of integer enumeration is incorrect when sending HTTP request.
- _Change_
    - None

### HuaweiCloud SDK CBR

- _Features_
    - Support Cloud Backup and Recovery service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK EIP

- _Features_
    - Support Elastic IP service.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.14-beta 2020-09-24

### HuaweiCloud SDK BSS

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that the class `BssClient` cannot be loaded.
- _Change_
    - None

# 3.0.13-beta 2020-09-16

### HuaweiCloud SDK ECS

- _Features_
    - None
- _Bug Fix_
    - Fix parameter type of interfaces.
- _Change_
    - None

### HuaweiCloud SDK BSS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Update interfaces.

# 3.0.12-beta 2020-09-11

# 3.0.11-beta 2020-09-09

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - Delete redundant Sidecar code in the repository.
- _Change_
    - None

### HuaweiCloud SDK DMS

- _Features_
    - Support Distributed Message Services, provide Kafka premium instances and RabbitMQ premium instances with
      dedicated resources.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK VPC

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that security group related interfaces have wrong data type.
- _Change_
    - None

# 3.0.10-beta 2020-09-04

### HuaweiCloud SDK Core

- _Features_
    - None
- _Bug Fix_
    - Fix the problem that the enumeration code cannot be generated for integer enumeration parameters without format
      defined in yaml.
- _Change_
    - Modify User Agent of Http Request header.

# 3.0.9-beta 2020-08-28

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - APIs ListVolumesByTags, solve the problem of type definition error of field `total_count`.
- _Change_
    - None

### HuaweiCloud SDK IAM

- _Features_
    - Support more APIs: consistency of console related APIs.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK IoTDA

- _Features_
    - Support more APIs: batch operation related APIs and asynchronous related APIs.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ProjectMan

- _Features_
    - Support Project Management service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK VPC

- _Features_
    - Support more APIs: security group, security group rules, available IP count related APIs.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.8-beta 2020-8-14

### HuaweiCloud SDK Core

- _Features_
    - Support temporary AK/SK authentication mode.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK BSS

- _Features_
    - Support Business Support System service.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK KMS

- _Features_
    - Support temporary Key Management Service.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.7-beta 2020-07-30

### HuaweiCloud SDK Core

- _Features_
    - Support file upload and download
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK ECS

- _Features_
    - Publish new interfaces, such as ChangeServerOs and ResetServerPassword.
- _Bug Fix_
    - None
- _Change_
    - None

### HuaweiCloud SDK VPC

- _Features_
    - Support interfaces of version v3.
- _Bug Fix_
    - None
- _Change_
    - None

# 3.0.6-beta 2020-07-15

### HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - [Issue #3](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/3): Fix call error of interface
      ShowVolume.
- _Change_
    - None

## HuaweiCloud SDK IAM

- _Features_
    - None
- _Bug Fix_
    - Fix parsing failure of response body of interface keystoneListVersions.
- _Change_
    - None

## HuaweiCloud SDK IoTDA

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Support related interfaces of application management.

# 3.0.5-beta 2020-06-30

## HuaweiCloud SDK Core

- _Features_
    - Support async client.
    - Support users to customize the request log output in the troubleshooting scenario.
- _Bug Fix_
    - None
- _Change_
    - None

## HuaweiCloud SDK CTS

- _Features_
    - Support Cloud Trace Service.
- _Bug Fix_
    - None
- _Change_
    - None

## HuaweiCloud SDK EVS

- _Features_
    - None
- _Bug Fix_
    - None
- _Change_
    - Support full service interface.

## HuaweiCloud SDK IoTDA

- _Features_
    - Support IoT Device Access Service.
- _Bug Fix_
    - None
- _Change_
    - None