﻿namespace Conflux.RPC
{
    public enum ApiMethods
    {
        net_listening,
        cfx_chainId,
        cfx_protocolVersion,
        cfx_syncing,
        cfx_coinbase,
        cfx_mining,
        cfx_hashrate,
        cfx_gasPrice,
        cfx_estimateGasAndCollateral,
        cfx_accounts,
        cfx_blockNumber,
        cfx_getBalance,
        cfx_epochNumber,
        cfx_getNextNonce,
        cfx_getStorageAt,
        cfx_getTransactionCount,
        cfx_getBlockTransactionCountByHash,
        cfx_getBlockTransactionCountByNumber,
        cfx_getUncleCountByBlockHash,
        cfx_getUncleCountByBlockNumber,
        cfx_getCode,
        cfx_sign,
        cfx_sendTransaction,
        cfx_sendRawTransaction,
        cfx_call,
        cfx_estimateGas,
        cfx_getBlockByHash,
        cfx_getBlockByNumber,
        cfx_getTransactionByHash,
        cfx_getTransactionByBlockHashAndIndex,
        cfx_getTransactionByBlockNumberAndIndex,
        cfx_getTransactionReceipt,
        cfx_getUncleByBlockHashAndIndex,
        cfx_getUncleByBlockNumberAndIndex,
        cfx_getCompilers,
        cfx_compileLLL,
        cfx_compileSolidity,
        cfx_compileSerpent,
        cfx_newFilter,
        cfx_newBlockFilter,
        cfx_newPendingTransactionFilter,
        cfx_uninstallFilter,
        cfx_getFilterChanges,
        cfx_getFilterLogs,
        cfx_getLogs,
        cfx_getWork,
        cfx_submitWork,
        cfx_submitHashrate,
        cfx_subscribe,
        cfx_unsubscribe,
        shh_version,
        shh_info,
        shh_setMaxMessageSize,
        shh_setMinPoW,
        shh_markTrustedPeer,
        shh_newKeyPair,
        shh_addPrivateKey,
        shh_deleteKeyPair,
        shh_hasKeyPair,
        shh_getPublicKey,
        shh_getPrivateKey,
        shh_newSymKey,
        shh_addSymKey,
        shh_generateSymKeyFromPassword,
        shh_hasSymKey,
        shh_getSymKey,
        shh_deleteSymKey,
        shh_subscribe,
        shh_unsubscribe,
        shh_newMessageFilter,
        shh_deleteMessageFilter,
        shh_getFilterMessages,
        shh_post,
        web3_clientVersion,
        web3_sha3,
        net_version,
        net_peerCount,
        personal_listAccounts,
        personal_newAccount,
        personal_unlockAccount,
        personal_lockAccount,
        personal_sendTransaction
    }
}