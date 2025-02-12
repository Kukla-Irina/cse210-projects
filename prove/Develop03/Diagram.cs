// +------------------------+
// |        Program         |
// +------------------------+
// | - Main()               |
// +------------------------+
//            |
//            | 
//            |
//            ▼
// +--------------------------+
// |      Reference           |
// +--------------------------+
// | - _book: string          |
// | - _chapter: int          |
// | - _verse: int            |
// | - _endVerse: int?        |
// +--------------------------+
// | + Reference(book: string,| 
// | chapter: int, verse: int,|
// | endVerse?: int)          |
// | + GetReference(): string |
// +--------------------------+
//            |
//            | 
//            |
//            ▼
// +----------------------------------+
// |      Scripture                   |
// +----------------------------------+
// | - _reference: Reference          |
// | - _words: List<Word>             |
// +----------------------------------+
// | + Scripture(reference: Reference,| 
// | text: string)                    |
// | + HideWords(count: int): void    |
// | + GetRenderedText(): string      |
// | + IsCompletelyHidden(): bool     |
// +----------------------------------+
//            |
//            | 
//            |
//            ▼
// +-----------------------------+
// |        Word                 |
// +-----------------------------+
// | - _text: string             |
// | - _isHidden: bool           |
// +-----------------------------+
// | + Word(text: string)        |
// | + Hide(): void              |
// | + Show(): void              |
// | + GetRenderedText(): string |
// +-----------------------------+
