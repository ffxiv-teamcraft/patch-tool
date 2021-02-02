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
        //Ping = 0x324, // updated 5.45
        //Init = 0xb8, // updated 5.45

        //ActorFreeSpawn = 0x1db, // updated 5.45
        InitZone = 0x1c6, // updated 5.45

        EffectResult = 0x31c, // updated 5.45
        ActorControl = 0x3e1, // updated 5.45
        ActorControlSelf = 0x350, // updated 5.45
        ActorControlTarget = 0x18b, // updated 5.45

        /*!
         * @brief Used when resting
         */
        UpdateHpMpTp = 0x1db, // updated 5.45

        ///////////////////////////////////////////////////

        //ChatBanned = 0x006B,
        Playtime = 0x1d8, // updated 5.45
        Logout = 0x230, // updated 5.45
        CFNotify = 0x14c, // updated 5.45
                           //CFMemberStatus = 0x0079,
                           //CFDutyInfo = 0x007A,
                           //CFPlayerInNeed = 0x007F,
                           //CFPreferredRole = 0x20c, // updated 5.45

        //SocialRequestError = 0x00AD,

        //CFRegistered = 0x115, // updated 5.45
        //SocialRequestResponse = 0x175, // updated 5.45
        //CancelAllianceForming = 0x203, // updated 5.45

        //LogMessage = 0x00D0,

        //Chat = 0x1bd, // updated 5.45

        //WorldVisitList = 0x00FE, // added 4.5

        //SocialList = 0x103, // updated 5.45

        UpdateSearchInfo = 0x12f, // updated 5.45
        ExamineSearchInfo = 0x398, // updated 5.45
                                    //InitSearchInfo = 0x367, // updated 5.45
                                    //ExamineSearchComment = 0x2f2, // updated 5.45

        //ServerNoticeShort = 0x13c, // updated 5.45
        //ServerNotice = 0x147, // updated 5.45
        //SetOnlineStatus = 0x3c3, // updated 5.45

        //CountdownInitiate = 0x10f, // updated 5.45
        //CountdownCancel = 0x2df, // updated 5.45

        //PlayerAddedToBlacklist = 0x359, // updated 5.45
        //PlayerRemovedFromBlacklist = 0x2d6, // updated 5.45
        //BlackList = 0x103, // updated 5.45

        //LinkshellList = 0x3a5, // updated 5.45

        //MailDeleteRequest = 0x108, // updated 5.45

        // 12D - 137 - constant gap between 4.5x -> 5.0
        //ReqMoogleMailList = 0xeb, // updated 5.45
        //ReqMoogleMailLetter = 0x2c1, // updated 5.45
        //MailLetterNotification = 0x10d, // updated 5.45

        MarketBoardSearchResult = 0x1cc, // updated 5.45
        MarketBoardItemListingCount = 0x2da, // updated 5.45
        MarketBoardItemListingHistory = 0x228, // updated 5.45
        MarketBoardItemListing = 0x308, // updated 5.45

        ResultDialog = 0xe5, // updated 5.45
        DesynthResult = 0x2b3, // updated 5.45

        //CharaFreeCompanyTag = 0x78, // updated 5.45
        //FreeCompanyBoardMsg = 0x115, // updated 5.45
        FreeCompanyInfo = 0x2df, // updated 5.45
        //ExamineFreeCompanyInfo = 0x1c7, // updated 5.45

        //FreeCompanyUpdateShortMessage = 0x0157, // added 5.0

        StatusEffectList = 0xa9, // updated 5.45
                                   //EurekaStatusEffectList = 0x6b, // updated 5.45
                                   //BossStatusEffectList = 0x8a, // updated 5.45
                                   //EurekaStatusEffectList = 0xab, // updated 5.45
                                   //BossStatusEffectList= 0x38f, // updated 5.45
        Effect = 0x6b, // updated 5.45
                         //AoeEffect8 = 0x14a, // updated 5.45
                         //AoeEffect16 = 0xcc, // updated 5.45
                         //AoeEffect24 = 0x284, // updated 5.45
                         //AoeEffect32 = 0x1f5, // updated 5.45
                         //PersistantEffect = 0x2bf, // updated 5.45

        //GCAffiliation = 0x8a, // updated 5.45

        PlayerSpawn = 0x2aa, // updated 5.45
        NpcSpawn = 0x3c4, // updated 5.45
                           //NpcSpawn2 = 0x357, // updated 5.45

        ActorMove = 0x261, // updated 5.45
        ActorSetPos = 0x283, // updated 5.45

        ActorCast = 0x2b2, // updated 5.45
                            //SomeCustomiseChangePacketProbably = 0x00CD, // added 5.18

        //PartyList = 0x2f3, // updated 5.45
        //HateRank = 0x317, // updated 5.45
        //HateList = 0xe0, // updated 5.45
        ObjectSpawn = 0x3c8, // updated 5.45
                              //ObjectDespawn = 0x86, // updated 5.45
        UpdateClassInfo = 0x2fd, // updated 5.45
                                  //SilentSetClassJob = 0x115, // updated 5.45
        PlayerSetup = 0x14a, // updated 5.45
        PlayerStats = 0x36f, // updated 5.45
        //ActorOwner = 0xed, // updated 5.45
        //PlayerStateFlags = 0x3ca, // updated 5.45
        //PlayerClassInfo = 0x3e3, // updated 5.45
        //CharaVisualEffect = 0xa9, // updated 5.45

        //ModelEquip = 0x375, // updated 5.45
        Examine = 0x2bc, // updated 5.45
        //CharaNameReq = 0x354, // updated 5.45

        // nb: see #565 on github
        //UpdateRetainerItemSalePrice = 0x27a, // updated 5.45
        //RetainerSaleHistory = 0x1d5, // updated 5.45
        RetainerInformation = 0x207, // updated 5.45

        //SetLevelSync = 0x1186, // not updated for 4.4, not sure what it is anymore

        ItemInfo = 0x280, // updated 5.45
        //ContainerInfo = 0x1e7, // updated 5.45
        InventoryTransaction = 0x344, // updated 5.45
        InventoryTransactionFinish = 0x210, // updated 5.45
        CurrencyCrystalInfo = 0x3c0, // updated 5.45

        InventoryActionAck = 0x1f1, // updated 5.45
        UpdateInventorySlot = 0xaa, // updated 5.45

        //HuntingLogEntry = 0x2e5, // updated 5.45

        EventPlay = 0x19a, // updated 5.45
        EventPlay4 = 0x2cf, // updated 5.45
        EventPlay8 = 0x3b3, // updated 5.45
        EventPlay16 = 0x3b2, // updated 5.45
        EventPlay32 = 0x14c, // updated 5.45
        EventPlay64 = 0x2b3, // updated 5.45
        EventPlay128 = 0x11d, // updated 5.45
        EventPlay255 = 0x318, // updated 5.45

        EventStart = 0x26c, // updated 5.45
        EventFinish = 0xa2, // updated 5.45

        //EventLinkshell = 0x1169,

        //QuestActiveList = 0x2c0, // updated 5.45
        //QuestUpdate = 0x2ae, // updated 5.45
        //QuestCompleteList = 0x3d3, // updated 5.45

        //QuestFinish = 0x251, // updated 5.45
        //MSQTrackerComplete = 0x240, // updated 5.45
        //MSQTrackerProgress = 0xF1CD, // updated 4.5 ? this actually looks like the two opcodes have been combined, see #474

        //QuestMessage = 0x14b, // updated 5.45

        //QuestTracker = 0xaa, // updated 5.45

        Mount = 0x203, // updated 5.45

        //DirectorVars = 0x19b, // updated 5.45
        //SomeDirectorUnk1 = 0xf4, // updated 5.45
        //SomeDirectorUnk2 = 0x2ce, // updated 5.45
        SomeDirectorUnk4 = 0x1b6, // updated 5.45
        //SomeDirectorUnk8 = 0x1c0, // updated 5.45
        //SomeDirectorUnk16 = 0x36f, // updated 5.45
        //DirectorPopUp = 0x21b, // updated 5.45
        //DirectorPopUp4 = 0x327, // updated 5.45
        //DirectorPopUp8 = 0x374, // updated 5.45

        //CFAvailableContents = 0xF1FD, // updated 4.2

        WeatherChange = 0x240, // updated 5.45
        //PlayerTitleList = 0x14a, // updated 5.45
        //Discovery = 0xc3, // updated 5.45

        //EorzeaTimeOffset = 0x8a, // updated 5.45

        //EquipDisplayFlags = 0x3c0, // updated 5.45

        //MiniCactpotInit = 0x0286, // added 5.31

        /// Housing //////////////////////////////////////

        //LandSetInitialize = 0x264, // updated 5.45
        //LandUpdate = 0x2be, // updated 5.45
        //YardObjectSpawn = 0x1ff, // updated 5.45
        //HousingIndoorInitialize = 0x31b, // updated 5.45
        //LandPriceUpdate = 0x327, // updated 5.45
        //LandInfoSign = 0xba, // updated 5.45
        //LandRename = 0x210, // updated 5.45
        //HousingEstateGreeting = 0x359, // updated 5.45
        //HousingUpdateLandFlagsSlot = 0xe1, // updated 5.45
        //HousingLandFlags = 0x1a1, // updated 5.45
        //HousingShowEstateGuestAccess = 0xa9, // updated 5.45

        //HousingObjectInitialize = 0xd5, // updated 5.45
        //HousingInternalObjectSpawn = 0xe2, // updated 5.45

        HousingWardInfo = 0x331, // updated 5.45
                                 //HousingObjectMove = 0x2e8, // updated 5.45

        //SharedEstateSettingsResponse = 0x3af, // updated 5.45

        //LandUpdateHouseName = 0xba, // updated 5.45

        //LandSetMap = 0x121, // updated 5.45

        //////////////////////////////////////////////////

        //DuelChallenge = 0x0277, // 4.2; this is responsible for opening the ui
        //PerformNote = 0x252, // updated 5.45

        PrepareZoning = 0xab, // updated 5.45
        ActorGauge = 0x278, // updated 5.45

        // daily quest info -> without them sent,  login will take longer...
        //DailyQuests = 0x3ca, // updated 5.45
        //DailyQuestRepeatFlags = 0x3a7, // updated 5.45

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

        AirshipExplorationResult = 0x1a1, // updated 5.45
        AirshipStatus = 0x007D, // added 5.41
        AirshipStatusList = 0x14a, // updated 5.45
        AirshipTimers = 0x01D6, // added 5.41
        SubmarineExplorationResult = 0x34c, // updated 5.45
        SubmarineProgressionStatus = 0x03B4, // added 5.41
        SubmarineStatusList = 0x3bb, // updated 5.45
        SubmarineTimers = 0x03DA, // added 5.41
    };

    /**
    * Client IPC Zone Type Codes.
    */
    enum ClientZoneIpcType : ushort
    {
        //PingHandler = 0x324, // updated 5.45
        //InitHandler = 0xb8, // updated 5.45

        //FinishLoadingHandler = 0x19d, // updated 5.45

        //CFCommenceHandler = 0x184, // updated 5.45

        //CFRegisterDuty = 0xed, // updated 5.45
        //CFRegisterRoulette = 0x102, // updated 5.45
        //PlayTimeHandler = 0x278, // updated 5.45
        //LogoutHandler = 0x72, // updated 5.45
        //CancelLogout = 0x251, // updated 5.45

        //CFDutyInfoHandler = 0x184, // updated 5.45

        //SocialReqSendHandler = 0x264, // updated 5.45
        //CreateCrossWorldLS = 0xc5, // updated 5.45

        ChatHandler = 0x2f2, // updated 5.45

        //SocialListHandler = 0x2ae, // updated 5.45
        SetSearchInfoHandler = 0x19b, // updated 5.45
        //ReqSearchInfoHandler = 0x2ae, // updated 5.45
        //ReqExamineSearchCommentHandler = 0x308, // updated 5.45

        //ReqRemovePlayerFromBlacklist = 0xcc, // updated 5.45
        //BlackListHandler = 0xae, // updated 5.45
        //PlayerSearchHandler = 0x387, // updated 5.45

        //LinkshellListHandler = 0xe6, // updated 5.45

        //MarketBoardRequestItemListingInfo = 0x2f2, // updated 5.45
        //MarketBoardRequestItemListings = 0x184, // updated 5.45
        //MarketBoardSearch = 0x31c, // updated 5.45

        //ReqExamineFcInfo = 0x240, // updated 5.45

        //FcInfoReqHandler = 0x145, // updated 5.45

        //FreeCompanyUpdateShortMessageHandler = 0x0123, // added 5.0

        //ReqMarketWishList = 0x392, // updated 5.45

        //ReqJoinNoviceNetwork = 0x245, // updated 5.45

        //ReqCountdownInitiate = 0x113, // updated 5.45
        //ReqCountdownCancel = 0x78, // updated 5.45

        //ZoneLineHandler = 0x327, // updated 5.45
        ClientTrigger = 0x1e7, // updated 5.45
                                //DiscoveryHandler = 0x102, // updated 5.45

        PlaceFieldMarker = 0x3bc, // updated 5.45
        PlaceFieldMarkerPreset = 0x162, // updated 5.45
        //SkillHandler = 0x3ae, // updated 5.45
        //GMCommand1 = 0xb0, // updated 5.45
        //GMCommand2 = 0x264, // updated 5.45
        //AoESkillHandler = 0x2ac, // updated 5.45

        UpdatePositionHandler = 0xe1, // updated 5.45

        InventoryModifyHandler = 0x120, // updated 5.45

        //InventoryEquipRecommendedItems = 0xed, // updated 5.45

        //ReqPlaceHousingItem = 0x210, // updated 5.45
        //BuildPresetHandler = 0x1f0, // updated 5.45

        //TalkEventHandler = 0x22f, // updated 5.45
        //EmoteEventHandler = 0x291, // updated 5.45
        //WithinRangeEventHandler = 0x261, // updated 5.45
        //OutOfRangeEventHandler = 0x341, // updated 5.45
        //EnterTeriEventHandler = 0x374, // updated 5.45

        //ReturnEventHandler = 0x175, // updated 5.45
        //TradeReturnEventHandler = 0xb4, // updated 5.45

        //LinkshellEventHandler = 0x286, // updated 5.45
        //LinkshellEventHandler1 = 0x286, // updated 5.45

        //ReqEquipDisplayFlagsChange = 0x194, // updated 5.45

        //LandRenameHandler = 0xF177, // updated 5.0
        //HousingUpdateHouseGreeting = 0x1a1, // updated 5.45
        //HousingUpdateObjectPosition = 0x3a2, // updated 5.45

        //SetSharedEstateSettings = 0x243, // updated 5.45

        UpdatePositionInstance = 0xdc, // updated 5.45

        //PerformNoteHandler = 0x3b8, // updated 5.45
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
