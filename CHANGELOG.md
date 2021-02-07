## 3.0.33-rc 2021-02-07
## HuaweiCloud SDK IMS
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - Interface `ListOsVersions` adjustment: change the data type of `os_bit` which is the property of response of the interface from string to integer.

## HuaweiCloud SDK IoTDA
- ### Features
    - Support more interfaces: ListAsyncCommands, ListAsyncHistoryCommands, CreateAppCertificate, ListAppCertificates, ShowAppCertificate, UpdateAppCertificate, DeleteAppCertificate
- ### Bug Fix
    - None
- ### Change
    - SDK of interface `DeviceManagement` deprecated.(It's not supported any more in SDK, but you can also using it by customized coding using API.)


# 3.0.32-rc 2021-01-30
## HuaweiCloud SDK DNS
- ### Features
    - Support `Domain Name Service`.
- ### Bug Fix
    - None
- ### Change
    - None

## HuaweiCloud SDK ECS
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - Change interface name from `UpdateAutoTerminateTimeServer` to `UpdateServerAutoTerminateTime`.

## HuaweiCloud SDK EVS
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - Interface `CinderCreateVolume` is supported to specify the id of dedicated storage pool using property `OS-SCH-HNT:scheduler_hints`.
    - Modify property type of `allocated` of class `QuotaDetails` from `String` to `Integer`.

## HuaweiCloud SDK IAM
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - Increases the property `access_mode` of response class of interface `ShowUser`.


## 3.0.31-rc 2021-01-25
## HuaweiCloud SDK Core
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - The default value of `Timeout` is set to 120 seconds.

## HuaweiCloud SDK BSS
- ### Features
    - Support more interface: ListOrderDiscounts.
- ### Bug Fix
    - None
- ### Change
    - None

## HuaweiCloud SDK ECS
- ### Features
    - Support more interface: UpdateAutoTerminateTimeServer.
- ### Bug Fix
    - None
- ### Change
    - None


## 3.0.30-rc 2021-01-15
## HuaweiCloud SDK Core
- ### Features
    - Support function `ValueOf` to get region information.
- ### Bug Fix
    - Fix response exception when using temporary AK/SK.
- ### Change
    - None

## HuaweiCloud SDK IAM
- ### Features
    - None
- ### Bug Fix
    - None
- ### Change
    - Modify the data type of response field `is_domain_owner` from string to boolean of interface `ShowUser` and `CreateUser`.

## HuaweiCloud SDK SWR
- ### Features
    - Support `Software Repository for Container` service.
- ### Bug Fix
    - None
- ### Change
    - None


## 3.0.29-beta 2020-12-31
## HuaweiCloud SDK DCS
 - ### Features
    - None
 - ### Bug Fix
    - Modify the interface return data type to prevent deserialization failure: 
        - ListSlowlog: change data type of `Tags` from Tag to ResourceTag.
        - ListInstances: change data type of `duration` from int32 to string.
        - ShowBigkeyScanTaskDetails: change data type of `db` from int32 to string.
        - ShowHotkeyTaskDetails: change data type of `db` from int32 to string.
 - ### Change
    - None

## HuaweiCloud SDK SMN
 - ### Features
    - None
 - ### Bug Fix
    - Modify the request parameters of interface `PublishMessage` from Object to Map<String, String>
 - ### Change
    - None

## 3.0.28-beta 2020-12-28
## HuaweiCloud SDK DCS
 - ### Features
    - None
 - ### Bug Fix
    - Change property type of `port` from string to integer.
 - ### Change
    - None


## 3.0.27-beta 2020-12-25
## HuaweiCloud SDK DCS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Query parameter in interface `ListInstances` modification: id → instance_id.


## 3.0.26-beta 2020-12-23
## HuaweiCloud SDK Core
 - ### Features
    - Support Endpoint Resolver: it's supported to use {Service}Region when initializing {ServiceClient} which can automatically backfill endpoint. After choosing a region, the projectId/domainId will be backfilled automatically.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK BSS
 - ### Features
    - Support more interfaces: ListMeasureUnits.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK CES
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Update interface: ShowMetricData

## HuaweiCloud SDK SMN
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Update field type in message_template_name.


## 3.0.25-beta 2020-12-15
## HuaweiCloud SDK CCE
 - ### Features
    - Support Cloud Container Engine service.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK ELB
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that sending request to interface `CreateListener` returns empty response.
    - Fix the problem that sending request to interface `CreateListener` returns response with wrong type. 
 - ### Change
    - None

## HuaweiCloud SDK NAT
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that using interface `BatchCreateNatGatewayDnatRules` failed. 
 - ### Change
    - None


## 3.0.24-beta 2020-12-04
## HuaweiCloud SDK SMN
 - ### Features
    - Support Simple Message Notification service.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.23-beta 2020-11-30
## HuaweiCloud SDK BMS
 - ### Features
    - Support Bare Metal Server service.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK BSS
 - ### Features
    - Support more interfaces: ListUsageTypes, ModPeriodToOnDemand.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK CBR
 - ### Features
    - Support more interfaces: MigrateVaultResource.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK CES
 - ### Features
    - Support more interfaces: 
     - ListEvents
     - ListEventDetail
     - CreateResourceGroup
     - UpdateResourceGroup
     - DeleteResourceGroup
     - ListResourceGroup
     - UpdateAlarm
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK ECS
 - ### Features
    - None 
 - ### Bug Fix
    - None
 - ### Change
    - [Issue 21](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/21) Open related interface.

## HuaweiCloud SDK IAM
 - ### Features
    - Support more interfaces.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.22-beta 2020-11-17
## HuaweiCloud SDK DMS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Type of property adjustment: type of property `created` and type of `eff_date` are changed from `string` to `integer64`.  

## HuaweiCloud SDK ECS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Property adjustment:  increase property `dry_run` in interfaces `CreatePostPaidServers` and `CreateServers` which means whether parameters will be checked before sending real requests. 

## HuaweiCloud SDK NAT
 - ### Features
    - Support NAT Gateway service.
 - ### Bug Fix
    - None
 - ### Change
    - None 

## HuaweiCloud SDK Kafka
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Name of interface adjustment: UpdateInstanceCrossVPCIP → UpdateInstanceCrossVpcIp

## HuaweiCloud SDK VPC
 - ### Features
    - Support more interfaces: interfaces related to Network ACLs. 
 - ### Bug Fix
    - None
 - ### Change
    - None 


## 3.0.21-beta 2020-11-11
## HuaweiCloud SDK CBR
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Interface adjustment: property `object_type` in interface `CreateVault` support key `turbo`.
    - Interface adjustment: property `description` in interface `UpdatePolicy` is removed.

## HuaweiCloud SDK CES
 - ### Features
    - Add examples of interface response and adjust some filed description.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.20-beta 2020-11-02
## HuaweiCloud SDK CES
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Interface adjustment: property `alarm_type` in class `CreateAlarmRequestBody` support key `RESOURCE_GROUP`.
    - Interface adjustment: property `meta_data` in class `ListAlarmHistoriesResponse` only returns total number of alarm histories.

## HuaweiCloud SDK ELB
 - ### Features
    - None
 - ### Bug Fix
    - Modify wrong parameter in class `CreateL7ruleRequestBody`.
 - ### Change
    - None


## 3.0.19-beta 2020-10-31
## HuaweiCloud SDK CBR
 - ### Features
    - Support more interfaces: interfaces related to `TAG`.
 - ### Bug Fix
    - [Issue 17](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/17) fix the problem of interface: ListBackups.
 - ### Change
    - None

## HuaweiCloud SDK CTS
 - ### Features
    - Support more interface: ListQuotas
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK Iam
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Adjust interfaces' names, the involved interfaces are:
     1. KeystoneCreateUserTokenByPasswordAndMFA → KeystoneCreateUserTokenByPasswordAndMfa
     2. CreateUnscopeTokenByIDPInitiated → CreateUnscopeTokenByIdpInitiated

## HuaweiCloud SDK ProjectMan
 - ### Features
    - Support more interfaces: iteration information, user information, project members, project information, project indicators, project statistics, etc.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.18-beta 2020-10-20
## HuaweiCloud SDK DCS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Remove redundant `Dcs` in interfaces.

## HuaweiCloud SDK ELB
 - ### Features
    - Support more interfaces of version v2.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK IoTDA
 - ### Features
    - Support more interfaces related to rules.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.17-beta 2020-10-14
## HuaweiCloud SDK BSS
 - ### Features
    - Partner center supports exporting product catalog prices.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK DCS
 - ### Features
    - Support more interfaces.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.16-beta 2020-10-12
## HuaweiCloud SDK CTS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Delete deprecated interfaces of version v1.


## 3.0.15-beta 2020-09-30
## HuaweiCloud SDK Core
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that the value type of integer enumeration is incorrect when sending HTTP request.
 - ### Change
    - None

## HuaweiCloud SDK CBR
 - ### Features
    - Support Cloud Backup and Recovery service.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK EIP
 - ### Features
    - Support Elastic IP service.
 - ### Bug Fix
    - None
 - ### Change
    - None


## 3.0.14-beta 2020-09-24
## HuaweiCloud SDK BSS
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that the class `BssClient` cannot be loaded.
 - ### Change
    - None


## 3.0.13-beta 2020-09-16
## HuaweiCloud SDK ECS
 - ### Features
    - None
 - ### Bug Fix
    - Fix parameter type of interfaces.
 - ### Change
    - None

## HuaweiCloud SDK BSS
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Update interfaces.


# 3.0.12-beta 2020-09-11


## 3.0.11-beta 2020-09-09
## HuaweiCloud SDK Core
 - ### Features
    - None
 - ### Bug Fix
    - Delete redundant Sidecar code in the repository.
 - ### Change
    - None

## HuaweiCloud SDK DMS
 - ### Features
    - Support Distributed Message Services, provide Kafka premium instances and RabbitMQ premium instances with dedicated resources.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK VPC
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that security group related interfaces have wrong data type.
 - ### Change
    - None


## 3.0.10-beta 2020-09-04
## HuaweiCloud SDK Core
 - ### Features
    - None
 - ### Bug Fix
    - Fix the problem that the enumeration code cannot be generated for integer enumeration parameters without format defined in yaml.
 - ### Change
    - Modify User Agent of Http Request header.
 

# 3.0.9-beta 2020-08-28
## HuaweiCloud SDK EVS
 - ### Features
    - None
 - ### Bug Fix
    - APIs ListVolumesByTags, solve the problem of type definition error of field `total_count`.
 - ### Change
    - None

## HuaweiCloud SDK IAM
 - ### Features
    - Support more APIs: consistency of console related APIs.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK IoTDA
 - ### Features
    - Support more APIs: batch operation related APIs and asynchronous related APIs.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK ProjectMan
 - ### Features
    - Support Project Management service.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK VPC
 - ### Features
    - Support more APIs: security group, security group rules, available IP count related APIs.
 - ### Bug Fix
    - None
 - ### Change
    - None


# 3.0.8-beta 2020-8-14
## HuaweiCloud SDK Core
 - ### Features
    - Support temporary AK/SK authentication mode.
 - ### Bug Fix
    - None
 - ### Change
    - None
    
## HuaweiCloud SDK BSS
 - ### Features
    - Support Business Support System service. 
 - ### Bug Fix
    - None
 - ### Change
    - None
    
## HuaweiCloud SDK KMS
 - ### Features
    - Support temporary Key Management Service.
 - ### Bug Fix
    - None
 - ### Change
    - None


# __3.0.7-beta__ __2020-07-30__
## HuaweiCloud SDK Core
 - ### Features
    - Support file upload and download
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK ECS
 - ### Features
    - Publish new interfaces, such as ChangeServerOs and ResetServerPassword.
 - ### Bug Fix
    - None
 - ### Change
    - None

## HuaweiCloud SDK VPC
 - ### Features
    - Support interfaces of version v3.
 - ### Bug Fix
    - None
 - ### Change
    - None


# __3.0.6-beta__ __2020-07-15__
## HuaweiCloud SDK EVS
 - ### Features
    - None
 - ### Bug Fix
    - [Issue #3](https://github.com/huaweicloud/huaweicloud-sdk-java-v3/issues/3): Fix call error of interface ShowVolume.
 - ### Change
    - None

## __HuaweiCloud SDK IAM__
  - ### Features
    - None
  - ### Bug Fix
    - Fix parsing failure of response body of interface keystoneListVersions.
  - ### Change
    - None

## __HuaweiCloud SDK IoTDA__
 - ### Features
    - None
 - ### Bug Fix
    - None
 - ### Change
    - Support related interfaces of application management.


# __3.0.5-beta__ __2020-06-30__
## __HuaweiCloud SDK Core__
  - ### Features
    - Support async client.
    - Support users to customize the request log output in the troubleshooting scenario.
  - ### Bug Fix
    - None
  - ### Change
    - None

## __HuaweiCloud SDK CTS__
  - ### Features
    - Support Cloud Trace Service.
  - ### Bug Fix
    - None
  - ### Change
    - None
    
## __HuaweiCloud SDK EVS__
  - ### Features
    - None
  - ### Bug Fix
    - None
  - ### Change
    - Support full service interface.

## __HuaweiCloud SDK IoTDA__
  - ### Features
    - Support IoT Device Access Service.
  - ### Bug Fix
    - None
  - ### Change
    - None