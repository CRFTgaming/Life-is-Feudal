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
		1, 			//Interval of message display, in minutes.
		false,		//Show message in "System" channel. Message is shown if value is "true".
		true,		//Show message in "Local" channel. Message is shown if value is "true".
		"message"	//Message text to be shown. Message support default coloring.
	);
*/

//Delay in seconds after player spawn before sending messages
$BasilMod::motd::welcome_delay = 5;

//Example setup of greetings messages, and samples for messages with timeouts
BasilMod::motd_registerWelcome(true, true, "This is system and message to display at system and local channels.");
BasilMod::motd_registerWelcome(false, true, "This is local only message.");
BasilMod::motd_registerWelcome(true, false, "This is system only message.");
  
BasilMod::motd_registerWelcome(true, false, "This server supports BasilMod::Pack. To enable TradeWindow and other mods, visit link http://my-kickass-server.earth/modpacks.");
BasilMod::motd_registerWelcome(true, false, "Follow rules of the server! Feel free to ask GM for help.");

BasilMod::motd_registerPeriodic(1, true, false, "This message will appear every minute in System!");
BasilMod::motd_registerPeriodic(5, false, true, "This is message to display every 5 minutes in Local chat");

BasilMod::motd_registerPeriodic(60, true, false, "Scheduled maintenance is performed every day at 00:00 GMT.");