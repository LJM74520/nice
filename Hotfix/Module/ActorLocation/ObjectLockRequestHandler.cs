﻿using Server;
using System;

namespace Hotfix
{
    [ActorMessageHandler]
    public class ObjectLockRequestHandler : AMActorRpcHandler<Scene, ObjectLockRequest, ObjectLockResponse>
    {
        protected override async ETTask Run(Scene scene, ObjectLockRequest request, ObjectLockResponse response, Action reply)
        {
            scene.GetComponent<LocationComponent>().Lock(request.Key, request.InstanceId, request.Time).Coroutine();
            reply();
        }
    }
}
