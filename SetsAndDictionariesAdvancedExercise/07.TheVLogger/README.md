## Problem 1.
# Exercises

# : Sets and Dictionaries Advanced

1. Problem 7.\*The V-Logger

Create a program that keeps information about **vloggers** and their **followers**. The **input** will come as e sequence of strings, where each string will represent a **valid** command. The commands will be presented in the following format:

- &quot; **{vloggername}**&quot; **joined The V-Logger** – keep the vlogger in your records.

-
  - Vloggernames **consist**** of only one word**.
  - If the **given**** vloggername **already** exists, ignore **thatcommand**.**

- &quot; **{vloggername} followed {vloggername}**&quot; – The first vlogger followed the second vlogger.

-
  - If **any** of the **given vlogernames**** does not exist **in you collection,** ignore **thatcommand**.**

- **&quot;**** Statistics ****&quot; -** Upon receiving this command, you have to print a statistic about the vloggers.

Each vlogger has an unique **vloggername**. **Vloggers** can **follow other vloggers** and a vlogger **can follow**** as many other vloggers ****as he wants** , but he **cannot** follow **himself** or follow someone he is **already a follower**** of **. You need to print the** total ****count** of **vloggers** in your collection. Then you have to print the **most**** famous ****vlogger** – the one with the most followers, with **his**** followers. **If more than one vloggers have the** same ****number** of **followers** , print theone **following less** people and his **followers** should be printed in **lexicographical order** **(**in case the vlogger has **no followers** , print just the first line, which is described **below** ). Lastly, print the **rest**** vloggers **, ordered by the** count **of followers in** descending **order, then by the number of vloggers he follows in** ascending ****order.** The **whole output must be** in the following format:

**&quot;The V-Logger has a total of {registered vloggers} vloggers in its logs.**

**1.**  **{**** mostFamousV ****logger} : {followers} followers, {followings} following**

**\*  ** {follower1}

\*  {follower2} …

**{No}.**  **{vlogger} : {followers} followers, {followings} following**

**{No}.**  **{vlogger} : {followers} followers, {followings} following**** …&quot;**

### Input

- The input will come in the format described above.

### Output

- On the first line, print **the total count of vloggers** in the format described above.
- On the second line, print the **most**** famous** vlogger in the format described above.
- On the **next** lines, print all of the **rest** vloggers in the format described above.

### Constraints

- There will be **no**** invalid** input.
- There will be no situation where **two**** vloggers **have** equal **count of** followers **and** equal **count of** followings**
- Allowed time/memory: **100ms/16MB**.

### Examples

| **Input** | **Output** |
| --- | --- |
| EmilConrad joined The V-LoggerVenomTheDoctor joined The V-LoggerSaffrona joined The V-LoggerSaffrona **followed** EmilConradSaffrona **followed** VenomTheDoctorEmilConrad **followed** VenomTheDoctorVenomTheDoctor **followed** VenomTheDoctorSaffrona **followed** EmilConradStatistics | The V-Logger has a total of 3 vloggers in its logs.1. VenomTheDoctor : 2 followers, 0 following\*  EmilConrad\*  Saffrona2. EmilConrad : 1 followers, 1 following3. Saffrona : 0 followers, 2 following                   |
| JennaMarbles joined The V-LoggerJennaMarbles followed ZoellaAmazingPhil joined The V-LoggerJennaMarbles followed AmazingPhilZoella joined The V-LoggerJennaMarbles followed ZoellaZoella followed AmazingPhilChristy followed ZoellaZoella followed ChristyJacksGap joined The V-LoggerJacksGap followed JennaMarblesPewDiePie joined The V-LoggerZoella joined The V-LoggerStatistics | The V-Logger has a total of 5 vloggers in its logs.1. AmazingPhil : 2 followers, 0 following\*  JennaMarbles\*  Zoella2. Zoella : 1 followers, 1 following3. JennaMarbles : 1 followers, 2 following4. PewDiePie : 0 followers, 0 following5. JacksGap : 0 followers, 1 following |

