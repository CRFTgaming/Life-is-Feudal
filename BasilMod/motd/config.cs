/*
	BasilMod::motd mod
	2015 Basil Semuonov
	

	Configure messages for MotD greetings when player joins server.
	Add periodic messages to be sended by the server to the players.
	
	Current version (standalone BasilMod::motd) limits message length to 230 letters.
	
	Example:

	Add message to be shown when player joins server.
	BasilMod::motd_registerWelcome(
		true,		//Show message in "System" channel. Message is shown if value is "true".
		false,		//Show message in "Local" channel. Message is shown if value is "true".
		"message"	//Message text to be shown. Message support default coloring.
	);
	
	Add periodic message to be shown to players.
	BasilMod::motd_registerPeriodic(
		15, 			//Interval of message display, in minutes.
		true,		//Show message in "System" channel. Message is shown if value is "true".
		false,		//Show message in "Local" channel. Message is shown if value is "true".
		"message"	//Message text to be shown. Message support default coloring.
	);
*/

//Delay in seconds after player spawn before sending messages
$BasilMod::motd::welcome_delay = 5;

//Example setup of greetings messages, and samples for messages with timeouts
BasilMod::motd_registerWelcome(true, true, "Welcome To CRFTGaming's LiF Server Lite RP PvP & PvE");
BasilMod::motd_registerWelcome(false, true, "CRFTGaming's LiF RP Server");
BasilMod::motd_registerWelcome(true, false, "Check The Website For Server Rules, Suggestions, & Bug Reports");
  
BasilMod::motd_registerWelcome(true, false, "This server supports BasilMod");
BasilMod::motd_registerWelcome(true, false, "Follow rules of the server! Feel free to ask GM for help.");

BasilMod::motd_registerPeriodic(25, true, false, "WWW.CRFTGaming.ORG TeamSpeak:192.111.144.6");
BasilMod::motd_registerPeriodic(25, false, true, "Are You A New Player ? Ask A GM For Your Starter Kit");

BasilMod::motd_registerPeriodic(45, true, false, "JOIN THE FORUMS ::: WWW.CRFTGAMING.ORG ::: TS:192.111.144.6");