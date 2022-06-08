Console.WriteLine(@"
    
  \   /
  - | - 
  / | \
    |
    |   __
  __|___||__
  | ______ |
  | |osc | |  
  | |____| |
  |        |
  |        |
  | .::::. |
  | :::::: |
  | `::::` |
  |________|
");


SimpleOSC simpleOSC = new();
List<SimpleOSC.OSCMessage> msg = new();
simpleOSC.OpenClient(9001);
while (true){
    simpleOSC.GetIncomingOSC(msg);
    foreach (SimpleOSC.OSCMessage m in msg)
    {
        if (m.path == "/avatar/parameters/unmute")
           SendKeys.SendWait("{PGDN}");
    }
    msg.Clear();
    Thread.Sleep(100);
}
