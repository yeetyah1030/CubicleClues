VAR name = "Michael"
VAR points = 0

->introduction 

=== introduction ===
- Hi, my name is Robert, you can call me Rob. Welcome to the company, let me know if you have any questions about your work, you will be working on my team. #gameText:blue
 * Hi Rob, how are you?
    {plus (points)}
    I'm doing well, thanks. I do have a ton of work waiting for me. If we can hurry and get this over with, so I can go back to my tasks. #gameText:blue
      ** How are the daily tasks usually distributed?
      Well, we usually discuss that during our daily team meetings in the morning where we will be going over everyone's progress, tasks and plan for the day. Then, we pretty much just spend the rest of the day organizing important files, scheduling appointments, assisting other staff members with their work and drafting correspondance or messages. #gameText:blue
          *** That is hella lame bruh.
          {minus(points)}
          If you would like to quit on your first day, feel free. No one is stopping you. #gameText:blue
          *** What about the breaks?
          The team usually hang out on the rooftop during breaks. I usually stay in my cubicle to finish my work, but it is totally up to you. #gameText:blue
      ** Can you tell me a bit more about yourself?
      Well, not much to say. I've been working here for the last couple of decades or so, making money for my wife and my two kids at home. Just a man taking care of his family, you know? #gameText:blue
          *** Sounds like a happy family! How long have you been with your wife?
          {plus (points)}
          It seems like it, doesn't it... Kid, you are too young to understand women, what they truly want. I've been with my wife since high school, for about 20 years now? And sometimes I don't know if I really know her... Anyways... #gameText:blue
            **** Can you elaborate?
            See kid, I think women are no different... actually, really worse than men. All they really want is a young and attractive guy with money and drive, even when they have been with you for years. #gameText:blue
                ***** I'm sorry to hear that, Rob.
                It's fine. I guess it's us men's destiny. #gameText:blue
          *** How old are your kids?
          My little princesses... one of them are 7 and the other one is turning 10 in a month. The two and only girls that have all my heart. #gameText:blue
            **** Two and only? What about your wife?
            My wife? I don't want to talk about her. Can we change subject? #gameText:blue
            **** Congratulations! You seem like an amazing father.
            Thanks. #gameText:blue
            
- I'm assuming that you have already talked to Lori? #gameText:blue
    * Uh... Who's Lori?
    Lori works in Human Resources. She should be responsible for your training. #gameText:blue
        ** Oh yeah! I talked to her earlier today. She's amazing!
        Yeah, that girl's good at her job. She knows everything that's going around here. #gameText:blue
        ** Doesn't ring a bell...
        Okay... Anyway, just let me know when you get to the next portion of the training, I'll be helping you out with the daily tasks. #gameText:blue
    * Yeah I did!
    How are you finding your first day here so far? #gameText:blue
        ** Great! I was wondering if you have any insights on the job, what I should expect from our coworkers?
        They're generally... good? People a competent but they love to slack. But you know, that's how it goes when you're working in a corporation. Jeff is pretty good though, I like that kid. #gameText:blue
        ** Meh could be more entertaining, to be honest.
        {minus (points)}
        What did you expect? It's a trading company, not an amusement park. #gameText:blue
    
            
- Actually, why did you want to join this company, kid? ...Michael, is it? #gameText:blue
 * I'm a private investigator looking into the death of Christopher Cook.
    {minus (points)}
    ... I see. I'm sorry but I do have to run, wish I could help you more. I just remembered I have something scheduled in a bit. I'll talk to you later. It was great talking to you. #gameText:blue
 * I have been wanting to work here since university.
 {plus (points)}
 Ambitious guy, I like that. #gameText:blue
    ** Before you go, I wanted to ask you about Christopher Cook!
    ... Christopher? Why? What do you want? #gameText:blue
        *** I was just wondering what happened to him.
        Oh, the kid commited suicide here... Jumped off the rooftop. I don't know much more. #gameText:blue
            **** How was he as a person? You worked with him right?
            Chris was a charming young guy, he had all the attention of the company. I heard he was gonna be promoted too. What a tragedy. #gameText:blue
            Anyways, I gotta run. See you around, kid. #gameText:blue
            **** How are you dealing with this loss?
            I mean, I prefer not to talk about it. You know? I don't like to talk about emotional things like that. #gameText:blue
            Anyways, I gotta run. See you around, kid. #gameText:blue
        *** I heard about his passing, I assume that you must be heavily affected by his death...
        Yeah... The kid had a good future ahead of him, don't know why he did that. I wish I had his chance, the opportunities he was offered... #gameText:blue
            **** What do you mean? The opportunies... What opportunities?
            Well you know, god made him a good looking guy, so he had all the girls around him. He was also going to get promoted or so I heard. Two things I never got to have in this lifetime. #gameText:blue
            Anyways, I gotta run. See you around. #gameText:blue
            **** I see... 
            Yeah... I got a ton of work waiting for me. I gotta run. I'll see you around. #gameText:blue
                
- 
    * See you around Rob.
     

    -> END
    
=== function plus (ref x)
    ~ points -= 1
    
=== function minus (ref x)
    ~ points += 1