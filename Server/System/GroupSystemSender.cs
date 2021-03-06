using LunaCommon.Groups;
using LunaCommon.Locks;
using LunaCommon.Message.Data.Lock;
using LunaCommon.Message.Server;
using LunaServer.Client;
using LunaServer.Log;
using LunaServer.Server;
using System.Linq;

namespace LunaServer.System
{
    public class GroupSystemSender
    {
        public static void SendAllLocks(ClientStructure client)
        {
            MessageQueuer.SendToClient<LockSrvMsg>(client, new LockListReplyMsgData { Locks = LockSystem.LockQuery.GetAllLocks().ToArray() });
        }

        public static void SendLockAquireMessage(LockDefinition lockDefinition, bool force)
        {
            var lockResult = LockSystem.AcquireLock(lockDefinition, force);

            var newMessageData = new LockAcquireMsgData
            {
                Lock = lockDefinition,
                LockResult = lockResult,
                Force = force
            };
            MessageQueuer.SendToAllClients<LockSrvMsg>(newMessageData);

            LunaLog.Debug(lockResult
                ? $"{lockDefinition.PlayerName} acquired lock {lockDefinition}"
                : $"{lockDefinition.PlayerName} failed to acquire lock {lockDefinition}");
        }

        public static void SendGroupUpdate(Group newGroup)
        {
            throw new global::System.NotImplementedException();
        }
    }
}