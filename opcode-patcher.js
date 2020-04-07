const fs = require('fs');

const messages = 'Ping = 0x017A, // updated 5.25\n' +
    '    Init = 0x03B9, // updated 5.25\n' +
    '    ActorFreeSpawn = 0x0194, // updated 5.25\n' +
    '    InitZone = 0x01CD, // updated 5.25\n' +
    '    EffectResult = 0x030F, // updated 5.25\n' +
    '    ActorControl = 0x01DD, // updated 5.25\n' +
    '    ActorControlSelf = 0x0165, // updated 5.25\n' +
    '    ActorControlTarget = 0x01EB, // updated 5.25\n' +
    '    UpdateHpMpTp = 0x00F8, // updated 5.25\n' +
    '    Logout = 0x00CD, // updated 5.25\n' +
    '    SocialList = 0x0269, // updated 5.25\n' +
    '    InitSearchInfo = 0x0347, // updated 5.25\n' +
    '    ServerNotice = 0x00E9, // updated 5.25\n' +
    '    SetOnlineStatus = 0x0381, // updated 5.25\n' +
    '    BlackList = 0x027A, // updated 5.25\n' +
    '    LinkshellList = 0x00A9, // updated 5.25\n' +
    '    StatusEffectList = 0x01D7, // updated 5.25\n' +
    '    Effect = 0x0087, // updated 5.25\n' +
    '    AoeEffect8 = 0x01A6, // updated 5.25\n' +
    '    PersistantEffect = 0x032E, // updated 5.25' +
    '    PlayerSpawn = 0x00B9, // updated 5.25\n' +
    '    NpcSpawn = 0x038D, // updated 5.25\n' +
    '    ActorSetPos = 0x028E, // updated 5.25\n' +
    '    ActorCast = 0x00C4, // updated 5.25\n' +
    '    UpdateClassInfo = 0x00DC, // updated 5.25\n' +
    '    PlayerSetup = 0x0071, // updated 5.25\n' +
    '    PlayerStats = 0x007C, // updated 5.25\n' +
    '    ActorOwner = 0x0149, // updated 5.25\n' +
    '    PlayerStateFlags = 0x0125, // updated 5.25\n' +
    '    PlayerClassInfo = 0x034F, // updated 5.25\n' +
    '    CharaVisualEffect = 0x0258, // updated 5.25\n' +
    '    ModelEquip = 0x01E5, // updated 5.25\n' +
    '    ItemInfo = 0x02AA, // updated 5.25\n' +
    '    ContainerInfo = 0x02A8, // updated 5.25\n' +
    '    InventoryTransactionFinish = 0x0193, // updated 5.25\n' +
    '    InventoryTransaction = 0x0119, // updated 5.25\n' +
    '    CurrencyCrystalInfo = 0x018A, // updated 5.25\n' +
    '    InventoryActionAck = 0x01AE, // updated 5.25\n' +
    '    UpdateInventorySlot = 0x0151, // updated 5.25\n' +
    '    EventPlay = 0x02C3, // updated 5.25\n' +
    '    EventPlay255 = 0x01AC, // updated 5.25\n' +
    '    EventStart = 0x0360, // updated 5.25\n' +
    '    EventFinish = 0x0239, // updated 5.25\n' +
    '    QuestActiveList = 0x0391, // updated 5.25\n' +
    '    QuestCompleteList = 0x0231, // updated 5.25\n' +
    '    QuestTracker = 0x00AD, // updated 5.25\n' +
    '    Mount = 0x02BE, // updated 5.25\n' +
    '    HousingLandFlags = 0x0177, // updated 5.25\n' +
    '    PrepareZoning = 0x03B3, // updated 5.25\n' +
    '    ActorGauge = 0x007D, // updated 5.25\n' +
    '    DailyQuests = 0x031E, // updated 5.25\n' +
    '    DailyQuestRepeatFlags = 0x00A7, // updated 5.25\n' +
    '    PingHandler = 0x017A, // updated 5.25\n' +
    '    InitHandler = 0x03B9, // updated 5.25\n' +
    '    FinishLoadingHandler = 0x008A, // updated 5.25\n' +
    '    LogoutHandler = 0x00B7, // updated 5.25\n' +
    '    ChatHandler = 0x0189, // updated 5.25\n' +
    '    SocialListHandler = 0x0371, // updated 5.25\n' +
    '    ReqSearchInfoHandler = 0x0366, // updated 5.25\n' +
    '    BlackListHandler = 0x0354, // updated 5.25\n' +
    '    LinkshellListHandler = 0x01D4, // updated 5.25\n' +
    '    ClientTrigger = 0x017D, // updated 5.25\n' +
    '    SkillHandler = 0x0241, // updated 5.25\n' +
    '    UpdatePositionHandler = 0x014D, // updated 5.25\n' +
    '    InventoryModifyHandler = 0x0179, // updated 5.25\n' +
    '    TalkEventHandler = 0x030F, // updated 5.25\n' +
    '    ReturnEventHandler = 0x00BB, // updated 5.25\n' +
    '    TradeReturnEventHandler = 0x03B6, // updated 5.25\n' +
    '    ActorMove = 0x0290, // updated 5.25\n' +
    '    ReqEquipDisplayFlagsChange = 0x0202, // updated 5.25\n' +
    '    EquipDisplayFlags = 0x010D, // updated 5.25\n' +
    '    ZoneLineHandler = 0x0214, // updated 5.25';

const inputFilePath = 'F:\\WebstormProjects\\MachinaWrapperJSON\\MachinaWrapper\\src\\Models\\Sapphire\\Ipcs.cs';

const inputClass = fs.readFileSync(inputFilePath, 'utf-8');

messages.split('\n').forEach(message => {
    const opcodeName = message.split(' = ')[0].replace(/\s+/, '');
    const opcodeValue = message.split(' = ')[1]
    const previousOpcodeLine = inputClass.split('\n').find(line => line.indexOf(`${opcodeName} = `) > -1);
    inputClass.replace(previousOpcodeLine, `    ${opcodeName} = ${opcodeValue}`);
    fs.writeFileSync(inputFilePath, inputClass);
});
