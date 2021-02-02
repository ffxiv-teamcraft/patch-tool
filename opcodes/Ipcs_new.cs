namespace FFXIVOpcodes.Global
{
    ////////////////////////////////////////////////////////////////////////////////
    /// Lobby Connection IPC Codes
    /**
    * Server IPC Lobby Type Codes.
    */
    enum ServerLobbyIpcType : ushort
    {
        LobbyError = 0x0002,
        LobbyServiceAccountList = 0x000C,
        LobbyCharList = 0x000D,
        LobbyCharCreate = 0x000E,
        LobbyEnterWorld = 0x000F,
        LobbyServerList = 0x0015,
        LobbyRetainerList = 0x0017,
    };

    /**
    * Client IPC Lobby Type Codes.
    */
    enum ClientLobbyIpcType : ushort
    {
        ReqCharList = 0x0003,
        ReqEnterWorld = 0x0004,
        ClientVersionInfo = 0x0005,

        ReqCharDelete = 0x000A,
        ReqCharCreate = 0x000B,
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Zone Connection IPC Codes
    /**
    * Server IPC Zone Type Codes.
    */
    enum ServerZoneIpcType : ushort
    {
        //Ping = 0x0324, // updated 5.45
        //Init = 0x00B8, // updated 5.45

        //ActorFreeSpawn = 0x01DB, // updated 5.45
        InitZone = 0x01C6, // updated 5.45

        EffectResult = 0x026B, // updated 5.45
        ActorControl = 0x00F0, // updated 5.45
        ActorControlSelf = 0x0350, // updated 5.45
        ActorControlTarget = 0x029A, // updated 5.45

        /*!
         * @brief Used when resting
         */
        UpdateHpMpTp = 0x01DB, // updated 5.45

        ///////////////////////////////////////////////////

        //ChatBanned = 0x006B,
        Playtime = 0x033A, // updated 5.45
        Logout = 0x0249, // updated 5.45
        CFNotify = 0x014C, // updated 5.45
                           //CFMemberStatus = 0x0079,
                           //CFDutyInfo = 0x007A,
                           //CFPlayerInNeed = 0x007F,
                           //CFPreferredRole = 0x020C, // updated 5.45

        //SocialRequestError = 0x00AD,

        //CFRegistered = 0x0115, // updated 5.45
        //SocialRequestResponse = 0x0175, // updated 5.45
        //CancelAllianceForming = 0x0203, // updated 5.45

        //LogMessage = 0x00D0,

        //Chat = 0x01BD, // updated 5.45

        //WorldVisitList = 0x00FE, // added 4.5

        //SocialList = 0x01CA, // updated 5.45

        UpdateSearchInfo = 0x012F, // updated 5.45
        ExamineSearchInfo = 0x02CB, // updated 5.45
                                    //InitSearchInfo = 0x0367, // updated 5.45
                                    //ExamineSearchComment = 0x02F2, // updated 5.45

        //ServerNoticeShort = 0x013C, // updated 5.45
        //ServerNotice = 0x0147, // updated 5.45
        //SetOnlineStatus = 0x03C3, // updated 5.45

        //CountdownInitiate = 0x010F, // updated 5.45
        //CountdownCancel = 0x02DF, // updated 5.45

        //PlayerAddedToBlacklist = 0x02E2, // updated 5.45
        //PlayerRemovedFromBlacklist = 0x02D6, // updated 5.45
        //BlackList = 0x01CA, // updated 5.45

        //LinkshellList = 0x03A5, // updated 5.45

        //MailDeleteRequest = 0x0108, // updated 5.45

        // 12D - 137 - constant gap between 4.5x -> 5.0
        //ReqMoogleMailList = 0x00EB, // updated 5.45
        //ReqMoogleMailLetter = 0x02C1, // updated 5.45
        //MailLetterNotification = 0x010D, // updated 5.45

        MarketBoardSearchResult = 0x01CC, // updated 5.45
        MarketBoardItemListingCount = 0x0271, // updated 5.45
        MarketBoardItemListingHistory = 0x02A4, // updated 5.45
        MarketBoardItemListing = 0x0273, // updated 5.45

        ResultDialog = 0x00E5, // updated 5.45
        DesynthResult = 0x0332, // updated 5.45

        //CharaFreeCompanyTag = 0x0078, // updated 5.45
        //FreeCompanyBoardMsg = 0x0115, // updated 5.45
        FreeCompanyInfo = 0x01BA, // updated 5.45
        //ExamineFreeCompanyInfo = 0x01C7, // updated 5.45

        //FreeCompanyUpdateShortMessage = 0x0157, // added 5.0

        StatusEffectList = 0x00C2, // updated 5.45
                                   //EurekaStatusEffectList = 0x006B, // updated 5.45
                                   //BossStatusEffectList = 0x008A, // updated 5.45
                                   //EurekaStatusEffectList = 0x01A5, // updated 5.45
                                   //BossStatusEffectList= 0x0091, // updated 5.45
        Effect = 0x021F, // updated 5.45
                         //AoeEffect8 = 0x014A, // updated 5.45
                         //AoeEffect16 = 0x00AD, // updated 5.45
                         //AoeEffect24 = 0x0284, // updated 5.45
                         //AoeEffect32 = 0x01F5, // updated 5.45
                         //PersistantEffect = 0x02BF, // updated 5.45

        //GCAffiliation = 0x008A, // updated 5.45

        PlayerSpawn = 0x0083, // updated 5.45
        NpcSpawn = 0x03C4, // updated 5.45
                           //NpcSpawn2 = 0x011C, // updated 5.45

        ActorMove = 0x03A9, // updated 5.45
        ActorSetPos = 0x0283, // updated 5.45

        ActorCast = 0x02B2, // updated 5.45
                            //SomeCustomiseChangePacketProbably = 0x00CD, // added 5.18

        //PartyList = 0x02F3, // updated 5.45
        //HateRank = 0x0317, // updated 5.45
        //HateList = 0x00E0, // updated 5.45
        ObjectSpawn = 0x03C8, // updated 5.45
                              //ObjectDespawn = 0x0086, // updated 5.45
        UpdateClassInfo = 0x02F4, // updated 5.45
                                  //SilentSetClassJob = 0x0100, // updated 5.45
        PlayerSetup = 0x035C, // updated 5.45
        PlayerStats = 0x036F, // updated 5.45
        //ActorOwner = 0x0080, // updated 5.45
        //PlayerStateFlags = 0x0106, // updated 5.45
        //PlayerClassInfo = 0x0396, // updated 5.45
        //CharaVisualEffect = 0x00A9, // updated 5.45

        //ModelEquip = 0x0375, // updated 5.45
        Examine = 0x0348, // updated 5.45
        //CharaNameReq = 0x0354, // updated 5.45

        // nb: see #565 on github
        //UpdateRetainerItemSalePrice = 0x027A, // updated 5.45
        //RetainerSaleHistory = 0x01D5, // updated 5.45
        RetainerInformation = 0x0207, // updated 5.45

        //SetLevelSync = 0x1186, // not updated for 4.4, not sure what it is anymore

        ItemInfo = 0x0277, // updated 5.45
        //ContainerInfo = 0x01E7, // updated 5.45
        InventoryTransaction = 0x036D, // updated 5.45
        InventoryTransactionFinish = 0x01CE, // updated 5.45
        CurrencyCrystalInfo = 0x01F4, // updated 5.45

        InventoryActionAck = 0x0205, // updated 5.45
        UpdateInventorySlot = 0x032A, // updated 5.45

        //HuntingLogEntry = 0x02E5, // updated 5.45

        EventPlay = 0x037F, // updated 5.45
        EventPlay4 = 0x02CF, // updated 5.45
        EventPlay8 = 0x01AE, // updated 5.45
        EventPlay16 = 0x03B2, // updated 5.45
        EventPlay32 = 0x01D2, // updated 5.45
        EventPlay64 = 0x0262, // updated 5.45
        EventPlay128 = 0x011D, // updated 5.45
        EventPlay255 = 0x0318, // updated 5.45

        EventStart = 0x026C, // updated 5.45
        EventFinish = 0x02B1, // updated 5.45

        //EventLinkshell = 0x1169,

        //QuestActiveList = 0x02C0, // updated 5.45
        //QuestUpdate = 0x02AE, // updated 5.45
        //QuestCompleteList = 0x03DB, // updated 5.45

        //QuestFinish = 0x01C2, // updated 5.45
        //MSQTrackerComplete = 0x01C8, // updated 5.45
        //MSQTrackerProgress = 0xF1CD, // updated 4.5 ? this actually looks like the two opcodes have been combined, see #474

        //QuestMessage = 0x014B, // updated 5.45

        //QuestTracker = 0x032A, // updated 5.45

        Mount = 0x0203, // updated 5.45

        //DirectorVars = 0x00B2, // updated 5.45
        //SomeDirectorUnk1 = 0x00F4, // updated 5.45
        //SomeDirectorUnk2 = 0x02CE, // updated 5.45
        SomeDirectorUnk4 = 0x01B6, // updated 5.45
        //SomeDirectorUnk8 = 0x0253, // updated 5.45
        //SomeDirectorUnk16 = 0x01AA, // updated 5.45
        //DirectorPopUp = 0x021B, // updated 5.45
        //DirectorPopUp4 = 0x0327, // updated 5.45
        //DirectorPopUp8 = 0x0374, // updated 5.45

        //CFAvailableContents = 0xF1FD, // updated 4.2

        WeatherChange = 0x0250, // updated 5.45
        //PlayerTitleList = 0x035C, // updated 5.45
        //Discovery = 0x00C3, // updated 5.45

        //EorzeaTimeOffset = 0x008A, // updated 5.45

        //EquipDisplayFlags = 0x03C0, // updated 5.45

        //MiniCactpotInit = 0x0286, // added 5.31

        /// Housing //////////////////////////////////////

        //LandSetInitialize = 0x0082, // updated 5.45
        //LandUpdate = 0x02BE, // updated 5.45
        //YardObjectSpawn = 0x01FF, // updated 5.45
        //HousingIndoorInitialize = 0x00A3, // updated 5.45
        //LandPriceUpdate = 0x0327, // updated 5.45
        //LandInfoSign = 0x00BA, // updated 5.45
        //LandRename = 0x0210, // updated 5.45
        //HousingEstateGreeting = 0x02E2, // updated 5.45
        //HousingUpdateLandFlagsSlot = 0x01B3, // updated 5.45
        //HousingLandFlags = 0x0320, // updated 5.45
        //HousingShowEstateGuestAccess = 0x00A9, // updated 5.45

        //HousingObjectInitialize = 0x00D5, // updated 5.45
        //HousingInternalObjectSpawn = 0x00E2, // updated 5.45

        HousingWardInfo = 0x0331, // updated 5.45
                                 //HousingObjectMove = 0x0211, // updated 5.45

        //SharedEstateSettingsResponse = 0x03AF, // updated 5.45

        //LandUpdateHouseName = 0x00BA, // updated 5.45

        //LandSetMap = 0x0121, // updated 5.45

        //////////////////////////////////////////////////

        //DuelChallenge = 0x0277, // 4.2; this is responsible for opening the ui
        //PerformNote = 0x0252, // updated 5.45

        PrepareZoning = 0x00AB, // updated 5.45
        ActorGauge = 0x0278, // updated 5.45

        // daily quest info -> without them sent,  login will take longer...
        //DailyQuests = 0x03CA, // updated 5.45
        //DailyQuestRepeatFlags = 0x03A7, // updated 5.45

        /// Doman Mahjong //////////////////////////////////////
        //MahjongOpenGui = 0x02A4, // only available in mahjong instance
        //MahjongNextRound = 0x02BD, // initial hands(baipai), # of riichi(wat), winds, honba, score and stuff
        //MahjongPlayerAction = 0x02BE, // tsumo(as in drawing a tile) called chi/pon/kan/riichi
        //MahjongEndRoundTsumo = 0x02BF, // called tsumo
        //MahjongEndRoundRon = 0x2C0, // called ron or double ron (waiting for action must be flagged from discard packet to call)
        //MahjongTileDiscard = 0x02C1, // giri (discarding a tile.) chi(1)/pon(2)/kan(4)/ron(8) flags etc..
        //MahjongPlayersInfo = 0x02C2, // actor id, name, rating and stuff..
        // 2C3 and 2C4 are currently unknown
        //MahjongEndRoundDraw = 0x02C5, // self explanatory
        //MahjongEndGame = 0x02C6, // finished oorasu(all-last) round; shows a result screen.

        AirshipExplorationResult = 0x035E, // updated 5.45
        AirshipStatus = 0x007D, // added 5.41
        AirshipStatusList = 0x00FA, // updated 5.45
        AirshipTimers = 0x01D6, // added 5.41
        SubmarineExplorationResult = 0x0225, // updated 5.45
        SubmarineProgressionStatus = 0x03B4, // added 5.41
        SubmarineStatusList = 0x03BB, // updated 5.45
        SubmarineTimers = 0x03DA, // added 5.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        //PingHandler = 0x0324, // updated 5.45
        //InitHandler = 0x00B8, // updated 5.45

        //FinishLoadingHandler = 0x00DF, // updated 5.45

        //CFCommenceHandler = 0x0184, // updated 5.45

        //CFRegisterDuty = 0x00ED, // updated 5.45
        //CFRegisterRoulette = 0x0102, // updated 5.45
        //PlayTimeHandler = 0x007F, // updated 5.45
        //LogoutHandler = 0x0072, // updated 5.45
        //CancelLogout = 0x0251, // updated 5.45

        //CFDutyInfoHandler = 0x0184, // updated 5.45

        //SocialReqSendHandler = 0x0264, // updated 5.45
        //CreateCrossWorldLS = 0x00C5, // updated 5.45

        ChatHandler = 0x02F2, // updated 5.45

        //SocialListHandler = 0x02AE, // updated 5.45
        SetSearchInfoHandler = 0x019B, // updated 5.45
        //ReqSearchInfoHandler = 0x02AE, // updated 5.45
        //ReqExamineSearchCommentHandler = 0x0308, // updated 5.45

        //ReqRemovePlayerFromBlacklist = 0x00CC, // updated 5.45
        //BlackListHandler = 0x00AE, // updated 5.45
        //PlayerSearchHandler = 0x0387, // updated 5.45

        //LinkshellListHandler = 0x00E6, // updated 5.45

        //MarketBoardRequestItemListingInfo = 0x02F2, // updated 5.45
        //MarketBoardRequestItemListings = 0x0184, // updated 5.45
        //MarketBoardSearch = 0x026B, // updated 5.45

        //ReqExamineFcInfo = 0x0240, // updated 5.45

        //FcInfoReqHandler = 0x00F6, // updated 5.45

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x0392, // updated 5.45

        //ReqJoinNoviceNetwork = 0x0245, // updated 5.45

        //ReqCountdownInitiate = 0x0113, // updated 5.45
        //ReqCountdownCancel = 0x0078, // updated 5.45

        //ZoneLineHandler = 0x0327, // updated 5.45
        ClientTrigger = 0x034F, // updated 5.45
                                //DiscoveryHandler = 0x00F9, // updated 5.45

        PlaceFieldMarker = 0x03BC, // updated 5.45
        PlaceFieldMarkerPreset = 0x0162, // updated 5.45
        //SkillHandler = 0x03AE, // updated 5.45
        //GMCommand1 = 0x00B0, // updated 5.45
        //GMCommand2 = 0x0082, // updated 5.45
        //AoESkillHandler = 0x02AC, // updated 5.45

        UpdatePositionHandler = 0x01B3, // updated 5.45

        InventoryModifyHandler = 0x0120, // updated 5.45

        //InventoryEquipRecommendedItems = 0x0080, // updated 5.45

        //ReqPlaceHousingItem = 0x0198, // updated 5.45
        //BuildPresetHandler = 0x01F0, // updated 5.45

        //TalkEventHandler = 0x02B7, // updated 5.45
        //EmoteEventHandler = 0x0291, // updated 5.45
        //WithinRangeEventHandler = 0x03A9, // updated 5.45
        //OutOfRangeEventHandler = 0x01AF, // updated 5.45
        //EnterTeriEventHandler = 0x0374, // updated 5.45

        //ReturnEventHandler = 0x0175, // updated 5.45
        //TradeReturnEventHandler = 0x00B4, // updated 5.45

        //LinkshellEventHandler = 0x0286, // updated 5.45
        //LinkshellEventHandler1 = 0x0286, // updated 5.45

        //ReqEquipDisplayFlagsChange = 0x0194, // updated 5.45

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x0320, // updated 5.45
        //HousingUpdateObjectPosition = 0x03A2, // updated 5.45

        //SetSharedEstateSettings = 0x0141, // updated 5.45

        UpdatePositionInstance = 0x0338, // updated 5.45

        //PerformNoteHandler = 0x030D, // updated 5.45
    };

    ////////////////////////////////////////////////////////////////////////////////
    /// Chat Connection IPC Codes
    /**
    * Server IPC Chat Type Codes.
    */
    enum ServerChatIpcType : ushort
    {
        //Tell = 0x0064, // updated for sb
        //TellErrNotFound = 0x0066,

        //FreeCompanyEvent = 0x012C, // added 5.0
    };

    /**
    * Client IPC Chat Type Codes.
    */
    enum ClientChatIpcType : ushort
    {
        //TellReq = 0x0064,
    };
}
