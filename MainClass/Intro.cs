using System;
using System.Linq;

public static class Intro
{
    /* private string teamLogo;
    private string gameName;

    public string GameName
    {
        get
        {
            return this.gameName;
        }
        private set
        {
            this.gameName = value;
        }
    }

    //properties
    public string TeamLogo
    {
        get
        {
            return this.teamLogo;
        }
        private set
        {
            this.teamLogo = value;
        }
    }

    //constructors
    public Intro(string teamLogo)
    {
        this.teamLogo = teamLogo;
    }

    public Intro(string teamLogo, string gameName)
    {
        this.teamLogo = teamLogo;
        this.gameName = gameName;
    }
       */
    public static void PrintLogo()
    {
        Console.WriteLine(@" 
                         M 8 M                              
                        $  N =                              
                        M    M                              
                         M7   DM                            
                        M 7     M                 M  M      
                        ?       M           =MMM M   M      
                       :M  MMMMMM$MMMMI     M       M       
                        IMMMMMMM   ,MMMM   M, M M  M        
                           MNMM      MMDMMM   M  M          
                         OM   M      MM  M    M   M         
                        MM    M     MNM      ,    M         
             MMMMM   NMMM  MMM:     M           MM,         
           MMMMMMMMM      MM    MMM M         MM            
        ?MMMMMMMMMMMMN         +   M           M            
       M+ MMMMMMMMMMMMM                        M            
      M   MMMMMMMMMMMMMM                       ZM           
      M    MMMMMMMMMMMMM              M         M           
      M    ?MMMMMMMMMM                          M           
      M,     MMMMMM                    M        M           
       M       M                     M          MN          
        M      M                   M M   :      MM          
               M                   MM    M      MM          
           M     M                M M    M      MN          
           M    M  MI            M~M    M       M           
             MM  M M  MMM=    MMO IM    M       M           
                M  M       M      M    M        M           
                MD   MM         MM     M        M           
                 MM      MMMMM$       M        MZ           
                   :MM,              M,        M            
                   MM            MM           ,M            
                     MMMMMMMMMMM,             M             
                   ,M                        ZN   ,MMMMM    
                   M                      =MMM   MMMMMMM    
                  M:                   MMMMMMM   MMMMMMM    
                  M          MMMMMM    MMMMMMMM  MMMMMM7    
                 MMMMMMM     MMMMMM    :MMMMMMM+ MM MMM     
         MMMM:MMMMMMMMMM     MMMMMMM     MMMMMMM MM MMMM    
 MMMMMMMMMMMM MMMMMMMMMMM    MMMMMMMM    MMM MMMMMM MMMM    
 MMMMMMMMMMMMMMMMMMMMMMMM    MMM MMMM     MM$MMMMMM +MMM    
 MMMMMMMMMMMM MMMMMM  MMM    MMM +MMMM    MMM MMMMM  MMMM   
  MMM$MMMM NMM $MMMM  $      8MM ,MMMM    MMM MMMMM  MMMM   
  MM  MMMM  MM  MMMMMMMO     OMMMMMMMMMN  +MM MZMMM  MMMMM~ 
  MM  MMMM  M  MMMMMMMM  MNMMMMMMM MMMM    MMMM MMMM MMMMMM 
       MMM  =MMN MMMM  MMMM  =MM    MMMMM MMMMM,NMMM MMMMMM 
       MMMM   MM$MMMM   MMM  DMMMM MMMMMMMMMMMMM MMM MMMMMM 
       MMMM ,MMMMMMMMMMMMMM  MMMMM MMMMMMMMMMMMM  MM        
       MMMM   , MMMMMMMMMMMMMMMMMM MMMMMMM MMM              
      MMMMMMM   ?MMMMMMMMMMM MMMMM7 M?                      
       MMMMMMM  MMMMM                                       
       MMMMMM,");                                              


        while (Console.KeyAvailable)
        {
        }
        var key = Console.ReadKey();
        Console.Clear();
    }

    public static void PrintNames()
    {

        Console.WriteLine(@"
                              




    ___    __                          __             ____                        
   /   |  / /__  _  ______ _____  ____/ /__  _____   / __ \____  ____  ____ _   __
  / /| | / / _ \| |/_/ __ `/ __ \/ __  / _ \/ ___/  / /_/ / __ \/ __ \/ __ \ | / /
 / ___ |/ /  __/>  </ /_/ / / / / /_/ /  __/ /     / ____/ /_/ / /_/ / /_/ / |/ / 
/_/  |_/_/\___/_/|_|\__,_/_/ /_/\__,_/\___/_/     /_/    \____/ .___/\____/|___/  
                                                             /_/                    
           ____                  __         ______                 __                    
          /  _/   ______ ___  __/ /___     / ____/___ _____  _____/ /_  ___ _   __       
          / /| | / / __ `/ / / / / __ \   / / __/ __ `/ __ \/ ___/ __ \/ _ \ | / /       
        _/ / | |/ / /_/ / /_/ / / /_/ /  / /_/ / /_/ / / / / /__/ / / /  __/ |/ /        
       /___/ |___/\__,_/\__, /_/\____/   \____/\__,_/_/ /_/\___/_/ /_/\___/|___/         
                       /____/                                                       
                ______                      _    _____ __        _ __                          
               / ____/__  ____  _________ _(_)  / ___// /_____  (_) /______ _   __             
              / / __/ _ \/ __ \/ ___/ __ `/ /   \__ \/ __/ __ \/ / //_/ __ \ | / /             
             / /_/ /  __/ /_/ / /  / /_/ / /   ___/ / /_/ /_/ / / ,< / /_/ / |/ /              
             \____/\___/\____/_/   \__, /_/   /____/\__/\____/_/_/|_|\____/|___/               
                                  /____/                                                                   				
                         _   __         ____            _   __         __          
                        / | / /__  ____/ / /______     / | / /__  ____/ /__ _   __
                       /  |/ / _ \/ __  / //_/ __ \   /  |/ / _ \/ __  / _ \ | / /
                      / /|  /  __/ /_/ / ,< / /_/ /  / /|  /  __/ /_/ /  __/ |/ /
                     /_/ |_/\___/\__,_/_/|_|\____/  /_/ |_/\___/\__,_/\___/|___/       
");

        while (Console.KeyAvailable)
        {
        }
        var key = Console.ReadKey();
        Console.Clear();
    }
    public static void PrintGame()
    {
        Console.WriteLine(@"




                                       .DM.                                 
                 ... ..    , .      . MD..                                  
                .$MMMM..  MMM.   .. M+.                                     
                 MMMMMM . MMM.. . M~.                                       
                 MMMMMM..IMMD..~M   . .                                     
                .MMMMM7..MMM.ZM .  $MMM                                     
                 .=MM,.  MMMM....DMMMMM                          MM         
                        IMMN...MMMMMM..                        ..M          
                    . :MMMM .MMMMMM                         .MMM .M         
                  ..ZMMMMM8.MMMMD                           .MMMMM          
                  =MMMMM+....MMM,                      .MMMM  .MMMMM        
                  MMMM . .   ~MMM .           ...    .MM .MMM    MMMM..     
                  .. .      ..MMMM.           M..   MMMMM  MMM   .MMM.      
                              .MMM=.        M+        MMMM..MMM. .M.        
                              ..MMM    ..,M .  M .MMM..MMMM..MMM            
                                ZMMM.  ~M..   MM. .MMMM NMMM MM  .MMM       
                                .MMM +M ..    MMM. .MMM   MMM  .M   ..      
                                 ..OM....MMMM..MMM.  MMM  .  MMMMM  M.      
                                 MD... MM  MMMM MMM   M    MM  MMMM MM      
                               M+ . M  MMM. MMMM.MMMM     .M   .MMMM   .M.  
                           ..M=. M MMM MMMM .MMM.     .MM   M    MMMM  MM.  
                        ..:M    MM      MMMM  MM.    MMMMMM..M   .MMMM..    
                    M.. NM.  M  MMM      MMMM..   MM.  .MMMMM.     MM.      
                    .I8$... MMM..MMM.   M       MMMMM.   MMMMMM             
                         .M   .. MMMM.  M.       .MMMM     MMMM             
                          MMMMMMM..MMMM.M  .MMMMM  MMMM      M.             
                          MMMMMMMM. ..    MM  MMMM. MMMM                    
                             .  .M.     MMMMM..MMMM  MMMMM.                 
                            MM. .M        MMMM. MMMM  MM                    
                              M.           MMMM. MMM                        
                                           .MMMM..M                         
                                            .MMMM .                         
                                             .M.
");

    }

}