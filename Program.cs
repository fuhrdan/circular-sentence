//*****************************************************************************
//** 2490. Circular Sentence    leetcode                                     **
//*****************************************************************************


bool isCircularSentence(char* sentence) {
    char* words[1000];  // Array to store pointers to words, assuming max 100 words
    int wordCount = 0;
    
    // Split the sentence into words
    char* token = strtok(sentence, " ");
    while (token != NULL) {
        words[wordCount++] = token;
        token = strtok(NULL, " ");
    }

    // Check if the last character of the last word matches the first character of the first word
    if (words[wordCount - 1][strlen(words[wordCount - 1]) - 1] != words[0][0]) {
        return false;
    }

    // Loop through each word and check adjacent words' last and first characters
    for (int i = 0; i < wordCount - 1; i++) {
        if (words[i][strlen(words[i]) - 1] != words[i + 1][0]) {
            return false;
        }
    }

    return true;
}